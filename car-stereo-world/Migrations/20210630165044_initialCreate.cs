using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace car_stereo_world.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailableUntil = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PriceNew = table.Column<double>(type: "float", nullable: false),
                    Value100 = table.Column<double>(type: "float", nullable: false),
                    Value80 = table.Column<double>(type: "float", nullable: false),
                    Value60 = table.Column<double>(type: "float", nullable: false),
                    Value40 = table.Column<double>(type: "float", nullable: false),
                    Value20 = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Components");
        }
    }
}
