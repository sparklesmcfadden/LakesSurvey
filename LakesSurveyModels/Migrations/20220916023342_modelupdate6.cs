using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LakesSurveyModels.Migrations
{
    public partial class modelupdate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Coordinates",
                table: "LakeList",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Distance",
                table: "LakeList",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coordinates",
                table: "LakeList");

            migrationBuilder.DropColumn(
                name: "Distance",
                table: "LakeList");
        }
    }
}
