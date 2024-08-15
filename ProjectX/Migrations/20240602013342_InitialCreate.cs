using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectX.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Passcode = table.Column<string>(type: "TEXT", nullable: false),
                    ItemName = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    OwnersName = table.Column<string>(type: "TEXT", nullable: false),
                    OwnersMail = table.Column<string>(type: "TEXT", nullable: false),
                    ShipmentWeight = table.Column<double>(type: "REAL", nullable: false),
                    Destination = table.Column<string>(type: "TEXT", nullable: false),
                    ShipmentStartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Passls = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Shipments",
                columns: new[] { "Id", "DeliveryDate", "Destination", "ItemName", "Location", "OwnersMail", "OwnersName", "Passcode", "Passls", "ShipmentStartDate", "ShipmentWeight" },
                values: new object[] { new Guid("316a3643-1bd0-4f47-9699-dfd6d5c3acce"), new DateTime(2024, 6, 7, 2, 33, 41, 891, DateTimeKind.Local).AddTicks(1397), "Destination1", "Item1", "Location1", "owner1@example.com", "Owner1", "1234", "pass1", new DateTime(2024, 5, 28, 2, 33, 41, 891, DateTimeKind.Local).AddTicks(1376), 10.0 });

            migrationBuilder.InsertData(
                table: "Shipments",
                columns: new[] { "Id", "DeliveryDate", "Destination", "ItemName", "Location", "OwnersMail", "OwnersName", "Passcode", "Passls", "ShipmentStartDate", "ShipmentWeight" },
                values: new object[] { new Guid("7f4cf144-efcf-47bd-9ffc-5cafc97a6864"), new DateTime(2024, 6, 9, 2, 33, 41, 891, DateTimeKind.Local).AddTicks(1407), "Destination3", "Item3", "Location3", "owner3@example.com", "Owner3", "abcd", "pass3", new DateTime(2024, 5, 26, 2, 33, 41, 891, DateTimeKind.Local).AddTicks(1407), 30.0 });

            migrationBuilder.InsertData(
                table: "Shipments",
                columns: new[] { "Id", "DeliveryDate", "Destination", "ItemName", "Location", "OwnersMail", "OwnersName", "Passcode", "Passls", "ShipmentStartDate", "ShipmentWeight" },
                values: new object[] { new Guid("a1929b7b-91eb-4f1d-a8c8-4dffa88db762"), new DateTime(2024, 6, 12, 2, 33, 41, 891, DateTimeKind.Local).AddTicks(1412), "Destination4", "Item4", "Location4", "owner4@example.com", "Owner4", "efgh", "pass4", new DateTime(2024, 5, 30, 2, 33, 41, 891, DateTimeKind.Local).AddTicks(1411), 40.0 });

            migrationBuilder.InsertData(
                table: "Shipments",
                columns: new[] { "Id", "DeliveryDate", "Destination", "ItemName", "Location", "OwnersMail", "OwnersName", "Passcode", "Passls", "ShipmentStartDate", "ShipmentWeight" },
                values: new object[] { new Guid("c0a996ae-6405-4026-959f-061738d54113"), new DateTime(2024, 6, 4, 2, 33, 41, 891, DateTimeKind.Local).AddTicks(1403), "Destination2", "Item2", "Location2", "owner2@example.com", "Owner2", "5678", "pass2", new DateTime(2024, 5, 23, 2, 33, 41, 891, DateTimeKind.Local).AddTicks(1402), 20.0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsAdmin", "Password", "Username" },
                values: new object[] { 1, true, "password1", "admin1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsAdmin", "Password", "Username" },
                values: new object[] { 2, true, "password2", "admin2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
