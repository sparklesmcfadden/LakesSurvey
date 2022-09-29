using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LakesSurveyModels.Migrations
{
    public partial class modelupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MinimumLenght",
                table: "Fish",
                newName: "MinimumLength");

            migrationBuilder.CreateTable(
                name: "FishTypes",
                columns: table => new
                {
                    FishTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FishShortName = table.Column<string>(type: "text", nullable: false),
                    FishLongName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishTypes", x => x.FishTypeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FishTypes");

            migrationBuilder.RenameColumn(
                name: "MinimumLength",
                table: "Fish",
                newName: "MinimumLenght");
        }
    }
}
