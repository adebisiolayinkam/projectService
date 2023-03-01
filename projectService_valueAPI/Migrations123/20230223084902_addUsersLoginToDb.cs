using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectService_valueAPI.Migrations
{
    public partial class addUsersLoginToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 49, 2, 392, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 49, 2, 392, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 49, 2, 392, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 49, 2, 392, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 49, 2, 392, DateTimeKind.Local).AddTicks(5756));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 38, 59, 105, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 38, 59, 105, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 38, 59, 105, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 38, 59, 105, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 38, 59, 105, DateTimeKind.Local).AddTicks(6362));
        }
    }
}
