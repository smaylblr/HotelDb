using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ismail.Examples.Work.Web.Migrations
{
    public partial class deletedColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sehir",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "TcNO",
                table: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sehir",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "TcNO",
                table: "Customer",
                type: "uniqueidentifier",
                maxLength: 11,
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
