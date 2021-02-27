﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YallaNakol.Data.Models;

namespace YallaNakol.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CategoryRestaurant", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "RestaurantsId");

                    b.HasIndex("RestaurantsId");

                    b.ToTable("CategoryRestaurant");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("YallaNakol.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("YallaNakol.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A hamburger (also burger for short) is a sandwich consisting of one or more cooked patties of ground meat, usually beef, placed inside a sliced bread roll or bun. The patty may be pan fried, grilled, smoked or flame broiled. Hamburgers are often served with cheese, lettuce, tomato, onion, pickles, bacon, or chiles; condiments such as ketchup, mustard, mayonnaise, relish, or a special sauce, often a variation of Thousand Island dressing; and are frequently placed on sesame seed buns. A hamburger topped with cheese is called a cheeseburger",
                            Name = "Burger"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Local egyptian food.",
                            Name = "Egyptian"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Grilled food.",
                            Name = "Grill"
                        });
                });

            modelBuilder.Entity("YallaNakol.Data.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MenuId");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Juicy beef patty smothered in three extraordinary slices of Emmental cheese and topped with sliced tomato, shredded lettuce, onions and that special Big Tasty sauce",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/a660c55e-d9ea-4c0d-be33-4d0cc5d0a7b4.jpg",
                            InStock = true,
                            MenuId = 1,
                            Name = "Big Tasty",
                            Price = 100m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Two beef patties, that unbeatably tasty Big Mac sauce, melting signature cheese, crisp shredded lettuce, onions, pickles and a bun in the middle all between a toasted sesame seed bun",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/298f37b4-f9f7-44ea-a297-02cda66bd50b.jpg",
                            InStock = true,
                            MenuId = 1,
                            Name = "Big Mac",
                            Price = 60m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Two Juicy beef patty smothered in three extraordinary slices of Emmental cheese and topped with sliced tomato, shredded lettuce, onions and that special Big Tasty sauce",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/b7d655fd-9cee-4a79-89f7-8a4b6a28ab00.jpg",
                            InStock = true,
                            MenuId = 1,
                            Name = "Double Big Tasty",
                            Price = 110m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "A delicious combination of breaded chicken patties, crisp lettuce, melting cheese, onions, pickles, and our special sauce, all framed between a toasted sesame seed bun",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Thumbnail/0e13cb43-dacb-4788-8c7d-2c0ab72c23e9.jpg",
                            InStock = true,
                            MenuId = 1,
                            Name = "Chicken Mac",
                            Price = 90m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Koshary small plate.",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/6bfdcfce-b4ac-4b06-b448-1414c049b5fa.jpg",
                            InStock = true,
                            MenuId = 2,
                            Name = "Small Box",
                            Price = 10m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Koshary big plate.",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/3366aab0-fb50-4cbe-b662-af6febc7f25d.jpg",
                            InStock = true,
                            MenuId = 2,
                            Name = "Big Star",
                            Price = 20m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "1/2 Grilled Chicken with Tehina and bread and additional rice with great taste.",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/d065bb8d-0d10-4d1d-abe3-ab94527d148a.jpg",
                            InStock = true,
                            MenuId = 3,
                            Name = "1/2 Grilled Chicken with Tehina",
                            Price = 48m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "1/4 Kilo Kofta on grill with tehina and bread.",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/7506c276-a4ae-401e-9d06-4d213fb301b0.jpg",
                            InStock = true,
                            MenuId = 3,
                            Name = "1/4 Kilo Kofta",
                            Price = 67m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "Beef bacon with fresh sauteed mushroom, cheddar cheese and creamy mayonnaise on top of our flamed burger patty 150 gm",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/b1e14590-9b6c-4249-a842-d9d9729f4999.jpg",
                            InStock = true,
                            MenuId = 4,
                            Name = "Bacon Mushroom Jack",
                            Price = 66m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            Description = "Grilled burger topped with sweet onion, BBQ sauce, creamy Charbroiled sauce and Swiss cheese 150gm.",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/3c323965-7cad-49bf-a27f-51faa70313e2.jpg",
                            InStock = true,
                            MenuId = 4,
                            Name = "Charbroiled BBQ",
                            Price = 53m
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            Description = "2 mozzarella sticks on 150 gm and 3 pieces on 200 and 400 gm beef patties, loaded with original ketchup, mustard drops, beef bacon, cheddar cheese and our creamy Buffalo sauce, all on top of our clean cut beef patty",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/cf499e68-56eb-4fd7-a663-a76d9be2d6ef.jpg",
                            InStock = true,
                            MenuId = 4,
                            Name = "Hitchhiker",
                            Price = 66m
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "A new Sandwich introduced from macdonalds from our chefs with our great sauses",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/298f37b4-f9f7-44ea-a297-02cda66bd50b.jpg",
                            InStock = true,
                            MenuId = 1,
                            Name = "Chicked Grilled New Sandwich",
                            Price = 100m
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "A new Sandwich introduced from macdonalds from our chefs with our great sauses",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/298f37b4-f9f7-44ea-a297-02cda66bd50b.jpg",
                            InStock = true,
                            MenuId = 1,
                            Name = "Chicked Grilled New Sandwich",
                            Price = 100m
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Description = "Juicy beef patty smothered in three extraordinary slices of Emmental cheese and topped with sliced tomato, shredded lettuce, onions and that special Big Tasty sauce",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/a660c55e-d9ea-4c0d-be33-4d0cc5d0a7b4.jpg",
                            InStock = true,
                            MenuId = 1,
                            Name = "Big Tasty",
                            Price = 100m
                        });
                });

            modelBuilder.Entity("YallaNakol.Data.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int?>("DishOfTheWeekId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DishOfTheWeekId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DishId = 0
                        },
                        new
                        {
                            Id = 2,
                            DishId = 0
                        },
                        new
                        {
                            Id = 3,
                            DishId = 0
                        },
                        new
                        {
                            Id = 4,
                            DishId = 0
                        });
                });

            modelBuilder.Entity("YallaNakol.Data.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("City")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrackingID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("YallaNakol.Data.Models.Order+OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("DishId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrdersDetails");
                });

            modelBuilder.Entity("YallaNakol.Data.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeliveryAreas")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkingHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "39 Abbas El Akkad StreetAbbas El Akkad Nasr City",
                            DeliveryAreas = 22,
                            Description = "McDonald's Corporation is an American fast food company, founded in 1940 as a restaurant operated by Richard and Maurice McDonald, in San Bernardino, California, United States. They rechristened their business as a hamburger stand, and later turned the company into a franchise, with the Golden Arches logo being introduced in 1953 at a location in Phoenix, Arizona. In 1955, Ray Kroc, a businessman, joined the company as a franchise agent and proceeded to purchase the chain from the McDonald brothers. McDonald's had its previous headquarters in Oak Brook, Illinois, but moved its global headquarters to Chicago in June 2018",
                            ImageUrl = "https://www.nrn.com/sites/nrn.com/files/styles/article_featured_standard/public/mcdonalds-logo.gif?itok=U_TliriA",
                            MenuId = 1,
                            Name = "McDonalds",
                            PhoneNumber = "19991",
                            Rate = "4.5",
                            WorkingHours = "From 11:00 AM To 02:15 AM"
                        },
                        new
                        {
                            Id = 2,
                            Address = "19 Shabab El Mohandessin Blgs., Extension of Makram Ebeid Makram Ebeid, Nasr City",
                            DeliveryAreas = 4,
                            Description = "Sayed Hanafy restaurants chain is one of the most renowed authentic restaurant chain in Egypt. Started at 1952 from a koshary cart, until the first branch was established in 1985.",
                            ImageUrl = "https://scontent.fcai3-1.fna.fbcdn.net/v/t1.0-9/80390516_2962955900382554_7936731969642037248_o.jpg?_nc_cat=108&ccb=3&_nc_sid=09cbfe&_nc_eui2=AeFXUmEyrlQcE9kS0CRed1hSadTxKq-e0Mxp1PEqr57QzORy-uTd2-XxCfuIsbKZWCw&_nc_ohc=GDzNSruJTnYAX-4LMAT&_nc_ht=scontent.fcai3-1.fna&oh=b0869207a61c893aea55de10a887bcac&oe=605F788F",
                            MenuId = 2,
                            Name = "Koshary Sayed Hanafy",
                            PhoneNumber = "16920",
                            Rate = "4.6",
                            WorkingHours = "From 09:00 AM To 01:00 AM"
                        },
                        new
                        {
                            Id = 3,
                            Address = "84 Hassan Ma'moon in front of Al Ahly Club Al-Ahly Club, Nasr City",
                            DeliveryAreas = 4,
                            Description = "History told of El-Dahan's success since 1890. It was first was named 'El-Akr' & was known for its Eastern cuisine & barbequed meat. Now we have opened new branches in the 5th Settlement, Rehab City & in Merghany. We hope to continue our success through your support & confidence. \"Combine tradition & originality\".",
                            ImageUrl = "https://s3-eu-west-1.amazonaws.com/elmenusv5-stg/Normal/79262228-7ae9-48a0-8dd1-2db9f18d3ff0.jpg",
                            MenuId = 3,
                            Name = "ElDahan",
                            PhoneNumber = "16194",
                            Rate = "4.5",
                            WorkingHours = "From 09:00 AM To 12:30 AM"
                        },
                        new
                        {
                            Id = 4,
                            Address = "27 El Batrawy St. Off Abbas El Akkad St. Abbas El Akkad, Nasr City",
                            DeliveryAreas = 4,
                            Description = "It all started with four passionate brothers who shared one big appetite, an obsession with juicy burgers and a demanding palate. They focused their energy on challenging the conventional idea that food served fast must be a junk experience and instead worked on refining it to become an elevated culinary adventure where ingredients are naturally",
                            ImageUrl = "https://scontent.fcai3-1.fna.fbcdn.net/v/t1.0-9/110249313_10158045681834681_5826574394868309860_o.jpg?_nc_cat=1&ccb=3&_nc_sid=09cbfe&_nc_eui2=AeGKS-9i1ns8Ux0u1h6Sh5m44DX-FVvfQFXgNf4VW99AVcpR7In_bHJ8DAoSvYZgjWg&_nc_ohc=86qMH8TqTvkAX-YWQ97&_nc_ht=scontent.fcai3-1.fna&oh=5239a5e67c94134451274c0d8bab0f7b&oe=60619A20",
                            MenuId = 4,
                            Name = "Buffalo Burger",
                            PhoneNumber = "19914",
                            Rate = "4.6",
                            WorkingHours = "From 11:00 AM To 02:45 AM"
                        });
                });

            modelBuilder.Entity("YallaNakol.Data.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.ToTable("ShoppingCartItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 3,
                            DishId = 1,
                            ShoppingCartId = "30377b50-77fc-4e43-81d0-bbdc0e188ccb"
                        });
                });

            modelBuilder.Entity("CategoryRestaurant", b =>
                {
                    b.HasOne("YallaNakol.Data.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YallaNakol.Data.Models.Restaurant", null)
                        .WithMany()
                        .HasForeignKey("RestaurantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("YallaNakol.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("YallaNakol.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YallaNakol.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("YallaNakol.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YallaNakol.Data.Models.Dish", b =>
                {
                    b.HasOne("YallaNakol.Data.Models.Category", "Category")
                        .WithMany("Dishes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YallaNakol.Data.Models.Menu", null)
                        .WithMany("Dishes")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("YallaNakol.Data.Models.Menu", b =>
                {
                    b.HasOne("YallaNakol.Data.Models.Dish", "DishOfTheWeek")
                        .WithMany()
                        .HasForeignKey("DishOfTheWeekId");

                    b.Navigation("DishOfTheWeek");
                });

            modelBuilder.Entity("YallaNakol.Data.Models.Order+OrderDetail", b =>
                {
                    b.HasOne("YallaNakol.Data.Models.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YallaNakol.Data.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("YallaNakol.Data.Models.Restaurant", b =>
                {
                    b.HasOne("YallaNakol.Data.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("YallaNakol.Data.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("YallaNakol.Data.Models.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");
                });

            modelBuilder.Entity("YallaNakol.Data.Models.Category", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("YallaNakol.Data.Models.Menu", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("YallaNakol.Data.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
