using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
  public class LocalBusinessContext : DbContext
  {
    public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options)
      : base(options)
    {
    }

    public DbSet<Restaurant> Restaurants { get; set; }

    public DbSet<Shop> Shops { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Restaurant>()
        .HasData(
          new Restaurant {
            RestaurantId = 1,
            RestaurantName = "Harry's Diner",
            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
            RestaurantType = "American, Diner",
            RestaurantYelpRating = "3 Stars"
            },
          new Restaurant {
            RestaurantId = 2,
            RestaurantName = "Wacky's Burgers",
            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
            RestaurantType = "Hamburgers",
            RestaurantYelpRating = "2 Stars"
            },
          new Restaurant {
            RestaurantId = 3,
            RestaurantName = "Terrible Tina's House of Slop",
            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
            RestaurantType = "Cafeteria",
            RestaurantYelpRating = "4 Stars"
            },
          new Restaurant {
            RestaurantId = 4,
            RestaurantName = "Lattakia Restaurant",
            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
            RestaurantType = "Levantine",
            RestaurantYelpRating = "5 Stars"
            },
          new Restaurant {
            RestaurantId = 5,
            RestaurantName = "Heisshund Hot Dogs",
            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
            RestaurantType = "Hot Dog Stand",
            RestaurantYelpRating = "3 Stars"
            },
          new Restaurant {
            RestaurantId = 6,
            RestaurantName = "Tom & Flip's BBQ",
            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
            RestaurantType = "Barbecue",
            RestaurantYelpRating = "4 Stars"
            },
          new Restaurant {
            RestaurantId = 7,
            RestaurantName = "City of Pigs",
            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
            RestaurantType = "Barbecue",
            RestaurantYelpRating = "3 Stars"
            },
          new Restaurant {
            RestaurantId = 8,
            RestaurantName = "Kyushu Sushi",
            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
            RestaurantType = "Sushi",
            RestaurantYelpRating = "3 Stars"
            }
        );

      builder.Entity<Shop>()
        .HasData(
          new Shop {ShopId = 1, ShopName = "Larry's Laundry", ShopAddress = "8465 Adams Dr, Greer, SC 29650", ShopType = "Laundromat", ShopYelpRating = "3 Stars"},
          new Shop {ShopId = 2, ShopName = "Christine Gontarek, Attorney at Law", ShopAddress = "37 Applegate Ave, Merrillville, IN 46410", ShopType = "Attorney", ShopYelpRating = "4 stars"},
          new Shop {ShopId = 3, ShopName = "Wackey's Clown Service", ShopAddress = "9550 Sugar Rd, Phillipsburg, NJ 08865", ShopType = "Entertainment", ShopYelpRating = "2 Stars"},
          new Shop {ShopId = 4, ShopName = "Clump Book Sellers", ShopAddress = "80 Wall Ct, Oak Ridge, TN 37830", ShopType = "Bookstore", ShopYelpRating = "3 Stars"},
          new Shop {ShopId = 5, ShopName = "Happy George's Meat Shop", ShopAddress = "71 Chestnut Dr, St Albans, NY 11412", ShopType = "Butcher", ShopYelpRating = "5 Stars"},
          new Shop {ShopId = 6, ShopName = "Lucy's Firing Range", ShopAddress = "844 W Wild Horse Ct, Everett, MA 02149", ShopType = "Firing Range", ShopYelpRating = "3 Stars"},
          new Shop {ShopId = 7, ShopName = "Deputy Hawk Filling Station", ShopAddress = "8986 Bear Hill St, Nashville, TN 37205", ShopType = "Petrol Station", ShopYelpRating = "5 Stars"},
          new Shop {ShopId = 8, ShopName = "Laura's Plastics", ShopAddress = "83 Ridgewood Ave, Boca Raton, FL 33428", ShopType = "Bulk Plastic Vendor", ShopYelpRating = "2 Stars"},
          new Shop {ShopId = 9, ShopName = "Andy's Boot Barn", ShopAddress = "660 Cooper St, Tullahoma, TN 37388", ShopType = "Shoe Store", ShopYelpRating = "1 Star"},
          new Shop {ShopId = 10, ShopName = "Uncle Joe's Aromas", ShopAddress = "736 Birch Hill Ave, Easley, SC 29640", ShopType = "Perfume Vendor", ShopYelpRating = "1 Star"},
          new Shop {ShopId = 11, ShopName = "Fast & Fresh Grocery", ShopAddress = "9659 Amherst Dr, Ypsilanti, MI 48197", ShopType = "Grocery Store", ShopYelpRating = "4 Stars"},
          new Shop {ShopId = 12, ShopName = "Jefferson Regional Hospital", ShopAddress = "92 Grant Dr, Myrtle Beach, SC 29577", ShopType = "Hospital", ShopYelpRating = "3 Stars"},
          new Shop {ShopId = 13, ShopName = "Angry Dave's Fertilizer", ShopAddress = "9825 N Jefferson St, Warner Robins, GA 31088", ShopType = "Garden Supply Store", ShopYelpRating = "3 Stars"},
          new Shop {ShopId = 14, ShopName = "Westward Contractors", ShopAddress = "8571 W Theatre Ln, Pataskala, OH 43062", ShopType = "Construction", ShopYelpRating = "1 Star"},
          new Shop {ShopId = 15, ShopName = "View Bag Video", ShopAddress = "635 Glenridge Ave, Mooresville, NC 28115", ShopType = "Video Rental", ShopYelpRating = "4 Stars"},
          new Shop {ShopId = 16, ShopName = "Lattakia Rug Shop", ShopAddress = "33 Madison St, Mt Prospect, IL 60056", ShopType = "Rug Store", ShopYelpRating = "5 Stars"},
          new Shop {ShopId = 17, ShopName = "Twist & Shout", ShopAddress = "57 W Hilltop Dr, Missoula, MT 59801", ShopType = "Record Store", ShopYelpRating = "2 Stars"},
          new Shop {ShopId = 18, ShopName = "Zimmer's Lookin' Good Shop", ShopAddress = "278 Boston Dr, Green Cove Spgs, FL 32043", ShopType = "Tailor", ShopYelpRating = "5 Stars"},
          new Shop {ShopId = 19, ShopName = "Pig Palace", ShopAddress = "647 Somerset Ln, San Jose, CA 95127", ShopType = "Farm Supply", ShopYelpRating = "1 Star"},
          new Shop {ShopId = 20, ShopName = "Fancy Freight", ShopAddress = "7225 Mayfair Dr, Mankato, MN 56001", ShopType = "Shipping Company", ShopYelpRating = "4 Stars"}
        );
    }
  }
}