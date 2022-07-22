using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping_center.Migrations
{
    public partial class AddPropertyPhoneNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                 name: "PhoneNumber",
                 table: "People",
                 type: "INTEGER",
                 nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("People", "PhoneNumber");
        }
    }
}
