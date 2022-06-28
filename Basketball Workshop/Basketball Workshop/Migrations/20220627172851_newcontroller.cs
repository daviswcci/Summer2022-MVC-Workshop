using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Basketball_Workshop.Migrations
{
    public partial class newcontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartYear",
                value: new DateTime(2022, 6, 27, 13, 28, 50, 847, DateTimeKind.Local).AddTicks(9267));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartYear",
                value: new DateTime(2022, 6, 24, 10, 33, 16, 100, DateTimeKind.Local).AddTicks(7218));
        }
    }
}
