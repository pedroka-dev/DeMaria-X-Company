using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace X_Company.ORM.Migrations
{
    /// <inheritdoc />
    public partial class devmigration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "custome_schema",
                table: "TBPRODUCT",
                type: "VARCHAR(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "custome_schema",
                table: "TBPRODUCT",
                type: "VARCHAR(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                schema: "custome_schema",
                table: "TBCLIENT",
                type: "VARCHAR(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "custome_schema",
                table: "TBCLIENT",
                type: "VARCHAR(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "custome_schema",
                table: "TBCLIENT",
                type: "VARCHAR(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "custome_schema",
                table: "TBCLIENT",
                type: "VARCHAR(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "custome_schema",
                table: "TBPRODUCT",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(250)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "custome_schema",
                table: "TBPRODUCT",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(250)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                schema: "custome_schema",
                table: "TBCLIENT",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(250)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "custome_schema",
                table: "TBCLIENT",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(250)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "custome_schema",
                table: "TBCLIENT",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(250)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "custome_schema",
                table: "TBCLIENT",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(250)");
        }
    }
}
