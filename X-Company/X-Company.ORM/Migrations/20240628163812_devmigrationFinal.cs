using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace X_Company.ORM.Migrations
{
    /// <inheritdoc />
    public partial class devmigrationFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "custome_schema");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:postgis", ",,");

            migrationBuilder.CreateTable(
                name: "TBCLIENT",
                schema: "custome_schema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Address = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCLIENT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBPRODUCT",
                schema: "custome_schema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Price = table.Column<double>(type: "DOUBLE PRECISION", nullable: false),
                    InStock = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPRODUCT", x => x.Id);
                });

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

            migrationBuilder.DropTable(
                name: "TBCLIENT",
                schema: "custome_schema");

            migrationBuilder.DropTable(
                name: "TBPRODUCT",
                schema: "custome_schema");
        }
    }
}
