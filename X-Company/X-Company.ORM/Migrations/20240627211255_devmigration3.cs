using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace X_Company.ORM.Migrations
{
    /// <inheritdoc />
    public partial class devmigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBSALE",
                schema: "custome_schema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBSALE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBSALE_TBCLIENT_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "custome_schema",
                        principalTable: "TBCLIENT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBSALE_TBPRODUCT_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "custome_schema",
                        principalTable: "TBPRODUCT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBSALE_ClientId",
                schema: "custome_schema",
                table: "TBSALE",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_TBSALE_ProductId",
                schema: "custome_schema",
                table: "TBSALE",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBSALE",
                schema: "custome_schema");
        }
    }
}
