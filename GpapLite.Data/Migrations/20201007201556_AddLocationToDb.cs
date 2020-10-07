using Microsoft.EntityFrameworkCore.Migrations;

namespace GpapLite.Data.Migrations
{
    public partial class AddLocationToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_SubCounties_SubCountyId",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameIndex(
                name: "IX_Location_SubCountyId",
                table: "Locations",
                newName: "IX_Locations_SubCountyId");

            migrationBuilder.AlterColumn<int>(
                name: "SubCountyId",
                table: "Locations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_SubCounties_SubCountyId",
                table: "Locations",
                column: "SubCountyId",
                principalTable: "SubCounties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_SubCounties_SubCountyId",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameIndex(
                name: "IX_Locations_SubCountyId",
                table: "Location",
                newName: "IX_Location_SubCountyId");

            migrationBuilder.AlterColumn<int>(
                name: "SubCountyId",
                table: "Location",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_SubCounties_SubCountyId",
                table: "Location",
                column: "SubCountyId",
                principalTable: "SubCounties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
