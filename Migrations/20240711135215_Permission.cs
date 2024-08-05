using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListApi.Migrations
{
    /// <inheritdoc />
    public partial class Permission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: "1",
                column: "Permission",
                value: "B");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: "2",
                column: "Permission",
                value: "A");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: "1",
                column: "Permission",
                value: null);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: "2",
                column: "Permission",
                value: null);
        }
    }
}
