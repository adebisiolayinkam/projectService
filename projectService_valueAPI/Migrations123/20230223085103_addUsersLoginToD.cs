using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectService_valueAPI.Migrations
{
    public partial class addUsersLoginToD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 51, 2, 951, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 51, 2, 951, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 51, 2, 951, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 51, 2, 951, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 9, 51, 2, 951, DateTimeKind.Local).AddTicks(891));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
