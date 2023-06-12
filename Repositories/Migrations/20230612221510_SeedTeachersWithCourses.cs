using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class SeedTeachersWithCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTeacher_Course_CoursesCourseId",
                table: "CourseTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTeacher_Teachers_TeachersTeacherId",
                table: "CourseTeacher");

            migrationBuilder.RenameColumn(
                name: "TeachersTeacherId",
                table: "CourseTeacher",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "CoursesCourseId",
                table: "CourseTeacher",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseTeacher_TeachersTeacherId",
                table: "CourseTeacher",
                newName: "IX_CourseTeacher_TeacherId");

            migrationBuilder.InsertData(
                table: "CourseTeacher",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTeacher_Course_CourseId",
                table: "CourseTeacher",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTeacher_Teachers_TeacherId",
                table: "CourseTeacher",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTeacher_Course_CourseId",
                table: "CourseTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTeacher_Teachers_TeacherId",
                table: "CourseTeacher");

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "CourseTeacher",
                newName: "TeachersTeacherId");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "CourseTeacher",
                newName: "CoursesCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseTeacher_TeacherId",
                table: "CourseTeacher",
                newName: "IX_CourseTeacher_TeachersTeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTeacher_Course_CoursesCourseId",
                table: "CourseTeacher",
                column: "CoursesCourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTeacher_Teachers_TeachersTeacherId",
                table: "CourseTeacher",
                column: "TeachersTeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
