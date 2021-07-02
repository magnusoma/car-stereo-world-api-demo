using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace car_stereo_world_api_demo.Migrations
{
    public partial class ComponentSeries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComponentSeriesId",
                table: "Components",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ComponentSeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProducedFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProducedUntil = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentSeries", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Components_ComponentSeriesId",
                table: "Components",
                column: "ComponentSeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Components_ComponentSeries_ComponentSeriesId",
                table: "Components",
                column: "ComponentSeriesId",
                principalTable: "ComponentSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_ComponentSeries_ComponentSeriesId",
                table: "Components");

            migrationBuilder.DropTable(
                name: "ComponentSeries");

            migrationBuilder.DropIndex(
                name: "IX_Components_ComponentSeriesId",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "ComponentSeriesId",
                table: "Components");
        }
    }
}
