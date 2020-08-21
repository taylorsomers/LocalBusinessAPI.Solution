using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusiness.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RestaurantName = table.Column<string>(nullable: true),
                    RestaurantAddress = table.Column<string>(nullable: true),
                    RestaurantType = table.Column<string>(nullable: true),
                    RestaurantYelpRating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantId);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    ShopId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShopName = table.Column<string>(nullable: true),
                    ShopAddress = table.Column<string>(nullable: true),
                    ShopType = table.Column<string>(nullable: true),
                    ShopYelpRating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.ShopId);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "RestaurantAddress", "RestaurantName", "RestaurantType", "RestaurantYelpRating" },
                values: new object[,]
                {
                    { 1, "8465 Adams Dr, Greer, SC 29650", "Harry's Diner", "American, Diner", "3 Stars" },
                    { 2, "8465 Adams Dr, Greer, SC 29650", "Wacky's Burgers", "Hamburgers", "2 Stars" },
                    { 3, "8465 Adams Dr, Greer, SC 29650", "Terrible Tina's House of Slop", "Cafeteria", "4 Stars" },
                    { 4, "8465 Adams Dr, Greer, SC 29650", "Lattakia Restaurant", "Levantine", "5 Stars" },
                    { 5, "8465 Adams Dr, Greer, SC 29650", "Heisshund Hot Dogs", "Hot Dog Stand", "3 Stars" },
                    { 6, "8465 Adams Dr, Greer, SC 29650", "Tom & Flip's BBQ", "Barbecue", "4 Stars" },
                    { 7, "8465 Adams Dr, Greer, SC 29650", "City of Pigs", "Barbecue", "3 Stars" },
                    { 8, "8465 Adams Dr, Greer, SC 29650", "Kyushu Sushi", "Sushi", "3 Stars" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "ShopAddress", "ShopName", "ShopType", "ShopYelpRating" },
                values: new object[,]
                {
                    { 12, "92 Grant Dr, Myrtle Beach, SC 29577", "Jefferson Regional Hospital", "Hospital", "3 Stars" },
                    { 13, "9825 N Jefferson St, Warner Robins, GA 31088", "Angry Dave's Fertilizer", "Garden Supply Store", "3 Stars" },
                    { 14, "8571 W Theatre Ln, Pataskala, OH 43062", "Westward Contractors", "Construction", "1 Star" },
                    { 18, "278 Boston Dr, Green Cove Spgs, FL 32043", "Zimmer's Lookin' Good Shop", "Tailor", "5 Stars" },
                    { 16, "33 Madison St, Mt Prospect, IL 60056", "Lattakia Rug Shop", "Rug Store", "5 Stars" },
                    { 17, "57 W Hilltop Dr, Missoula, MT 59801", "Twist & Shout", "Record Store", "2 Stars" },
                    { 11, "9659 Amherst Dr, Ypsilanti, MI 48197", "Fast & Fresh Grocery", "Grocery Store", "4 Stars" },
                    { 15, "635 Glenridge Ave, Mooresville, NC 28115", "View Bag Video", "Video Rental", "4 Stars" },
                    { 10, "736 Birch Hill Ave, Easley, SC 29640", "Uncle Joe's Aromas", "Perfume Vendor", "1 Star" },
                    { 6, "844 W Wild Horse Ct, Everett, MA 02149", "Lucy's Firing Range", "Firing Range", "3 Stars" },
                    { 8, "83 Ridgewood Ave, Boca Raton, FL 33428", "Laura's Plastics", "Bulk Plastic Vendor", "2 Stars" },
                    { 7, "8986 Bear Hill St, Nashville, TN 37205", "Deputy Hawk Filling Station", "Petrol Station", "5 Stars" },
                    { 19, "647 Somerset Ln, San Jose, CA 95127", "Pig Palace", "Farm Supply", "1 Star" },
                    { 5, "71 Chestnut Dr, St Albans, NY 11412", "Happy George's Meat Shop", "Butcher", "5 Stars" },
                    { 4, "80 Wall Ct, Oak Ridge, TN 37830", "Clump Book Sellers", "Bookstore", "3 Stars" },
                    { 3, "9550 Sugar Rd, Phillipsburg, NJ 08865", "Wackey's Clown Service", "Entertainment", "2 Stars" },
                    { 2, "37 Applegate Ave, Merrillville, IN 46410", "Christine Gontarek, Attorney at Law", "Attorney", "4 stars" },
                    { 1, "8465 Adams Dr, Greer, SC 29650", "Larry's Laundry", "Laundromat", "3 Stars" },
                    { 9, "660 Cooper St, Tullahoma, TN 37388", "Andy's Boot Barn", "Shoe Store", "1 Star" },
                    { 20, "7225 Mayfair Dr, Mankato, MN 56001", "Fancy Freight", "Shipping Company", "4 Stars" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}
