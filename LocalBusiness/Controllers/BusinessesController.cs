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
  public class BusinessesController : ControllerBase
  {
    private LocalBusinessContext _db;

    public BusinessesController(LocalBusinessContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Business>> GetAll(string businessName, string businessAddress, string businessType, string businessYelpRating)
    {
      var query = _db.Businesses.AsQueryable();

      if (businessName != null)
      {
        query = query.Where(entry => entry.BusinessName == businessName);
      }

      if (businessAddress != null)
      {
        query = query.Where(entry => entry.BusinessAddress == businessAddress);
      }

      if (businessType != null)
      {
        query = query.Where(entry => entry.BusinessType == businessType);
      }

      if (businessYelpRating != null)
      {
        query = query.Where(entry => entry.BusinessYelpRating == businessYelpRating);
      }

      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Business business)
    {
      _db.Businesses.Add(business);
      _db.SaveChanges();
    }

    [HttpGet ("{id}")]
    public ActionResult<Business> Get(int id)
    {
      return _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
    }

    [HttpGet("page")]
    public ActionResult GetPage([FromQuery] UrlQuery urlQuery)
    {
      var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);

      var pagedData = _db.Businesses
        .OrderBy(business => business.BusinessId)
        .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
        .Take(validUrlQuery.PageSize);
      
      return Ok(pagedData);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Business business)
    {
      business.BusinessId = id;
      _db.Entry(business).State = EntityState.Modified;
      _db.SaveChanges();
    }
  }
}