using Microsoft.EntityFrameworkCore.Migrations;

namespace car_stereo_world_api_demo.Migrations
{
    public partial class PropperBrandComponentRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_ComponentSeries_ComponentSeriesId",
                table: "Components");

            migrationBuilder.AlterColumn<int>(
                name: "ComponentSeriesId",
                table: "Components",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Components_ComponentSeries_ComponentSeriesId",
                table: "Components",
                column: "ComponentSeriesId",
                principalTable: "ComponentSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_ComponentSeries_ComponentSeriesId",
                table: "Components");

            migrationBuilder.AlterColumn<int>(
                name: "ComponentSeriesId",
                table: "Components",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Components_ComponentSeries_ComponentSeriesId",
                table: "Components",
                column: "ComponentSeriesId",
                principalTable: "ComponentSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
