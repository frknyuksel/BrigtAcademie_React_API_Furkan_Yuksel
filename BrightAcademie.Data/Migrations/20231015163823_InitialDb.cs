using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BrightAcademie.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Education = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: false),
                    Adress = table.Column<string>(type: "TEXT", nullable: false),
                    About = table.Column<string>(type: "TEXT", nullable: false),
                    Information = table.Column<string>(type: "TEXT", nullable: false),
                    Questions = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    BirthOfYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Education = table.Column<string>(type: "TEXT", nullable: false),
                    Experience = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    About = table.Column<string>(type: "TEXT", nullable: false),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Field = table.Column<string>(type: "TEXT", nullable: false),
                    Evaluation = table.Column<decimal>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Education = table.Column<string>(type: "TEXT", nullable: true),
                    Experience = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    About = table.Column<string>(type: "TEXT", nullable: true),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Field = table.Column<string>(type: "TEXT", nullable: true),
                    Evaluation = table.Column<decimal>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    TotalTime = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Start = table.Column<DateTime>(type: "TEXT", nullable: false),
                    End = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CourseLevel = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    Earnings = table.Column<string>(type: "TEXT", nullable: false),
                    Statues = table.Column<string>(type: "TEXT", nullable: false),
                    Evaluation = table.Column<decimal>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    TrainerId = table.Column<int>(type: "INTEGER", nullable: true),
                    TraineeId = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_AspNetUsers_TraineeId",
                        column: x => x.TraineeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    OrderStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CoursesCategories",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesCategories", x => new { x.CourseId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CoursesCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesCategories_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseTrainees",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    TraineeId = table.Column<int>(type: "INTEGER", nullable: false),
                    TraineeId1 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTrainees", x => new { x.CourseId, x.TraineeId });
                    table.ForeignKey(
                        name: "FK_CourseTrainees_AspNetUsers_TraineeId1",
                        column: x => x.TraineeId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CourseTrainees_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    CartId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "640724d1-fe65-408f-810d-21485287b195", null, "Eğitilenlerin rolü bu.", "Role", "Trainee", "TRAINEE" },
                    { "90a73e04-bec7-4dbd-9e98-eca47f8083cb", null, "Yöneticilerin rolü bu.", "Role", "Admin", "ADMIN" },
                    { "b26b6caa-1393-4cd6-a546-d57e235adf32", null, "Yöneticilerin rolü bu.", "Role", "SuperAdmin", "SUPERADMIN" },
                    { "b27c1efa-7aa9-447e-90e2-99619ced57e0", null, "Diğer tüm kullanıcıların rolü bu.", "Role", "User", "USER" },
                    { "c806df79-bc2a-4202-b69f-a2d009ca115a", null, "Eğitmenlerin rolü bu.", "Role", "Trainer", "TRAINER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "CreatedDate", "DateOfBirth", "Education", "Email", "EmailConfirmed", "FirstName", "Gender", "IsActive", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoUrl", "SecurityStamp", "TwoFactorEnabled", "Url", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, null, "940527e8-b414-4f01-9bbb-71d08791028f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ".NET (.NET Core, MVC, Web API)", null, false, "Onur", null, false, false, "Ustaoğlu", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "c777c7de-2f20-4be6-a216-47340f9ccbda", false, "onur-ustaoglu", null },
                    { "2", 0, null, null, "48b06c66-3ea8-4ca1-b89f-4c47240a469a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Java (Spring, Java SE, Java EE)", null, false, "Serkan", null, false, false, "Selek", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "073b76cd-446c-442f-8bf6-ff6bed9df1b0", false, "serkan-selek", null },
                    { "3", 0, null, null, "748f6ddd-f138-4cee-a300-01497a4f5a62", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Python", null, false, "Furkan", null, false, false, "Yüksel", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "8656fc09-c77d-4139-b380-8aefbee7e104", false, "furkan-yuksel", null },
                    { "4", 0, null, null, "b9f53004-8ad9-421d-85bb-c036e7bb3db7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JavaScript", null, false, "Ali", null, false, false, "Turan", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "2ce2e49a-9834-4ed3-9da0-f226f14f75c0", false, "ali-turan", null },
                    { "5", 0, null, null, "28ce6e7a-ce67-4f52-b37f-9e048bbb9145", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C/C++", null, false, "Mert", null, false, false, "Tutkun", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "453ff055-ac25-493d-a6cc-8d13f9d7e59d", false, "mert-tutkun", null },
                    { "6", 0, null, null, "1b67e95d-2ab7-47c1-902c-a77c75dc7b64", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iOS & Android", null, false, "Alim", null, false, false, "Yalçınkaya", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "6916ee84-d379-4202-8b26-2669dc7feec9", false, "alim-yalcinkaya", null },
                    { "7", 0, null, null, "15b9c6f9-7d3d-4134-9768-7ec3f099ecbb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Node.js", null, false, "Uğurcan", null, false, false, "Çildiz", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "ce41f483-0f44-4aa4-bd65-2529b39887c9", false, "ugurcan-cildiz", null },
                    { "8", 0, null, null, "224f152a-953f-4eb6-8821-a7f7305b156e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "React", null, false, "Rıdvan", null, false, false, "Karakaya", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "e7e524d4-c1ec-4636-a040-d857260479af", false, "rıdvan-karakaya", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 15, 19, 38, 23, 7, DateTimeKind.Local).AddTicks(9898), "Yazılım geliştirme, bilgisayar programlarının tasarımı, oluşturulması ve sürdürülmesi sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, işlevsellik sağlamak ve teknolojik çözümler üretmek için kodlama, test etme ve dağıtma adımlarını içerir.", true, false, new DateTime(2023, 10, 15, 19, 38, 23, 7, DateTimeKind.Local).AddTicks(9905), "Yazılım Geliştime", "yazilim-gelistirme" },
                    { 2, new DateTime(2023, 10, 15, 19, 38, 23, 7, DateTimeKind.Local).AddTicks(9911), "Mobil uygulama geliştirme, mobil platformlarda çalışabilen kullanışlı ve etkileşimli yazılım uygulamalarının tasarımı, oluşturulması ve dağıtılması sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, sorunlara çözüm sunmak ve kullanıcı deneyimini geliştirmek için programlama, arayüz tasarımı, test etme ve dağıtma adımlarını içerir.", true, false, new DateTime(2023, 10, 15, 19, 38, 23, 7, DateTimeKind.Local).AddTicks(9912), "Mobil Uygulama Geliştirme", "mobil-uygulama-gelistirme" },
                    { 3, new DateTime(2023, 10, 15, 19, 38, 23, 7, DateTimeKind.Local).AddTicks(9914), "Oyun geliştirme, video oyunlarının tasarımı, programlaması ve oluşturulması sürecidir. Bu süreç, oyun kavramının belirlenmesi, hikaye yazımı, karakter tasarımı, dünya oluşturma, grafik ve ses tasarımı, oyun mekaniği ve kullanıcı arayüzü gibi aşamaları içerir.", true, false, new DateTime(2023, 10, 15, 19, 38, 23, 7, DateTimeKind.Local).AddTicks(9914), "Oyun Geliştime", "oyun-gelistirme" },
                    { 4, new DateTime(2023, 10, 15, 19, 38, 23, 7, DateTimeKind.Local).AddTicks(9916), "Web, dünya genelinde bilgilere erişim sağlayan ve kullanıcıların çeşitli hizmetlere bağlanmasını mümkün kılan bir ağdır. Web, HTML, CSS ve JavaScript gibi teknolojilerle oluşturulan web siteleri ve web uygulamaları aracılığıyla çalışır.", true, false, new DateTime(2023, 10, 15, 19, 38, 23, 7, DateTimeKind.Local).AddTicks(9917), "Web", "web" },
                    { 5, new DateTime(2023, 10, 15, 19, 38, 23, 7, DateTimeKind.Local).AddTicks(9918), "Veritabanı, yapılandırılmış verilerin depolandığı ve yönetildiği bir elektronik sistemdir. Veritabanları, bilgiyi organize etmek, erişmek, güncellemek ve analiz etmek için kullanılır. İşletmeler, kuruluşlar ve web uygulamaları gibi birçok alan veritabanlarını kullanır.", true, false, new DateTime(2023, 10, 15, 19, 38, 23, 7, DateTimeKind.Local).AddTicks(9919), "Veritabanı", "veritabani" },
                    { 6, new DateTime(2023, 10, 15, 19, 38, 23, 7, DateTimeKind.Local).AddTicks(9920), "DevOps, yazılım geliştirme ve işletim süreçlerini birleştirerek, yazılım projelerinin daha hızlı, güvenilir ve sürekli bir şekilde dağıtılmasını sağlayan bir yaklaşımdır. Bu metodoloji, geliştirme (Development) ve işletim (Operations) ekipleri arasında işbirliği ve iletişimi teşvik eder.", true, false, new DateTime(2023, 10, 15, 19, 38, 23, 7, DateTimeKind.Local).AddTicks(9921), "DevOps", "devops" },
                    { 7, new DateTime(2023, 10, 15, 19, 38, 23, 7, DateTimeKind.Local).AddTicks(9923), "Bulut, internet üzerinde sunulan paylaşımlı bilgi işlem kaynaklarını ifade eder. Bulut hizmetleri, sunucular, depolama, veritabanları, ağ altyapısı ve uygulama hizmetleri gibi kaynaklara erişimi kolaylaştırır. Kullanıcılar, istedikleri zaman istedikleri yerden bu kaynaklara güvenli bir şekilde erişebilir ve ihtiyaçlarına göre ölçeklendirebilir.", true, false, new DateTime(2023, 10, 15, 19, 38, 23, 7, DateTimeKind.Local).AddTicks(9923), "Bulut", "bulut" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "About", "Adress", "CompanyName", "CreatedDate", "Information", "IsActive", "IsDeleted", "ModifiedDate", "Questions" },
                values: new object[] { 1, "Eğitim", "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", "Bright Akademie", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(9705), "Eğitim", true, false, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(9711), "Eğitim" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "About", "AccessFailedCount", "BirthOfYear", "ConcurrencyStamp", "CreatedDate", "Education", "Email", "EmailConfirmed", "Evaluation", "Experience", "Field", "FirstName", "IsActive", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoUrl", "SecurityStamp", "TwoFactorEnabled", "Url", "UserName" },
                values: new object[,]
                {
                    { 1, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1990, "088e3c26-4880-43de-a1fd-455ae8a74f39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "UI Developer", "", "Dominic", false, false, "Harmon", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "f5b76a52-f87e-478b-b10e-82cc6a95c6fd", false, "", null },
                    { 2, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1990, "db5d5365-f884-48a1-9bfa-c2941c40f304", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "UI Developer", "", "Justina", false, false, "Burch", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "cebd5e13-73a0-42e3-a938-9ee5b32efb88", false, "", null },
                    { 3, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1985, "94ad2386-a737-4bb3-9315-cf659ac46c84", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "Cyber Security Expert", "", "Madison", false, false, "Beard", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "a9bbe558-e02d-4bfe-aa8a-b5ae1f547024", false, "", null },
                    { 4, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1982, "438a7cfa-ed89-4533-a37e-556d059745d9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "Cyber Security Expert", "", "Sara", false, false, "Wade", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "c18f3eae-f285-4423-ba7b-5f7f0f63fa12", false, "", null },
                    { 5, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1988, "beda4a89-9bb2-4d94-9803-e496e0e220be", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "Software Developer", "", "Jacob", false, false, "Hunt", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "ea1e5b91-75d3-49dc-b83a-92f74b5370f8", false, "", null },
                    { 6, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1989, "87245397-f8fa-4a4c-938c-3e46e586875e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "", "", "Osamu", false, false, "Dazai", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "2556a63b-2689-43e7-a5af-7ba0530bdd5f", false, "", null },
                    { 7, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1983, "a094e3d4-cdee-4145-a2a0-020153c668aa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "Software Developer", "", "Zachery", false, false, "Salas", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "104295f1-1c61-49dc-a66b-54444a8e9d5b", false, "", null },
                    { 8, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1982, "a93b3565-e833-495e-9455-bf27a4cd4745", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "Software Developer", "", "Matt", false, false, "Haig", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "204f3a4e-4f58-485f-9975-87aff3b96c95", false, "", null },
                    { 9, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1982, "0020e902-1a77-4a73-b98b-76b7c854489d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "Software Developer", "", "William", false, false, "Hawkingan", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "4db6bbba-dfce-453f-971c-b51a30832aa8", false, "", null },
                    { 10, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1990, "ea79ebb1-9843-4a6b-9aef-47170897ef7a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "Data Science", "", "Geraldine", false, false, "Richmond", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "79c6e33d-1ba7-42ad-bac2-c8b103ce109c", false, "", null },
                    { 11, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1983, "bd7c0513-eef1-488a-ad04-559b09d26e97", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "Data Science", "", "Steffan", false, false, "Ros", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "243742e7-59fc-43cf-bde3-1eb92b4f9c28", false, "", null },
                    { 12, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1991, "049dc87f-20ba-40c5-9b64-0b6b4f64adae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "", "", "Nichole", false, false, "Talley", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "cf2dc2a1-fc23-43c9-951d-0ac3370f9559", false, "", null },
                    { 13, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1979, "3e5db3b8-beed-4718-81b5-183061e353f5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "Data Science", "", "Yetta", false, false, "Sheppard", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "c82d51bc-2f4f-4893-ad37-43ad227ebc9f", false, "", null },
                    { 14, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1978, "7dbb278c-c330-49be-a505-06299b63192f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "Data Science", "", "Elijah", false, false, "Farley", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "b00c2c8d-9647-4e70-9d3a-9056a3f1de87", false, "", null },
                    { 15, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 0, 1991, "1fd4c624-1365-4d5a-8b8c-55236a86e3d5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, false, 1m, "Full Stack Developer", "", "Neil", false, false, "Wooten", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, false, "1.png", "65f4001a-1863-45d6-9bf7-8ed1ea66ee4d", false, "", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Education", "Email", "EmailConfirmed", "Evaluation", "Experience", "Field", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoUrl", "SecurityStamp", "TwoFactorEnabled", "Url", "UserName" },
                values: new object[,]
                {
                    { "1", null, 0, "Ortaköy Mahallesi. Portakal Yokuşu Sk. No:12 D:3 Beşiktaş", "İstanbul", "5743982f-bad4-40b7-94ea-cf53532b6804", new DateTime(1998, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "furkanyuksel@gmail.com", true, 0m, null, null, "Furkan", "Erkek", "Yüksel", true, null, " ", "FURKANYUKSEL@GMAIL.COM", "SUPERADMIN", "AQAAAAIAAYagAAAAELw9NoP0acm22jGYk8siyV1C3raFHvJBIjUAqJENjPWDFbrzWrD6EilnY9RjRITmjQ==", "+905445324889", true, null, "f12e5dbf-2c85-488f-b102-cde05d5960ff", false, null, "superadmin" },
                    { "2", null, 0, "Fenerbahçe Bulvarı Lefter Sokak K:2 D:7 Kadıköy", "İstanbul", "674dc297-d89d-413c-b9cb-d724c6de6b29", new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "mertberber@gmail.com", true, 0m, null, null, "Mert", "Erkek", "Berber", true, null, " ", "MERTBERBER@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEDHiPVPycGSPhawH2nrirkIZZi/Bf1H+KxPzSQU9rytlasU0IVReFVoY6tDVZl5sOw==", "+904596677888", true, null, "bda08ef3-6362-4a83-8508-0653404c81ab", false, null, "admin" },
                    { "3", null, 0, "Eğitmen Adresi", "İstanbul", "f566df3a-b8e7-4a44-b685-2cd343c0342a", new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "trainer@gmail.com", true, 0m, null, null, "Eğitmen", "Erkek", "Eğitmen Soyadı", true, null, " ", "TRAINER@GMAIL.COM", "TRAINER", "AQAAAAIAAYagAAAAEF35NOG5O/fyaITgQbwSeUsDJ+KdYtP1FspW4iwNJ87t93MVqZUxcVXEBbNoC6EKyA==", "+901234567890", true, null, "8c5d72ee-e267-47cc-b158-d2d64e083fb3", false, null, "trainer" },
                    { "4", null, 0, "Eğitilen Adresi", "Ankara", "ab2c9bb2-d438-4835-9340-8160a1930c6f", new DateTime(1995, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "trainee@gmail.com", true, 0m, null, null, "Eğitilen", "Kadın", "Eğitilen Soyadı", true, null, " ", "TRAINEE@GMAIL.COM", "TRAINEE", "AQAAAAIAAYagAAAAEPfJl+f4ksdE7Up2hFSqP2osbqlQ75BCf2cqnxLUIwMXg+F32Xx3pn4LqqrOwiHC/A==", "+901234567891", true, null, "20b0846b-ee53-4f84-ab67-80355b4f8281", false, null, "trainee" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b26b6caa-1393-4cd6-a546-d57e235adf32", "1" },
                    { "90a73e04-bec7-4dbd-9e98-eca47f8083cb", "2" },
                    { "c806df79-bc2a-4202-b69f-a2d009ca115a", "3" },
                    { "640724d1-fe65-408f-810d-21485287b195", "4" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseLevel", "CreatedDate", "Description", "Earnings", "End", "Evaluation", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "Location", "ModifiedDate", "Name", "Price", "Start", "Statues", "Time", "TotalTime", "TraineeId", "TrainerId", "Url" },
                values: new object[,]
                {
                    { 1, "Easy", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(1986), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2019), 5m, "1.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2009), ".NET (.NET Core, MVC, Web API)", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2017), "Tamamlandı.", "4", "200", null, 1, ".net-core-mvc" },
                    { 2, "Easy", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2037), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2041), 5m, "2.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2038), "Java (Spring, Java SE, Java EE)", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2040), "Tamamlandı.", "4", "200", null, 2, "java" },
                    { 3, "Easy", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2045), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2048), 5m, "3.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2045), "Python", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2047), "Tamamlandı.", "4", "200", null, 3, "python" },
                    { 4, "Easy", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2051), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2054), 5m, "4.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2052), "JavaScript", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2053), "Tamamlandı.", "4", "200", null, 4, "javascript" },
                    { 5, "Easy", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2140), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2143), 5m, "5.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2141), "C/C++", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2142), "Açılacak.", "4", "200", null, 5, "c/c++	" },
                    { 6, "Easy", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2147), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2150), 5m, "6.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2148), "iOS & Android", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2149), "Açılacak.", "4", "200", null, 6, "ios-android" },
                    { 7, "Easy", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2153), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2156), 5m, "7.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2154), "React Native", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2155), "Açılacak.", "4", "200", null, 7, "react-native" },
                    { 8, "Easy", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2159), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2194), 5m, "8.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2164), "Flutter", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2193), "Açılacak.", "4", "200", null, 8, "flutter" },
                    { 9, "Medium", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2197), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2200), 5m, "9.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2198), "Ionic", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2199), "Açılacak.", "4", "200", null, 9, "ionic" },
                    { 10, "Medium", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2203), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2206), 5m, "10.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2204), "Unity", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2205), "Açılacak.", "4", "200", null, 10, "unity" },
                    { 11, "Medium", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2209), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2212), 5m, "11.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2210), "Unreal Engine", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2211), "Açılacak.", "4", "200", null, 11, "unreal-engine" },
                    { 12, "Medium", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2215), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2218), 5m, "12.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2215), "GameMaker Studio", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2217), "Açılacak.", "4", "200", null, 12, "gamemaker-studio" },
                    { 13, "Medium", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2221), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2224), 5m, "13.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2221), "Buildbox", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2223), "Açılacak.", "4", "200", null, 13, "buildbox" },
                    { 14, "Medium", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2227), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2229), 5m, "14.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2227), "PHP", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2229), "Açılacak.", "4", "200", null, 14, "php" },
                    { 15, "Medium", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2232), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2235), 5m, "15.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2233), "React", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2234), "Açılacak.", "4", "200", null, 8, "react" },
                    { 16, "Medium", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2242), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2245), 5m, "16.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2243), "Angular", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2244), "Açılacak.", "4", "200", null, 9, "angular" },
                    { 17, "Medium", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2248), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2251), 5m, "17.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2249), "Node.js", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2250), "Açılacak.", "4", "200", null, 10, "nodejs" },
                    { 18, "Medium", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2254), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2257), 5m, "18.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2255), "Microsoft SQL Server", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2256), "Açılacak.", "4", "200", null, 11, "microsoft-sql-server" },
                    { 19, "Medium", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2260), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2263), 5m, "19.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2261), "MySQL", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2262), "Açılacak.", "4", "200", null, 12, "mysql" },
                    { 20, "Medium", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2266), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2269), 5m, "20.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2266), "PostgreSQL", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2268), "Açılacak.", "4", "200", null, 13, "postgresql" },
                    { 21, "Senior", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2272), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2275), 5m, "21.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2272), "SQLite", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2274), "Açılacak.", "4", "200", null, 11, "sqlite" },
                    { 22, "Senior", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2278), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2281), 5m, "22.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2278), "Oracle", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2280), "Devam Ediyor.", "4", "200", null, 12, "oracle" },
                    { 23, "Senior", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2284), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2287), 5m, "23.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2284), "Docker", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2286), "Devam Ediyor.", "4", "200", null, 13, "docker" },
                    { 24, "Senior", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2290), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2292), 5m, "24.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2290), "Jenkins", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2292), "Devam Ediyor.", "4", "200", null, 14, "jenkins" },
                    { 25, "Senior", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2296), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2298), 5m, "25.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2296), "Ansible", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2298), "Devam Ediyor.", "4", "200", null, 8, "ansible" },
                    { 26, "Senior", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2301), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2304), 5m, "26.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2302), "Sonarcube", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2304), "Devam Ediyor.", "4", "200", null, 9, "sonarcube" },
                    { 27, "Senior", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2307), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2310), 5m, "27.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2308), "AWS", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2309), "Devam Ediyor.", "4", "200", null, 10, "aws" },
                    { 28, "Senior", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2313), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2316), 5m, "28.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2314), "Azure", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2315), "Devam Ediyor.", "4", "200", null, 11, "azure" },
                    { 29, "Senior", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2319), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2322), 5m, "29.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2319), "Serverless", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2321), "Devam Ediyor.", "4", "200", null, 12, "serverless" },
                    { 30, "Senior", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2325), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2327), 5m, "30.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2325), "Cloud Storage", 100m, new DateTime(2023, 10, 15, 19, 38, 23, 5, DateTimeKind.Local).AddTicks(2327), "Devam Ediyor.", "4", "200", null, 12, "cloudstorage" }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainees",
                columns: new[] { "CourseId", "TraineeId", "TraineeId1" },
                values: new object[,]
                {
                    { 1, 1, null },
                    { 2, 1, null },
                    { 3, 1, null },
                    { 4, 1, null },
                    { 5, 1, null },
                    { 6, 2, null },
                    { 8, 2, null },
                    { 9, 2, null },
                    { 10, 3, null },
                    { 11, 3, null },
                    { 12, 3, null },
                    { 13, 3, null },
                    { 14, 4, null },
                    { 15, 4, null },
                    { 16, 4, null },
                    { 17, 4, null },
                    { 18, 5, null },
                    { 19, 5, null },
                    { 20, 5, null },
                    { 21, 5, null },
                    { 22, 5, null },
                    { 23, 6, null },
                    { 24, 6, null },
                    { 25, 6, null },
                    { 26, 6, null },
                    { 27, 7, null },
                    { 28, 7, null },
                    { 29, 7, null },
                    { 30, 8, null }
                });

            migrationBuilder.InsertData(
                table: "CoursesCategories",
                columns: new[] { "CategoryId", "CourseId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 2, 8 },
                    { 2, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 13 },
                    { 4, 14 },
                    { 4, 15 },
                    { 4, 16 },
                    { 4, 17 },
                    { 5, 18 },
                    { 5, 19 },
                    { 5, 20 },
                    { 5, 21 },
                    { 5, 22 },
                    { 6, 23 },
                    { 6, 24 },
                    { 6, 25 },
                    { 6, 26 },
                    { 7, 27 },
                    { 7, 28 },
                    { 7, 29 },
                    { 7, 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CourseId",
                table: "CartItems",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TraineeId",
                table: "Courses",
                column: "TraineeId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TrainerId",
                table: "Courses",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesCategories_CategoryId",
                table: "CoursesCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTrainees_TraineeId1",
                table: "CourseTrainees",
                column: "TraineeId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CourseId",
                table: "OrderItems",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "CoursesCategories");

            migrationBuilder.DropTable(
                name: "CourseTrainees");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
