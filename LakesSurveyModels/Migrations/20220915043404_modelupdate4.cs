using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LakesSurveyModels.Migrations
{
    public partial class modelupdate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "LakeList",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "County",
                table: "LakeList",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "LakeList");

            migrationBuilder.DropColumn(
                name: "County",
                table: "LakeList");
        }
    }
}
