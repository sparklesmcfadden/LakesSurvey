using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LakesSurveyModels.Migrations
{
    public partial class modelupdate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Survey",
                table: "LakeList",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Survey",
                table: "LakeList");
        }
    }
}
