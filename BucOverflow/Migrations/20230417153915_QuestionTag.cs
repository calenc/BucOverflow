using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BucOverflow.Migrations
{
    /// <inheritdoc />
    public partial class QuestionTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "Questions",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tag",
                table: "Questions");
        }
    }
}
