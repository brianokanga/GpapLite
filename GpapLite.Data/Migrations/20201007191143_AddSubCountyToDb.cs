using Microsoft.EntityFrameworkCore.Migrations;

namespace GpapLite.Data.Migrations
{
    public partial class AddSubCountyToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCounties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CountyId = table.Column<int>(nullable: false),
                    CountyCountryId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCounties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCounties_Counties_CountyCountryId",
                        column: x => x.CountyCountryId,
                        principalTable: "Counties",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCounties_CountyCountryId",
                table: "SubCounties",
                column: "CountyCountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCounties");
        }
    }
}
