using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportStoreSD7.Models
{
    public static class SeedData
    {                                                     //Also see Startup.cs Line 112 for creating service.
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            //context.Database.Migrate();         //This line was throwing an exception that Products was already called. 
                                                    //Page 217 still including this line.
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Kayak",
                    Description = "A boat for one person",
                    Category = "Watersports",
                    Price = 275
                },
                new Product
                {
                    Name = "Lifejacket",
                    Description = "Protective and fashionable",
                    Category = "Watersports",
                    Price = 48.95m
                },
                new Product
                {
                    Name = "Soccer Ball",
                    Description = "FIFA-approved size and weight",
                    Category = "Soccer",
                    Price = 19.50m
                },
                new Product
                {
                    Name = "Corner Flags",
                    Description = "Give your playing field a professional touch",
                    Category = "Soccer",
                    Price = 34.95m
                },
                new Product
                {
                    Name = "Stadium",
                    Description = "Flat-packed 35,000-seat stadium",
                    Category = "Soccer",
                    Price = 79500
                },
                new Product
                {
                    Name = "Thinking Cap",
                    Description = "Improve brain efficiency by 75%",
                    Category = "Chess",
                    Price = 16
                },
                new Product
                {
                    Name = "Unsteady Chair",
                    Description = "Secretly give your opponent a disadvantage",
                    Category = "Chess",
                    Price = 29.95m
                },
                new Product
                {
                    Name = "Human Chess Board",
                    Description = "A fun game for the family",
                    Category = "Chess",
                    Price = 75
                },
                new Product
                {
                    Name = "Bling-Bling King",
                    Description = "Gold-plated, diamond-studded King",
                    Category = "Chess",
                    Price = 1200
                },
                new Product { Name = " Kayak ", Description = " A boat for one person maybe two ", Category = " Watersports ", Price = 250m },
new Product { Name = " Lifejacket ", Description = " Protective and fashionable ", Category = " Watersports ", Price = 48.95m },
new Product { Name = " Soccer Ball ", Description = " FIFA-approved size and weight ", Category = " Soccer ", Price = 19.52m },
new Product { Name = " Corner Flags ", Description = " Give your playing field a professional touch ", Category = " Soccer ", Price = 34.97m },
new Product { Name = " Stadium ", Description = " Flat-packed 35 ", Category = "  ", Price = 79500.01m },
new Product { Name = " Thinking Cap ", Description = " Improve brain efficiency by 75% ", Category = " Misc. ", Price = 16m },
new Product { Name = " Unsteady Chair ", Description = " Secretly give your opponent a disadvantage ", Category = " Misc. ", Price = 29.95m },
new Product { Name = " Human Chess Board ", Description = " A fun game for the family ", Category = " Misc. ", Price = 75m },
new Product { Name = " Bling-Bling King ", Description = " Gold-plated ", Category = "  ", Price = 1200m },
new Product { Name = " Sailing Gloves ", Description = " Save your hands ", Category = " Watersports ", Price = 35m },
new Product { Name = " Sunglasses ", Description = " Oakley Polarized Black Half Jacket ", Category = " Outdoor ", Price = 180.75m },
new Product { Name = " Coffee ", Description = " haha this is yummy ", Category = " Misc. ", Price = 3.5m },
new Product { Name = " Ultimate Frisbee ", Description = " Officially used in the AUDL ", Category = " Outdoor ", Price = 12.95m },
new Product { Name = " Crayons ", Description = " Marine Food ", Category = " Misc. ", Price = 10m },
new Product { Name = " MVC ", Description = " Broken AND Infuriating! ", Category = " Misc. ", Price = 10000m },
new Product { Name = " Mouthguard ", Description = " Protects your teeth ", Category = " Football ", Price = 15m },
new Product { Name = " Cleats ", Description = " Better traction = MOAR SPEED! ", Category = " Football ", Price = 95m },
new Product { Name = " Football Pants ", Description = " Holds your various leg pads and makes you look stylish! ", Category = " Football ", Price = 60m },
new Product { Name = " Hip Pads ", Description = " Protects your Hips! ", Category = " Football ", Price = 30m },
new Product { Name = " Thigh Pads ", Description = " Protects your Thighs! ", Category = " Football ", Price = 35m },
new Product { Name = " Knee Pads ", Description = " Protects your Knees! ", Category = " Football ", Price = 20m },
new Product { Name = " Tailbone Pad ", Description = " Protects your Tailbone! ", Category = " Football ", Price = 10m },
new Product { Name = " Shoulder Pads ", Description = " Protects your Shoulders! ", Category = " Football ", Price = 200m },
new Product { Name = " Helmet ", Description = " Protects your Noggin! ", Category = " Football ", Price = 150m },
new Product { Name = " Gloves ", Description = " Like wearing Stickum on your hands! ", Category = " Football ", Price = 47m },
new Product { Name = " Eye Black ", Description = " makes you look fierce! ", Category = " Football ", Price = 10m },
new Product { Name = " Gatorade ", Description = " Because water sucks! ", Category = " Football ", Price = 3m },
new Product { Name = " Kangaroo ", Description = " Wait ", Category = "  ", Price = 14681m },
new Product { Name = " Tesla Cybertruck ", Description = " Lithium mining is worse for the environment than gas fumes ", Category = "  ", Price = 45000m },
new Product { Name = " Water Ski ", Description = " It ", Category = " WaterSports ", Price = 1500.99m },
new Product { Name = " Ice Skates ", Description = " Blades of Glory ", Category = " Outdoor ", Price = 29.99m },
new Product { Name = " Hockey Stick ", Description = " Stick of Hockey ", Category = " Outdoor ", Price = 14.99m },
new Product { Name = " Checkers ", Description = " A standard game of checkers ", Category = " Misc. ", Price = 20m },
new Product { Name = " Boogie Board ", Description = " Board you can boogie on ", Category = " WaterSports ", Price = 99.99m },
new Product { Name = " Ring of Silencing ", Description = " Item made for Jonesy ", Category = " Misc. ", Price = 9999.99m },
new Product { Name = " Kamehameha ", Description = " Master Roshi ", Category = " Misc. ", Price = 5000.99m },
new Product { Name = " Key Blade ", Description = " Sora ", Category = " Misc. ", Price = 499.99m },
new Product { Name = " Purple Lightsaber ", Description = " Mace Windu ", Category = " Misc. ", Price = 4000.99m },
new Product { Name = " Darth Vader ", Description = " Blocks 99.99% Of Covid-19! ", Category = " Misc. ", Price = 9999.99m },
new Product { Name = " California Land ", Description = " 1 sq ft (Remember ", Category = " Misc. ", Price = 45000m },
new Product { Name = " Basketball ", Description = " A round ball for multiplayer games ", Category = " Gym ", Price = 20m },
new Product { Name = " Texas Land ", Description = " 1 sq ft (Remember ", Category = " Misc. ", Price = 0.45m },
new Product { Name = " Vermillion Rockfish ", Description = " Careful! Do not get stung! ", Category = " Misc. ", Price = 45m },
new Product { Name = " Lenovo Laptop ", Description = " Intel (R) Core (TM) CPU @ 1.6 GHz ", Category = " Misc. ", Price = 600m },
new Product { Name = " Basketball ", Description = " A Basketball ", Category = " Gym ", Price = 50m },
new Product { Name = " Baseball Bat ", Description = " A Baseball bat ", Category = " Outdoor ", Price = 25m },
new Product { Name = " Skatebord ", Description = " A Skatebord ", Category = " Outdoor ", Price = 60m },
new Product { Name = " Hoola Hoop ", Description = " A Hoola Hoop ", Category = " Outdoor ", Price = 20m },
new Product { Name = " Football ", Description = " A Football ", Category = " Outdoor ", Price = 30m },
new Product { Name = " Tennis Ball ", Description = " A Tennis Ball ", Category = " Outdoor ", Price = 15m },
new Product { Name = " Football Helmet ", Description = " A Football Helmet ", Category = " Outdoor ", Price = 70m },
new Product { Name = " Knee Pads ", Description = " A Knee Pads ", Category = " Outdoor ", Price = 45m },
new Product { Name = " Logitech Mouse ", Description = " Optical mouse with red dot ", Category = " Misc. ", Price = 20m },
new Product { Name = " Golf Ball ", Description = " a ball for golfing ", Category = " Outdoor ", Price = 5.99m },
new Product { Name = " BaseBall Glove ", Description = " Genuine Leather ", Category = " Baseball ", Price = 22.95m },
new Product { Name = " Cleats ", Description = " Plastic Studs - Low ankle supprt ", Category = " Outdoor ", Price = 34.99m },
new Product { Name = " Signed Baseball ", Description = " Signed by Dodgers Pitcher Clayton Kershaw ", Category = " Baseball ", Price = 149.95m },
new Product { Name = " Instant Net ", Description = " Pitching Net for Pitching Practice ", Category = " Baseball ", Price = 24.95m },
new Product { Name = " Folding Stool ", Description = " Portable Tripod Stool for laziness ", Category = " Outdoor ", Price = 7.94m },
new Product { Name = " Basketball ", Description = " A Basketball ", Category = " Gym ", Price = 50m },
new Product { Name = " Baseball Bat ", Description = " A Baseball bat ", Category = " Outdoor ", Price = 25m },
new Product { Name = " Skatebord ", Description = " A Skatebord ", Category = " Outdoor ", Price = 60m },
new Product { Name = " Hoola Hoop ", Description = " A Hoola Hoop ", Category = " Outdoor ", Price = 20m },
new Product { Name = " Football ", Description = " A Football ", Category = " Outdoor ", Price = 30m },
new Product { Name = " Tennis Ball ", Description = " A Tennis Ball ", Category = " Outdoor ", Price = 15m },
new Product { Name = " Football Helmet ", Description = " A Football Helmet ", Category = " Outdoor ", Price = 70m },
new Product { Name = " Knee Pads ", Description = " A Knee Pads ", Category = " Outdoor ", Price = 45m },
new Product { Name = " Corvette C8 ", Description = " I wish i could afford this. ", Category = " Outdoor ", Price = 58000m },
new Product { Name = " Motrin ", Description = " Corpsmans best friend. Price per 200 mg. ", Category = " Misc. ", Price = 0.5m },
new Product { Name = " RTX 3080ti ", Description = " Graphics Card ", Category = " Misc. ", Price = 1200m },
new Product { Name = " Gundum Figure ", Description = " A build your own gundum ", Category = " Misc. ", Price = 30m },
new Product { Name = " Samurai Sword ", Description = " Sharp pointy object ", Category = " Misc. ", Price = 500m },
new Product { Name = " HTC Vive ", Description = " HTC Virtual Reality Headset ", Category = " Misc. ", Price = 800m },
new Product { Name = " HTC Vive Pro ", Description = " Pro HTC Virtual Reality Headset ", Category = " Misc. ", Price = 1200m },
new Product { Name = " Valve Index ", Description = " Valve VR Headset ", Category = " Misc. ", Price = 1200m },
new Product { Name = " 10k 500hz G-Sync Monitor ", Description = " Computer Monitor ", Category = " Misc. ", Price = 1200m },
new Product { Name = " Portable 27 inch Monitor ", Description = " Computer Monitor ", Category = " Misc. ", Price = 300m },
new Product { Name = " Silence ", Description = " Sweet Sweet silence ", Category = " Misc. ", Price = 1m },
new Product { Name = " Webcam ", Description = " A portable camera for your computer ", Category = " Misc. ", Price = 100m },
new Product { Name = " NVIDIA Quadro RTX 8000  ", Description = " Professional Graphics Card ", Category = " Misc. ", Price = 5500m },
new Product { Name = " Desk Lamp ", Description = " Black with stainless steel rod ", Category = " Misc. ", Price = 18m },
new Product { Name = " Bag Of Holding ", Description = " The best backpack you never had ", Category = " Outdoor ", Price = 1000m },
new Product { Name = " Bowl ", Description = " 6 pcs set balck ceramic ", Category = " Misc. ", Price = 14m },
new Product { Name = " Basketball ", Description = " A Basketball ", Category = " Gym ", Price = 50m },
new Product { Name = " Baseball Bat ", Description = " A Baseball bat ", Category = " Baseball ", Price = 25m },
new Product { Name = " Skatebord ", Description = " A Skatebord ", Category = " Outdoor ", Price = 60m },
new Product { Name = " Hoola Hoop ", Description = " A Hoola Hoop ", Category = " Misc. ", Price = 20m },
new Product { Name = " Football ", Description = " A Football ", Category = " Football ", Price = 30m },
new Product { Name = " Tennis Ball ", Description = " A Tennis Ball ", Category = " Outdoor ", Price = 15m },
new Product { Name = " Football Helmet ", Description = " A Football Helmet ", Category = " Football ", Price = 70m },
new Product { Name = " Knee Pads ", Description = " A Knee Pads ", Category = " Outdoor ", Price = 45m },
new Product { Name = " Corvette C8 ", Description = " I wish i could afford this. ", Category = " Misc. ", Price = 58000m },
new Product { Name = " Nueral Link ", Description = " Download how to us MVC in seconds! ", Category = " Misc. ", Price = 999.99m },
new Product { Name = " Xbox One ", Description = " Video Game Console ", Category = " Misc. ", Price = 300m },
new Product { Name = " Headphones ", Description = " Cancels out noisy kids ", Category = " Misc. ", Price = 160m },
new Product { Name = " Mike Trout Baseball ", Description = " Signed by the goat ", Category = " Baseball ", Price = 1232.4m },
new Product { Name = " Diet Dr. Pepper ", Description = " Needed to survive ", Category = " Misc. ", Price = 4.5m },
new Product { Name = " Lawnchair ", Description = " Soak in the sun ", Category = " Outdoor ", Price = 25.45m },
new Product { Name = " Sandals ", Description = " Must have in Cali ", Category = " Misc. ", Price = 22m },
new Product { Name = " TV ", Description = " What is going on with Covid 19? ", Category = " Misc. ", Price = 1243.55m },
new Product { Name = " Trampoline ", Description = " Keep the kids entertained ", Category = " Outdoor ", Price = 209m },
new Product { Name = " Honda Odyssey ", Description = " Gray ", Category = " Misc. ", Price = 40000m },
new Product { Name = " 1984 Lada Samara v4 ", Description = " PREMIUM Soviet automobile comrades! Much better than capitalist swill ", Category = " Misc. ", Price = 15.5m },
new Product { Name = " Futboll ", Description = " A boll for your fut ", Category = " Football ", Price = 99.95m },
new Product { Name = " HeadPad ", Description = " Pad for head ", Category = " Football ", Price = 1.95m },
new Product { Name = " Left Pinky Pad ", Description = " Pad for left pinky ", Category = " Football ", Price = 79.95m },
new Product { Name = " Right Knee Pit Pad ", Description = " Pad for right knee pit ", Category = " Football ", Price = 9.95m },
new Product { Name = " Earmuffins ", Description = " Muffins to make your ears warm ", Category = " Outdoor ", Price = 19.95m },
new Product { Name = " Heelies ", Description = " Be the coolest kid around ", Category = " Outdoor ", Price = 49.95m },
new Product { Name = " Towel ", Description = " Towel ", Category = " Misc. ", Price = 9.95m },
new Product { Name = " Potato Mouth Gaurd ", Description = " Protect your mouth with this potato ", Category = " Football ", Price = 9.95m },
new Product { Name = " Wrist warmer ", Description = " Wrists need love too ", Category = " Misc. ", Price = 9.95m },
new Product { Name = " Hand ", Description = " Hand ", Category = " Outdoor ", Price = 99.95m },
new Product { Name = " Nissa Pathfinder ", Description = " Maroon ", Category = " Misc. ", Price = 30000m },
new Product { Name = " Boot ", Description = " A boot for running ", Category = " Outdoor ", Price = 50.99m },
new Product { Name = " Frizbee ", Description = " A disk for throwing ", Category = " Outdoor ", Price = 10m },
new Product { Name = " RollerBlades ", Description = " For skating on pavement ", Category = " Outdoor ", Price = 30.99m },
new Product { Name = " SpeedBag ", Description = " A bag for punching really fast ", Category = " Gym ", Price = 5.99m },
new Product { Name = " Barbell ", Description = " A pole for putting weights ", Category = " Gym ", Price = 50.99m },
new Product { Name = " Pants ", Description = " For wearing ", Category = " Misc. ", Price = 5.99m },
new Product { Name = " Helmet ", Description = " for safety ", Category = " Outdoor ", Price = 5.99m },
new Product { Name = " Volley Ball ", Description = " A Ball for Voley Ball ", Category = " Volleyball ", Price = 20m },
new Product { Name = " Baseball ", Description = " A Ball for Base-Ball ", Category = " Baseball ", Price = 10m },
new Product { Name = " Base Ball Glove ", Description = " To catch the base ball ", Category = " Baseball ", Price = 25m },
new Product { Name = " Six foot Soccer Ball ", Description = " To play ultamate soccer ", Category = " Soccer ", Price = 70.95m },
new Product { Name = " Martial Arts Gi ", Description = " Outfit for Martial Arts ", Category = " Gym ", Price = 45m },
new Product { Name = " Hammock ", Description = " Used to relax after playing sports ", Category = " Outdoor ", Price = 35m },
new Product { Name = " Basket Ball Net ", Description = " Self Explanitory ", Category = " Gym ", Price = 15m },
new Product { Name = " Goggles ", Description = " Protection for seeing underwater ", Category = " Watersports ", Price = 25m },
new Product { Name = " Swim Cap ", Description = " Latex/Silicon Cap to cover hair ", Category = " Watersports ", Price = 10m },
new Product { Name = " Baseball glove ", Description = " Glove for catching baseballs ", Category = " Baseball ", Price = 25m },
new Product { Name = " Golf club set ", Description = " Standard set of clubs for playing golf ", Category = " Outdoor ", Price = 100m },
new Product { Name = " Steelseries Arctis 5 ", Description = " Comfortable headset for prolonged gaming/communicaiton ", Category = " Misc. ", Price = 125m },
new Product { Name = " Razor Naga Mouse ", Description = " Gaming mouse with 14 programmable keys ", Category = " Misc. ", Price = 80m },
new Product { Name = " Steelseries Apex 5 ", Description = " Gaming Keyboard - RGB ", Category = " Misc. ", Price = 99.99m },
new Product { Name = " Steeleries Arctis Pro ", Description = " Wired/Bluetooth Headset ", Category = " Misc. ", Price = 135m },
new Product { Name = " Razer Huntsman Keyboard ", Description = " RGB Keyboard w/ optical switches ", Category = " Misc. ", Price = 100m },
new Product { Name = " Razer Hammerhead Earbuds ", Description = " Water resistant ", Category = " Misc. ", Price = 100m },
new Product { Name = " Blades Of Glory ", Description = " For ice skating ", Category = " Outdoor ", Price = 100m },
new Product { Name = " Watergun ", Description = " For shooting water ", Category = " Outdoor ", Price = 5.99m },
new Product { Name = " Honda Accord ", Description = " Blue ", Category = " Misc. ", Price = 25000m },
new Product { Name = " Software Developer ", Description = " 16 Reliable SD ", Category = " Misc. ", Price = 120000m },
new Product { Name = " Shoes ", Description = " Martial Arts Mat Shoes ", Category = " Gym ", Price = 32m },
new Product { Name = " Shoes ", Description = " High-Top Basket-ball shoes ", Category = " Gym ", Price = 32m },
new Product { Name = " Shoes ", Description = " Kleets ", Category = " Soccer ", Price = 40m },
new Product { Name = " Toyota Supra ", Description = " Yellow ", Category = " Misc. ", Price = 45000m },
new Product { Name = " Nissan Type R ", Description = " Black two tone red ", Category = " Misc. ", Price = 60000m },
new Product { Name = "  Softball ", Description = " density ", Category = " Baseball ", Price = 4.5m },
new Product { Name = "  Bat  ", Description = " High Density  ", Category = " Baseball ", Price = 104.5m },
new Product { Name = "  Softball 4 ", Description = " medium density ", Category = " Baseball ", Price = 80.5m },
new Product { Name = "  Softball 3 ", Description = " Low density ", Category = " Baseball ", Price = 40.5m },
new Product { Name = "  Slipper ", Description = " footwear ", Category = " Baseball ", Price = 54.5m },
new Product { Name = "  Glove ", Description = " Wool Glove ", Category = " Baseball ", Price = 64.5m },
new Product { Name = "  CAP ", Description = " New york yankees ", Category = " Baseball ", Price = 74.5m },
new Product { Name = "  Bat ", Description = " Championship ", Category = " Baseball ", Price = 4.5m },
new Product { Name = " VODKA ", Description = " PREMIUM Soviet beverage comrades! Cyka ", Category = " Misc. ", Price = 15.5m },
new Product { Name = " Not Checkers ", Description = " This should not belong in the checkers category....but it does ", Category = " Misc. ", Price = 20.01m },
new Product { Name = " Tiger King Mullet ", Description = " Carol Baskin cant take this away ", Category = " Misc. ", Price = 15.5m },
new Product { Name = " Dongers ", Description = " ? ? ?° ? ? ? ?° ?? ", Category = " Outdoor ", Price = 14.99m },
new Product { Name = " Mark Zuckerberg ", Description = " NOT A ROBOT ", Category = " Misc. ", Price = 14.99m },
new Product { Name = " Futboll ", Description = " A boll for your fut ", Category = " Football ", Price = 99.95m },
new Product { Name = " HeadPad ", Description = " Pad for head ", Category = " Football ", Price = 1.95m },
new Product { Name = " Left Pinky Pad ", Description = " Pad for left pinky ", Category = " Football ", Price = 79.95m },
new Product { Name = " Right Knee Pit Pad ", Description = " Pad for right knee pit ", Category = " Football ", Price = 9.95m },
new Product { Name = " Earmuffins ", Description = " Muffins to make your ears warm ", Category = " Lifestyle ", Price = 19.95m },
new Product { Name = " Heelies ", Description = " Be the coolest kid around ", Category = " Lifestyle ", Price = 49.95m },
new Product { Name = " Towel ", Description = " Towel ", Category = " Hardware ", Price = 9.95m },
new Product { Name = " Potato Mouth Gaurd ", Description = " Protect your mouth with this potato ", Category = " Football ", Price = 9.95m },
new Product { Name = " Wrist warmer ", Description = " Wrists need love too ", Category = " Gaming ", Price = 9.95m },
new Product { Name = " Hand ", Description = " Hand ", Category = " Lifestyle ", Price = 99.95m },
new Product { Name = " Face Masks ", Description = " To protect yourself and others from sickness ", Category = " Protective ", Price = 1.99m },
new Product { Name = " Random Superpower ", Description = " A random superpower! ", Category = " Misc. ", Price = 999999999.99m },
new Product { Name = " Snorkel ", Description = " Breathing tube used for snorkeling. ", Category = " Beach ", Price = 25m },
new Product { Name = " Running Shoes ", Description = " Soft cushion soles for running. ", Category = " Shoes ", Price = 95m }

                );
                context.SaveChanges();
            }
        }
    }
}
