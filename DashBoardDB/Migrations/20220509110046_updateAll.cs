using Microsoft.EntityFrameworkCore.Migrations;

namespace DashBoardDAL.Migrations
{
    public partial class updateAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamEntityUserEntity_team_TeamsId",
                table: "TeamEntityUserEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_team",
                table: "team");

            migrationBuilder.RenameTable(
                name: "team",
                newName: "TeamEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team ",
                table: "TeamEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamEntityUserEntity_TeamEntity_TeamsId",
                table: "TeamEntityUserEntity",
                column: "TeamsId",
                principalTable: "TeamEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamEntityUserEntity_TeamEntity_TeamsId",
                table: "TeamEntityUserEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team ",
                table: "TeamEntity");

            migrationBuilder.RenameTable(
                name: "TeamEntity",
                newName: "team");

            migrationBuilder.AddPrimaryKey(
                name: "PK_team",
                table: "team",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamEntityUserEntity_team_TeamsId",
                table: "TeamEntityUserEntity",
                column: "TeamsId",
                principalTable: "team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
