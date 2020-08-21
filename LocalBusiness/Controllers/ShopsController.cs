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
  public class RestaurantsController : ControllerBase
  {
    private LocalBusinessContext _db;

    public RestaurantsController(LocalBusinessContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Restaurant>> GetAll(string restaurantName, string restaurantAddress, string restaurantType, string restaurantYelpRating)
    {
      var query = _db.Restaurants.AsQueryable();

      if (restaurantName != null)
      {
        query = query.Where(entry => entry.RestaurantName == restaurantName);
      }

      if (restaurantAddress != null)
      {
        query = query.Where(entry => entry.RestaurantAddress == restaurantAddress);
      }

      if (restaurantType != null)
      {
        query = query.Where(entry => entry.RestaurantType == restaurantType);
      }

      if (restaurantYelpRating != null)
      {
        query = query.Where(entry => entry.RestaurantYelpRating == restaurantYelpRating);
      }

      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
    }

    [HttpGet ("{id}")]
    public ActionResult<Restaurant> Get(int id)
    {
      return _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
    }

    [HttpGet("page")]
    public ActionResult GetPage([FromQuery] UrlQuery urlQuery)
    {
      var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);

      var pagedData = _db.Restaurants
        .OrderBy(restaurant => restaurant.RestaurantId)
        .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
        .Take(validUrlQuery.PageSize);
      
      return Ok(pagedData);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Restaurant restaurant)
    {
      restaurant.RestaurantId = id;

      _db.Entry(restaurant).State = EntityState.Modified;

      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var restaurantToDelete = _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);

      _db.Restaurants.Remove(restaurantToDelete);

      _db.SaveChanges();
    }
  }
}