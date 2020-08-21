﻿// <auto-generated />
using LocalBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBusiness.Migrations
{
    [DbContext(typeof(LocalBusinessContext))]
    [Migration("20200821213838_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocalBusiness.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RestaurantAddress");

                    b.Property<string>("RestaurantName");

                    b.Property<string>("RestaurantType");

                    b.Property<string>("RestaurantYelpRating");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
                            RestaurantName = "Harry's Diner",
                            RestaurantType = "American, Diner",
                            RestaurantYelpRating = "3 Stars"
                        },
                        new
                        {
                            RestaurantId = 2,
                            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
                            RestaurantName = "Wacky's Burgers",
                            RestaurantType = "Hamburgers",
                            RestaurantYelpRating = "2 Stars"
                        },
                        new
                        {
                            RestaurantId = 3,
                            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
                            RestaurantName = "Terrible Tina's House of Slop",
                            RestaurantType = "Cafeteria",
                            RestaurantYelpRating = "4 Stars"
                        },
                        new
                        {
                            RestaurantId = 4,
                            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
                            RestaurantName = "Lattakia Restaurant",
                            RestaurantType = "Levantine",
                            RestaurantYelpRating = "5 Stars"
                        },
                        new
                        {
                            RestaurantId = 5,
                            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
                            RestaurantName = "Heisshund Hot Dogs",
                            RestaurantType = "Hot Dog Stand",
                            RestaurantYelpRating = "3 Stars"
                        },
                        new
                        {
                            RestaurantId = 6,
                            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
                            RestaurantName = "Tom & Flip's BBQ",
                            RestaurantType = "Barbecue",
                            RestaurantYelpRating = "4 Stars"
                        },
                        new
                        {
                            RestaurantId = 7,
                            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
                            RestaurantName = "City of Pigs",
                            RestaurantType = "Barbecue",
                            RestaurantYelpRating = "3 Stars"
                        },
                        new
                        {
                            RestaurantId = 8,
                            RestaurantAddress = "8465 Adams Dr, Greer, SC 29650",
                            RestaurantName = "Kyushu Sushi",
                            RestaurantType = "Sushi",
                            RestaurantYelpRating = "3 Stars"
                        });
                });

            modelBuilder.Entity("LocalBusiness.Models.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ShopAddress");

                    b.Property<string>("ShopName");

                    b.Property<string>("ShopType");

                    b.Property<string>("ShopYelpRating");

                    b.HasKey("ShopId");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            ShopId = 1,
                            ShopAddress = "8465 Adams Dr, Greer, SC 29650",
                            ShopName = "Larry's Laundry",
                            ShopType = "Laundromat",
                            ShopYelpRating = "3 Stars"
                        },
                        new
                        {
                            ShopId = 2,
                            ShopAddress = "37 Applegate Ave, Merrillville, IN 46410",
                            ShopName = "Christine Gontarek, Attorney at Law",
                            ShopType = "Attorney",
                            ShopYelpRating = "4 stars"
                        },
                        new
                        {
                            ShopId = 3,
                            ShopAddress = "9550 Sugar Rd, Phillipsburg, NJ 08865",
                            ShopName = "Wackey's Clown Service",
                            ShopType = "Entertainment",
                            ShopYelpRating = "2 Stars"
                        },
                        new
                        {
                            ShopId = 4,
                            ShopAddress = "80 Wall Ct, Oak Ridge, TN 37830",
                            ShopName = "Clump Book Sellers",
                            ShopType = "Bookstore",
                            ShopYelpRating = "3 Stars"
                        },
                        new
                        {
                            ShopId = 5,
                            ShopAddress = "71 Chestnut Dr, St Albans, NY 11412",
                            ShopName = "Happy George's Meat Shop",
                            ShopType = "Butcher",
                            ShopYelpRating = "5 Stars"
                        },
                        new
                        {
                            ShopId = 6,
                            ShopAddress = "844 W Wild Horse Ct, Everett, MA 02149",
                            ShopName = "Lucy's Firing Range",
                            ShopType = "Firing Range",
                            ShopYelpRating = "3 Stars"
                        },
                        new
                        {
                            ShopId = 7,
                            ShopAddress = "8986 Bear Hill St, Nashville, TN 37205",
                            ShopName = "Deputy Hawk Filling Station",
                            ShopType = "Petrol Station",
                            ShopYelpRating = "5 Stars"
                        },
                        new
                        {
                            ShopId = 8,
                            ShopAddress = "83 Ridgewood Ave, Boca Raton, FL 33428",
                            ShopName = "Laura's Plastics",
                            ShopType = "Bulk Plastic Vendor",
                            ShopYelpRating = "2 Stars"
                        },
                        new
                        {
                            ShopId = 9,
                            ShopAddress = "660 Cooper St, Tullahoma, TN 37388",
                            ShopName = "Andy's Boot Barn",
                            ShopType = "Shoe Store",
                            ShopYelpRating = "1 Star"
                        },
                        new
                        {
                            ShopId = 10,
                            ShopAddress = "736 Birch Hill Ave, Easley, SC 29640",
                            ShopName = "Uncle Joe's Aromas",
                            ShopType = "Perfume Vendor",
                            ShopYelpRating = "1 Star"
                        },
                        new
                        {
                            ShopId = 11,
                            ShopAddress = "9659 Amherst Dr, Ypsilanti, MI 48197",
                            ShopName = "Fast & Fresh Grocery",
                            ShopType = "Grocery Store",
                            ShopYelpRating = "4 Stars"
                        },
                        new
                        {
                            ShopId = 12,
                            ShopAddress = "92 Grant Dr, Myrtle Beach, SC 29577",
                            ShopName = "Jefferson Regional Hospital",
                            ShopType = "Hospital",
                            ShopYelpRating = "3 Stars"
                        },
                        new
                        {
                            ShopId = 13,
                            ShopAddress = "9825 N Jefferson St, Warner Robins, GA 31088",
                            ShopName = "Angry Dave's Fertilizer",
                            ShopType = "Garden Supply Store",
                            ShopYelpRating = "3 Stars"
                        },
                        new
                        {
                            ShopId = 14,
                            ShopAddress = "8571 W Theatre Ln, Pataskala, OH 43062",
                            ShopName = "Westward Contractors",
                            ShopType = "Construction",
                            ShopYelpRating = "1 Star"
                        },
                        new
                        {
                            ShopId = 15,
                            ShopAddress = "635 Glenridge Ave, Mooresville, NC 28115",
                            ShopName = "View Bag Video",
                            ShopType = "Video Rental",
                            ShopYelpRating = "4 Stars"
                        },
                        new
                        {
                            ShopId = 16,
                            ShopAddress = "33 Madison St, Mt Prospect, IL 60056",
                            ShopName = "Lattakia Rug Shop",
                            ShopType = "Rug Store",
                            ShopYelpRating = "5 Stars"
                        },
                        new
                        {
                            ShopId = 17,
                            ShopAddress = "57 W Hilltop Dr, Missoula, MT 59801",
                            ShopName = "Twist & Shout",
                            ShopType = "Record Store",
                            ShopYelpRating = "2 Stars"
                        },
                        new
                        {
                            ShopId = 18,
                            ShopAddress = "278 Boston Dr, Green Cove Spgs, FL 32043",
                            ShopName = "Zimmer's Lookin' Good Shop",
                            ShopType = "Tailor",
                            ShopYelpRating = "5 Stars"
                        },
                        new
                        {
                            ShopId = 19,
                            ShopAddress = "647 Somerset Ln, San Jose, CA 95127",
                            ShopName = "Pig Palace",
                            ShopType = "Farm Supply",
                            ShopYelpRating = "1 Star"
                        },
                        new
                        {
                            ShopId = 20,
                            ShopAddress = "7225 Mayfair Dr, Mankato, MN 56001",
                            ShopName = "Fancy Freight",
                            ShopType = "Shipping Company",
                            ShopYelpRating = "4 Stars"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}