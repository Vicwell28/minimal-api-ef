using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace minimal_api_ef.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDescNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Task",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Create_at", "Description", "Name", "Peso" },
                values: new object[,]
                {
                    { new Guid("1a9d1516-1a96-4413-8084-9fc82b28ab44"), new DateTime(2023, 6, 3, 18, 29, 0, 222, DateTimeKind.Utc).AddTicks(4431), "", "Personales", 20 },
                    { new Guid("2450798d-1abd-4e84-a66c-3df24301986d"), new DateTime(2023, 6, 3, 18, 29, 0, 222, DateTimeKind.Utc).AddTicks(4417), "", "Personales", 20 },
                    { new Guid("dbbf016e-758d-42d8-b8d1-347e42a0dde2"), new DateTime(2023, 6, 3, 18, 29, 0, 222, DateTimeKind.Utc).AddTicks(4425), "", "Personales", 20 },
                    { new Guid("dc61a01f-237e-4f7f-8ab2-47b51d5bf3f9"), new DateTime(2023, 6, 3, 18, 29, 0, 222, DateTimeKind.Utc).AddTicks(4428), "", "Personales", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("1a9d1516-1a96-4413-8084-9fc82b28ab44"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("2450798d-1abd-4e84-a66c-3df24301986d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("dbbf016e-758d-42d8-b8d1-347e42a0dde2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("dc61a01f-237e-4f7f-8ab2-47b51d5bf3f9"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Task",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
