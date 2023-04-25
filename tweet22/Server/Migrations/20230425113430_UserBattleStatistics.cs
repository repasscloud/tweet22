using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tweet22.Server.Migrations
{
    /// <inheritdoc />
    public partial class UserBattleStatistics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Battles",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Defeats",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Victories",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Battles",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Defeats",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Victories",
                table: "Users");
        }
    }
}
