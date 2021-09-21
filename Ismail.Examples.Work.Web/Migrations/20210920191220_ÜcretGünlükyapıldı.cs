using Microsoft.EntityFrameworkCore.Migrations;

namespace Ismail.Examples.Work.Web.Migrations
{
    public partial class ÜcretGünlükyapıldı : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ücret",
                table: "Hotel",
                newName: "ÜcretGünlük");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ÜcretGünlük",
                table: "Hotel",
                newName: "Ücret");
        }
    }
}
