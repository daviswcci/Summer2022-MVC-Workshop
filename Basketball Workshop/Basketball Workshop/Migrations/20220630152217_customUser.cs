using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Basketball_Workshop.Migrations
{
    public partial class customUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Players",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserId",
                table: "Players",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_AspNetUsers_UserId",
                table: "Players",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_AspNetUsers_UserId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_UserId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "FavoriteFood", "Losses", "Name", "StartYear", "Wins" },
                values: new object[] { 1, "Pierogies", 38, "J. B. Bickerstaff", new DateTime(2022, 6, 30, 11, 0, 13, 689, DateTimeKind.Local).AddTicks(3904), 44 });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Point Guard" },
                    { 2, "Shooting Guard" },
                    { 3, "Small Forward" },
                    { 4, "Power Forward" },
                    { 5, "Center" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "City", "CoachId", "Mascot", "Name" },
                values: new object[] { 1, "Cleveland", 1, "Moondog", "Cavs" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "IsRetired", "Name", "PPG", "TeamId" },
                values: new object[] { 1, false, "Kevin Love", 10.4, 1 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "IsRetired", "Name", "PPG", "TeamId" },
                values: new object[] { 2, false, "Colin Sexton", 19.300000000000001, 1 });

            migrationBuilder.InsertData(
                table: "PlayerPositions",
                columns: new[] { "Id", "PlayerId", "PositionId" },
                values: new object[,]
                {
                    { 1, 1, 4 },
                    { 2, 1, 5 },
                    { 3, 2, 1 },
                    { 4, 2, 2 }
                });
        }
    }
}
