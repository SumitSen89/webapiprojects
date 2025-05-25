using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerseWebApi.Migrations
{
    /// <inheritdoc />
    public partial class _20240518_1124 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Operation",
                table: "commMessages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Operation",
                table: "commMessages");
        }
    }
}
