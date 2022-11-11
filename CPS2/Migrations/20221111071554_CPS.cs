using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPS2.Migrations
{
    /// <inheritdoc />
    public partial class CPS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    priceseriesname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fameticker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customticker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inputunit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inputgranularity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    holidaycalender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maxprice = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    minprice = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    platt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifieddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    modifiedby = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cps__3214EC0761060776", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ecfsetup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    energyconversioname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    value = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    startdate = table.Column<DateTime>(type: "date", nullable: true),
                    modifieddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    modifiedby = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ecfsetup__3214EC07BCEFF169", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fxrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    fxrateseriesname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fameticker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inputgranularity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    holidaycalender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maxprice = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    minprice = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    modifieddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    modifiedby = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Fxrs__3214EC07DC5058F7", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holidaycalendersetup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    holidayname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    excludewee = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    dates = table.Column<DateTime>(type: "date", nullable: true),
                    modifieddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    modifiedby = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Holidayc__3214EC077E3701DB", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cps");

            migrationBuilder.DropTable(
                name: "Ecfsetup");

            migrationBuilder.DropTable(
                name: "Fxrs");

            migrationBuilder.DropTable(
                name: "Holidaycalendersetup");
        }
    }
}
