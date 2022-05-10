using Microsoft.EntityFrameworkCore.Migrations;

namespace DashBoardDAL.Migrations
{
    public partial class addSaltInUSer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "UserEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "UserEntity");
        }
    }
}
