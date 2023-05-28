using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BucOverflow.Migrations
{
    /// <inheritdoc />
    public partial class QuestionDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateAsked",
                table: "Questions",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAsked",
                table: "Questions");
        }
    }
}
