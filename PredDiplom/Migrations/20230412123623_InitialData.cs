using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PredDiplom.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "BookId", "Athor", "Description", "Genre", "IBAN", "Name", "TimeOfIssue", "TimeOfReturn" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Борис Стругатский, Аркадий Стругатский", "«Пикни́к на обо́чине» — философская фантастическая повесть братьев Стругацких, впервые изданная в 1972 году.", "Фантастика", "1723323947", "Пикник на обочине", "22.03.2023", "14.04.2023" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "BookId", "Athor", "Description", "Genre", "IBAN", "Name", "TimeOfIssue", "TimeOfReturn" },
                values: new object[] { new Guid("c9d4c911-49b6-410c-bc78-2d54a9991870"), "Борис Стругатский, Аркадий Стругатский", "««Град обрече́нный» — философский роман Аркадия и Бориса Стругацких. Писался «в стол», когда братья оказались в состоянии мировоззренческого кризиса, а затем были резко ограничены в возможностях публиковаться. ", "Роман", "786324345", "Град обреченный", "22.03.2023", "14.04.2023" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "BookId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "BookId",
                keyValue: new Guid("c9d4c911-49b6-410c-bc78-2d54a9991870"));
        }
    }
}
