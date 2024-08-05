using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ListApi.Migrations
{
    /// <inheritdoc />
    public partial class Horarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Permission",
                table: "Usuarios",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Dia = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EndTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "Id", "Dia", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { 1, "Segunda-feira", "23:00", "13:00", "Aberto" },
                    { 2, "Terça-feira", "23:30", "13:00", "Aberto" },
                    { 3, "Quarta-feira", "23:00", "13:00", "Aberto" },
                    { 4, "Quinta-feira", "18:00", "8:20", "Aberto" },
                    { 5, "Sexta-feira", "23:59", "18:00", "Aberto" },
                    { 6, "Sábado", "", "", "Fechado" },
                    { 7, "Domingo", "23:00", "18:00", "Aberto" }
                });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Celular", "Cep", "Telefone" },
                values: new object[] { "4399859-9286", "86601028", "433256-9661" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropColumn(
                name: "Permission",
                table: "Usuarios");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Celular", "Cep", "Telefone" },
                values: new object[] { "43 99859-9286", "86601-028", "43 3256-9661" });
        }
    }
}
