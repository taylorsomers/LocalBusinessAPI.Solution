using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace LocalBusiness.Models
{
  public class Business
  {
    public int BusinessId { get; set; }

    public string BusinessName { get; set; }

    public string BusinessAddress { get; set; }

    public string BusinessType { get; set; }

    public string BusinessYelpRating { get; set; }
  }
}