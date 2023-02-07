using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LoginForm.Migrations
{
    /// <inheritdoc />
    public partial class lklk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lik",
                columns: new[] { "LikedBy", "PostId" },
                values: new object[,]
                {
                    { "Root2", "Post1" },
                    { "Root3", "Post1" },
                    { "Root4", "Post1" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post1",
                column: "PostDate",
                value: new DateTime(2023, 2, 6, 4, 16, 27, 679, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post2",
                column: "PostDate",
                value: new DateTime(2023, 2, 6, 4, 16, 27, 679, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post3",
                column: "PostDate",
                value: new DateTime(2023, 2, 6, 4, 16, 27, 679, DateTimeKind.Local).AddTicks(2532));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lik",
                keyColumn: "LikedBy",
                keyValue: "Root2");

            migrationBuilder.DeleteData(
                table: "Lik",
                keyColumn: "LikedBy",
                keyValue: "Root3");

            migrationBuilder.DeleteData(
                table: "Lik",
                keyColumn: "LikedBy",
                keyValue: "Root4");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post1",
                column: "PostDate",
                value: new DateTime(2023, 2, 6, 4, 10, 18, 142, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post2",
                column: "PostDate",
                value: new DateTime(2023, 2, 6, 4, 10, 18, 142, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post3",
                column: "PostDate",
                value: new DateTime(2023, 2, 6, 4, 10, 18, 142, DateTimeKind.Local).AddTicks(3429));
        }
    }
}
