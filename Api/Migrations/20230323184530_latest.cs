using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class latest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Course",
                table: "Student",
                newName: "course");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Student",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Student",
                newName: "stname");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "course",
                table: "Student",
                newName: "Course");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Student",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "stname",
                table: "Student",
                newName: "Name");
        }
    }
}
