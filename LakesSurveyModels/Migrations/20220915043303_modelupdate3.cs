using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LakesSurveyModels.Migrations
{
    public partial class modelupdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LakeName",
                table: "LakeList",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LakeName",
                table: "LakeList");
        }
    }
}
