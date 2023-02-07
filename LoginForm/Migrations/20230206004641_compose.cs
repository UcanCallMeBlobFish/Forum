using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LoginForm.Migrations
{
    /// <inheritdoc />
    public partial class compose : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Lik",
                table: "Lik");

            migrationBuilder.DeleteData(
                table: "Lik",
                keyColumn: "LikedBy",
                keyValue: "Root");

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

            migrationBuilder.AlterColumn<string>(
                name: "LikedBy",
                table: "Lik",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "CompositeKey",
                table: "Lik",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lik",
                table: "Lik",
                column: "CompositeKey");

            migrationBuilder.InsertData(
                table: "Lik",
                columns: new[] { "CompositeKey", "LikedBy", "PostId" },
                values: new object[] { "Post1Root", "Root", "Post1" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post1",
                column: "PostDate",
                value: new DateTime(2023, 2, 6, 4, 46, 41, 89, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post2",
                column: "PostDate",
                value: new DateTime(2023, 2, 6, 4, 46, 41, 89, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post3",
                column: "PostDate",
                value: new DateTime(2023, 2, 6, 4, 46, 41, 89, DateTimeKind.Local).AddTicks(1700));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Lik",
                table: "Lik");

            migrationBuilder.DeleteData(
                table: "Lik",
                keyColumn: "CompositeKey",
                keyColumnType: "nvarchar(450)",
                keyValue: "Post1Root");

            migrationBuilder.DropColumn(
                name: "CompositeKey",
                table: "Lik");

            migrationBuilder.AlterColumn<string>(
                name: "LikedBy",
                table: "Lik",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lik",
                table: "Lik",
                column: "LikedBy");

            migrationBuilder.InsertData(
                table: "Lik",
                columns: new[] { "LikedBy", "PostId" },
                values: new object[,]
                {
                    { "Root", "Post1" },
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
    }
}
