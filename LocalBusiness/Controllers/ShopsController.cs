using LocalBusiness.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBusiness.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShopsController : ControllerBase
  {
    private LocalBusinessContext _db;

    public ShopsController(LocalBusinessContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Shop>> GetAll(string shopName, string shopAddress, string shopType, string shopYelpRating)
    {
      var query = _db.Shops.AsQueryable();

      if (shopName != null)
      {
        query = query.Where(entry => entry.ShopName == shopName);
      }

      if (shopAddress != null)
      {
        query = query.Where(entry => entry.ShopAddress == shopAddress);
      }

      if (shopType != null)
      {
        query = query.Where(entry => entry.ShopType == shopType);
      }

      if (shopYelpRating != null)
      {
        query = query.Where(entry => entry.ShopYelpRating == shopYelpRating);
      }

      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Shop shop)
    {
      _db.Shops.Add(shop);
      _db.SaveChanges();
    }

    [HttpGet ("{id}")]
    public ActionResult<Shop> Get(int id)
    {
      return _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
    }

    [HttpGet("page")]
    public ActionResult GetPage([FromQuery] UrlQuery urlQuery)
    {
      var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);

      var pagedData = _db.Shops
        .OrderBy(shop => shop.ShopId)
        .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
        .Take(validUrlQuery.PageSize);
      
      return Ok(pagedData);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Shop shop)
    {
      shop.ShopId = id;

      _db.Entry(shop).State = EntityState.Modified;

      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var shopToDelete = _db.Shops.FirstOrDefault(entry => entry.ShopId == id);

      _db.Shops.Remove(shopToDelete);

      _db.SaveChanges();
    }
  }
}