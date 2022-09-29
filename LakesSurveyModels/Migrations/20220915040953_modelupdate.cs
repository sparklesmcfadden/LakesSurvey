using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LakesSurveyModels.Migrations
{
    public partial class modelupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fish_FishType_FishTypeId",
                table: "Fish");

            migrationBuilder.DropTable(
                name: "FishType");

            migrationBuilder.DropIndex(
                name: "IX_Fish_FishTypeId",
                table: "Fish");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Fish");

            migrationBuilder.RenameColumn(
                name: "Depth",
                table: "Lakes",
                newName: "MaximumDepth");

            migrationBuilder.RenameColumn(
                name: "Length",
                table: "Fish",
                newName: "MinimumLenght");

            migrationBuilder.RenameColumn(
                name: "FishTypeId",
                table: "Fish",
                newName: "MaximumLength");

            migrationBuilder.AlterColumn<string>(
                name: "SurveyType",
                table: "Surveys",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "LakeId",
                table: "Surveys",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SurveyNumber",
                table: "Surveys",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "AverageDepth",
                table: "Lakes",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "SurveyId",
                table: "Fish",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FishSpecies",
                table: "Fish",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "LengthCount",
                columns: table => new
                {
                    LengthCountId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Length = table.Column<int>(type: "integer", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    FishId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LengthCount", x => x.LengthCountId);
                    table.ForeignKey(
                        name: "FK_LengthCount_Fish_FishId",
                        column: x => x.FishId,
                        principalTable: "Fish",
                        principalColumn: "FishId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_LakeId",
                table: "Surveys",
                column: "LakeId");

            migrationBuilder.CreateIndex(
                name: "IX_LengthCount_FishId",
                table: "LengthCount",
                column: "FishId");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Lakes_LakeId",
                table: "Surveys",
                column: "LakeId",
                principalTable: "Lakes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Lakes_LakeId",
                table: "Surveys");

            migrationBuilder.DropTable(
                name: "LengthCount");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_LakeId",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "LakeId",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "SurveyNumber",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "AverageDepth",
                table: "Lakes");

            migrationBuilder.DropColumn(
                name: "FishSpecies",
                table: "Fish");

            migrationBuilder.RenameColumn(
                name: "MaximumDepth",
                table: "Lakes",
                newName: "Depth");

            migrationBuilder.RenameColumn(
                name: "MinimumLenght",
                table: "Fish",
                newName: "Length");

            migrationBuilder.RenameColumn(
                name: "MaximumLength",
                table: "Fish",
                newName: "FishTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "SurveyType",
                table: "Surveys",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "SurveyId",
                table: "Fish",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Fish",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FishType",
                columns: table => new
                {
                    FishTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FishLongName = table.Column<string>(type: "text", nullable: false),
                    FishShortName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishType", x => x.FishTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fish_FishTypeId",
                table: "Fish",
                column: "FishTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fish_FishType_FishTypeId",
                table: "Fish",
                column: "FishTypeId",
                principalTable: "FishType",
                principalColumn: "FishTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
