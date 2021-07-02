using Microsoft.EntityFrameworkCore.Migrations;

namespace car_stereo_world_api_demo.Migrations
{
    public partial class Brand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "ComponentSeries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Components",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComponentSeries_BrandId",
                table: "ComponentSeries",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Components_BrandId",
                table: "Components",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Components_Brands_BrandId",
                table: "Components",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentSeries_Brands_BrandId",
                table: "ComponentSeries",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_Brands_BrandId",
                table: "Components");

            migrationBuilder.DropForeignKey(
                name: "FK_ComponentSeries_Brands_BrandId",
                table: "ComponentSeries");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_ComponentSeries_BrandId",
                table: "ComponentSeries");

            migrationBuilder.DropIndex(
                name: "IX_Components_BrandId",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "ComponentSeries");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Components");
        }
    }
}
