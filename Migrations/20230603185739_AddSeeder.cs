using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace minimal_api_ef.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("1a9d1516-1a96-4413-8084-9fc82b28ab44"),
                column: "Create_at",
                value: new DateTime(2023, 6, 3, 18, 57, 39, 405, DateTimeKind.Utc).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("2450798d-1abd-4e84-a66c-3df24301986d"),
                column: "Create_at",
                value: new DateTime(2023, 6, 3, 18, 57, 39, 405, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("dbbf016e-758d-42d8-b8d1-347e42a0dde2"),
                column: "Create_at",
                value: new DateTime(2023, 6, 3, 18, 57, 39, 405, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("dc61a01f-237e-4f7f-8ab2-47b51d5bf3f9"),
                column: "Create_at",
                value: new DateTime(2023, 6, 3, 18, 57, 39, 405, DateTimeKind.Utc).AddTicks(3092));

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskId", "CategoryId", "Create_at", "Description", "Priority", "Titulo" },
                values: new object[,]
                {
                    { new Guid("1a848752-ec55-4f80-a7c1-3e2ad963e89e"), new Guid("dc61a01f-237e-4f7f-8ab2-47b51d5bf3f9"), new DateTime(2023, 6, 3, 18, 57, 39, 406, DateTimeKind.Utc).AddTicks(1597), "", 1, "Titulo 3" },
                    { new Guid("26cd13ec-bf25-419e-84c9-6808609f5b1e"), new Guid("dbbf016e-758d-42d8-b8d1-347e42a0dde2"), new DateTime(2023, 6, 3, 18, 57, 39, 406, DateTimeKind.Utc).AddTicks(1592), "", 0, "Titulo 2" },
                    { new Guid("a04766b0-9690-4ca5-8321-9c73cfc8f331"), new Guid("2450798d-1abd-4e84-a66c-3df24301986d"), new DateTime(2023, 6, 3, 18, 57, 39, 406, DateTimeKind.Utc).AddTicks(1577), "", 2, "Titulo 1" },
                    { new Guid("f1f86554-0df6-4e67-b8d3-3db051d4091c"), new Guid("1a9d1516-1a96-4413-8084-9fc82b28ab44"), new DateTime(2023, 6, 3, 18, 57, 39, 406, DateTimeKind.Utc).AddTicks(1602), "", 0, "Titulo 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("1a848752-ec55-4f80-a7c1-3e2ad963e89e"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("26cd13ec-bf25-419e-84c9-6808609f5b1e"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("a04766b0-9690-4ca5-8321-9c73cfc8f331"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("f1f86554-0df6-4e67-b8d3-3db051d4091c"));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("1a9d1516-1a96-4413-8084-9fc82b28ab44"),
                column: "Create_at",
                value: new DateTime(2023, 6, 3, 18, 29, 0, 222, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("2450798d-1abd-4e84-a66c-3df24301986d"),
                column: "Create_at",
                value: new DateTime(2023, 6, 3, 18, 29, 0, 222, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("dbbf016e-758d-42d8-b8d1-347e42a0dde2"),
                column: "Create_at",
                value: new DateTime(2023, 6, 3, 18, 29, 0, 222, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("dc61a01f-237e-4f7f-8ab2-47b51d5bf3f9"),
                column: "Create_at",
                value: new DateTime(2023, 6, 3, 18, 29, 0, 222, DateTimeKind.Utc).AddTicks(4428));
        }
    }
}
