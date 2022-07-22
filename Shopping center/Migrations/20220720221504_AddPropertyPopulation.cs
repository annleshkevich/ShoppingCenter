using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping_center.Migrations
{
    public partial class AddPropertyPopulation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                 name: "Population",
                 table: "Cities",
                 type: "INTEGER",
                 nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Cities", "Population");
        }
    }
}
