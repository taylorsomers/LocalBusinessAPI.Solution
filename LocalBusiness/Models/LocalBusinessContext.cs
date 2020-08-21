using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
  public class LocalBusinessContext : DbContext
  {
    public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options)
      : base(options)
    {
    }

    public DbSet<Business> Businesses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business {BusinessId = 1, BusinessName = "Larry's Laundry", BusinessAddress = "8465 Adams Dr, Greer, SC 29650", BusinessType = "Laundromat", BusinessYelpRating = "3 Stars"},
          new Business {BusinessId = 2, BusinessName = "Christine Gontarek, Attorney at Law", BusinessAddress = "37 Applegate Ave, Merrillville, IN 46410", BusinessType = "Attorney", BusinessYelpRating = "4 stars"},
          new Business {BusinessId = 3, BusinessName = "Wackey's Burgers & Clown Service", BusinessAddress = "9550 Sugar Rd, Phillipsburg, NJ 08865", BusinessType = "Restaurant, Entertainment", BusinessYelpRating = "2 Stars"},
          new Business {BusinessId = 4, BusinessName = "Clump Book Sellers", BusinessAddress = "80 Wall Ct, Oak Ridge, TN 37830", BusinessType = "Bookstore", BusinessYelpRating = "3 Stars"},
          new Business {BusinessId = 5, BusinessName = "Happy George's Meat Roasters", BusinessAddress = "71 Chestnut Dr, St Albans, NY 11412", BusinessType = "Restaurant", BusinessYelpRating = "5 Stars"},
          new Business {BusinessId = 6, BusinessName = "Lucy's Firing Range", BusinessAddress = "844 W Wild Horse Ct, Everett, MA 02149", BusinessType = "Firing Range", BusinessYelpRating = "3 Stars"},
          new Business {BusinessId = 7, BusinessName = "Deputy Hawk Filling Station", BusinessAddress = "8986 Bear Hill St, Nashville, TN 37205", BusinessType = "Petrol Station", BusinessYelpRating = "5 Stars"},
          new Business {BusinessId = 8, BusinessName = "Laura's Plastics", BusinessAddress = "83 Ridgewood Ave, Boca Raton, FL 33428", BusinessType = "Bulk Plastic Vendor", BusinessYelpRating = "2 Stars"},
          new Business {BusinessId = 9, BusinessName = "Andy's Boot Barn", BusinessAddress = "660 Cooper St, Tullahoma, TN 37388", BusinessType = "Shoe Store", BusinessYelpRating = "1 Star"},
          new Business {BusinessId = 10, BusinessName = "Uncle Joe's Aromas", BusinessAddress = "736 Birch Hill Ave, Easley, SC 29640", BusinessType = "Perfume Vendor", BusinessYelpRating = "1 Star"},
          new Business {BusinessId = 11, BusinessName = "Fast & Fresh Grocery", BusinessAddress = "9659 Amherst Dr, Ypsilanti, MI 48197", BusinessType = "Grocery Store", BusinessYelpRating = "4 Stars"},
          new Business {BusinessId = 12, BusinessName = "Jefferson Regional Hospital", BusinessAddress = "92 Grant Dr, Myrtle Beach, SC 29577", BusinessType = "Hospital", BusinessYelpRating = "3 Stars"},
          new Business {BusinessId = 13, BusinessName = "Angry Dave's Fertilizer", BusinessAddress = "9825 N Jefferson St, Warner Robins, GA 31088", BusinessType = "Garden Supply Store", BusinessYelpRating = "3 Stars"},
          new Business {BusinessId = 14, BusinessName = "Westward Contractors", BusinessAddress = "8571 W Theatre Ln, Pataskala, OH 43062", BusinessType = "Construction", BusinessYelpRating = "1 Star"},
          new Business {BusinessId = 15, BusinessName = "View Bag Video", BusinessAddress = "635 Glenridge Ave, Mooresville, NC 28115", BusinessType = "Video Rental", BusinessYelpRating = "4 Stars"},
          new Business {BusinessId = 16, BusinessName = "Lattakia Restaurant", BusinessAddress = "33 Madison St, Mt Prospect, IL 60056", BusinessType = "Restaurant", BusinessYelpRating = "5 Stars"},
          new Business {BusinessId = 17, BusinessName = "Twist & Shout", BusinessAddress = "57 W Hilltop Dr, Missoula, MT 59801", BusinessType = "Record Store", BusinessYelpRating = "2 Stars"},
          new Business {BusinessId = 18, BusinessName = "Zimmer's Lookin' Good Shop", BusinessAddress = "278 Boston Dr, Green Cove Spgs, FL 32043", BusinessType = "Tailor", BusinessYelpRating = "5 Stars"},
          new Business {BusinessId = 19, BusinessName = "Pig Palace", BusinessAddress = "647 Somerset Ln, San Jose, CA 95127", BusinessType = "Barbecue", BusinessYelpRating = "1 Star"},
          new Business {BusinessId = 20, BusinessName = "Fancy Freight", BusinessAddress = "7225 Mayfair Dr, Mankato, MN 56001", BusinessType = "Shipping Company", BusinessYelpRating = "4 Stars"}
        );
    }
  }
}