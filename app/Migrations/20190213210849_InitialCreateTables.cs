using Microsoft.EntityFrameworkCore.Migrations;

namespace app.Migrations
{
    public partial class InitialCreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Determinants",
                columns: table => new
                {
                    DeterminantId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Year = table.Column<int>(nullable: false),
                    CountryCode = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Technology = table.Column<string>(nullable: true),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Determinants", x => x.DeterminantId);
                    table.ForeignKey(
                        name: "FK_Determinants_Countries_CountryCode",
                        column: x => x.CountryCode,
                        principalTable: "Countries",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Determinants_CountryCode",
                table: "Determinants",
                column: "CountryCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Determinants");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
