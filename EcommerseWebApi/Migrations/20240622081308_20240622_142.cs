using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerseWebApi.Migrations
{
    /// <inheritdoc />
    public partial class _20240622_142 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSpeficationTypeSpecifications");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductSpeficationTypeSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SpeficationID = table.Column<int>(type: "int", nullable: false),
                    SpeficationTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpeficationTypeSpecifications", x => x.Id);
                });
        }
    }
}
