using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectService_valueAPI.Migrations
{
    public partial class addUsersToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 2, 23, 9, 38, 59, 105, DateTimeKind.Local).AddTicks(6347), "https://dotnetmastery.com/bluevillaimages/villa3.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl", "Name" },
                values: new object[] { new DateTime(2023, 2, 23, 9, 38, 59, 105, DateTimeKind.Local).AddTicks(6357), "https://dotnetmastery.com/bluevillaimages/villa1.jpg", "Premium Pool Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "Name" },
                values: new object[] { new DateTime(2023, 2, 23, 9, 38, 59, 105, DateTimeKind.Local).AddTicks(6359), "https://dotnetmastery.com/bluevillaimages/villa4.jpg", "Luxury Pool Villa" });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 4, "", new DateTime(2023, 2, 23, 9, 38, 59, 105, DateTimeKind.Local).AddTicks(6360), "First gate, lagos Nigeria", "https://dotnetmastery.com/bluevillaimages/villa5.jpg", "Diamond Villa", 4, 600.0, 1100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(2023, 2, 23, 9, 38, 59, 105, DateTimeKind.Local).AddTicks(6362), "First gate, lagos Nigeria", "https://dotnetmastery.com/bluevillaimages/villa2.jpg", "Diamond Pool Villa", 4, 600.0, 1100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2023, 2, 19, 22, 46, 36, 143, DateTimeKind.Local).AddTicks(605), "https://images.pexels.com/photos/934070/pexels-photo-934070.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl", "Name" },
                values: new object[] { new DateTime(2023, 2, 19, 22, 46, 36, 143, DateTimeKind.Local).AddTicks(616), "https://images.pexels.com/photos/106399/pexels-photo-106399.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "House Villa" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "Name" },
                values: new object[] { new DateTime(2023, 2, 19, 22, 46, 36, 143, DateTimeKind.Local).AddTicks(618), "https://www.gopandy.com/wp-content/uploads/2019/10/keyboard_bag.jpg", "Bag" });
        }
    }
}
