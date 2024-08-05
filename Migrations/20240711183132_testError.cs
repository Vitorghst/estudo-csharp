using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ListApi.Migrations
{
    /// <inheritdoc />
    public partial class testError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Horarios",
                keyColumn: "Id",
                keyValue: 7);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
