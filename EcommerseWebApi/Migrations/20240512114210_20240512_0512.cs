using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerseWebApi.Migrations
{
    /// <inheritdoc />
    public partial class _20240512_0512 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "commMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isSuccess = table.Column<bool>(type: "bit", nullable: true),
                    isError = table.Column<bool>(type: "bit", nullable: false),
                    ErrorNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Controler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    method = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commMessages", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "commMessages");
        }
    }
}
