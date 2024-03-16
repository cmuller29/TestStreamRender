using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestStreamRender.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Test = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Test" },
                values: new object[,]
                {
                    { new Guid("4441c0c4-59a3-42a2-b670-65d551159dbb"), "TEST1" },
                    { new Guid("78d1afe8-dd40-4ae1-83df-5cd6a7421d9b"), "TEST2" },
                    { new Guid("f3aed082-7665-433f-8b20-c00b9ca409d2"), "TEST3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Models");
        }
    }
}
