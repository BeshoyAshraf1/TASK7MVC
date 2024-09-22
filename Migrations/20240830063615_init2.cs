using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace task3.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Degree", "MinDegree", "Name" },
                values: new object[,]
                {
                    { 1, 100.0, 60.0, "Introduction to Programming" },
                    { 2, 100.0, 70.0, "Advanced Mathematics" },
                    { 3, 100.0, 75.0, "Quantum Physics" },
                    { 4, 100.0, 65.0, "Organic Chemistry" },
                    { 5, 100.0, 80.0, "Genetics" }
                });

            migrationBuilder.InsertData(
                table: "Depratments",
                columns: new[] { "id", "managername", "name" },
                values: new object[,]
                {
                    { 1, "John Doe", "Computer Science" },
                    { 2, "Jane Smith", "Mathematics" },
                    { 3, "Albert Einstein", "Physics" },
                    { 4, "Marie Curie", "Chemistry" },
                    { 5, "Charles Darwin", "Biology" }
                });

            migrationBuilder.InsertData(
                table: "trainees",
                columns: new[] { "Id", "Grade", "Name", "address", "image" },
                values: new object[,]
                {
                    { 1, 85.5, "Tom Brown", "123 Maple St", "tom.jpg" },
                    { 2, 90.0, "Sarah Green", "456 Oak St", "sarah.jpg" },
                    { 3, 88.0, "James Blue", "789 Pine St", "james.jpg" },
                    { 4, 92.5, "Emma White", "101 Elm St", "emma.jpg" },
                    { 5, 87.0, "Liam Black", "202 Main St", "liam.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Courseresults",
                columns: new[] { "Id", "CourseId", "Degree", "traineeId" },
                values: new object[,]
                {
                    { 1, 1, 95.0, 1 },
                    { 2, 2, 88.0, 2 },
                    { 3, 3, 92.0, 3 },
                    { 4, 4, 85.0, 4 },
                    { 5, 5, 90.0, 5 }
                });

            migrationBuilder.InsertData(
                table: "Instractors",
                columns: new[] { "Id", "CourseId", "DepratmentId", "Name", "Salary", "address", "image" },
                values: new object[,]
                {
                    { 1, 1, 1, "Alice Johnson", 50000, "123 Main St", "alice.jpg" },
                    { 2, 2, 2, "Bob Lee", 55000, "456 Elm St", "bob.jpg" },
                    { 3, 3, 3, "Charlie Brown", 60000, "789 Pine St", "charlie.jpg" },
                    { 4, 4, 4, "Diana Prince", 62000, "101 Oak St", "diana.jpg" },
                    { 5, 5, 5, "Eve Adams", 65000, "202 Maple St", "eve.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courseresults",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courseresults",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courseresults",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courseresults",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courseresults",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instractors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Depratments",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Depratments",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Depratments",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Depratments",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Depratments",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "trainees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "trainees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "trainees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "trainees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "trainees",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
