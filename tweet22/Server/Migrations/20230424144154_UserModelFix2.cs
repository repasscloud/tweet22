using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tweet22.Server.Migrations
{
    /// <inheritdoc />
    public partial class UserModelFix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bananase",
                table: "Users",
                newName: "Bananas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bananas",
                table: "Users",
                newName: "Bananase");
        }
    }
}
