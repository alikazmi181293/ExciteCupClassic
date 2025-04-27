using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExciteCupClassic.Database.Migrations
{
    /// <inheritdoc />
    public partial class CreatedTeamEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TeamId",
                table: "participants",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "teams",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teams", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_participants_TeamId",
                table: "participants",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_participants_teams_TeamId",
                table: "participants",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_participants_teams_TeamId",
                table: "participants");

            migrationBuilder.DropTable(
                name: "teams");

            migrationBuilder.DropIndex(
                name: "IX_participants_TeamId",
                table: "participants");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "participants");
        }
    }
}
