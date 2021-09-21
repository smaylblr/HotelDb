﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ismail.Examples.Work.Web.Migrations
{
    public partial class HotelEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YıldızSayısı = table.Column<int>(type: "int", nullable: false),
                    Ücret = table.Column<int>(type: "int", nullable: false),
                    YemekSekli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotel");
        }
    }
}
