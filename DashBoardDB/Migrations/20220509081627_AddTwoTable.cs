using Microsoft.EntityFrameworkCore.Migrations;

namespace DashBoardDAL.Migrations
{
    public partial class AddTwoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectEntityId",
                table: "UserEntity",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamEntityUserEntity",
                columns: table => new
                {
                    TeamUsersId = table.Column<int>(type: "int", nullable: false),
                    TeamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamEntityUserEntity", x => new { x.TeamUsersId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_TeamEntityUserEntity_team_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamEntityUserEntity_UserEntity_TeamUsersId",
                        column: x => x.TeamUsersId,
                        principalTable: "UserEntity",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserEntity_ProjectEntityId",
                table: "UserEntity",
                column: "ProjectEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamEntityUserEntity_TeamsId",
                table: "TeamEntityUserEntity",
                column: "TeamsId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserEntity_Project_ProjectEntityId",
                table: "UserEntity",
                column: "ProjectEntityId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserEntity_Project_ProjectEntityId",
                table: "UserEntity");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "TeamEntityUserEntity");

            migrationBuilder.DropTable(
                name: "team");

            migrationBuilder.DropIndex(
                name: "IX_UserEntity_ProjectEntityId",
                table: "UserEntity");

            migrationBuilder.DropColumn(
                name: "ProjectEntityId",
                table: "UserEntity");
        }
    }
}
