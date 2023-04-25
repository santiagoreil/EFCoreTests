using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTests.Console.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shopify_Product",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopify_Product", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shopify_Product_Variant",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopify_Product_Variant", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shopify_Product_Variant_Shopify_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Shopify_Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shopify_ProductImage",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopify_ProductImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shopify_ProductImage_Shopify_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Shopify_Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shopify_ProductOption",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopify_ProductOption", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shopify_ProductOption_Shopify_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Shopify_Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shopify_Product_Variant_ProductId",
                table: "Shopify_Product_Variant",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Shopify_ProductImage_ProductId",
                table: "Shopify_ProductImage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Shopify_ProductOption_ProductId",
                table: "Shopify_ProductOption",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shopify_Product_Variant");

            migrationBuilder.DropTable(
                name: "Shopify_ProductImage");

            migrationBuilder.DropTable(
                name: "Shopify_ProductOption");

            migrationBuilder.DropTable(
                name: "Shopify_Product");
        }
    }
}
