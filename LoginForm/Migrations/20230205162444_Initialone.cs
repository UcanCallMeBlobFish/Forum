using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LoginForm.Migrations
{
    /// <inheritdoc />
    public partial class Initialone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Likes", "PostDate", "Text", "UserEmail" },
                values: new object[,]
                {
                    { "Post1", 5, new DateTime(2023, 2, 5, 20, 24, 44, 595, DateTimeKind.Local).AddTicks(2256), "Example post 1", "user1@example.com" },
                    { "Post2", 3, new DateTime(2023, 2, 5, 20, 24, 44, 595, DateTimeKind.Local).AddTicks(2268), "Example post 2", "user2@example.com" },
                    { "Post3", 10, new DateTime(2023, 2, 5, 20, 24, 44, 595, DateTimeKind.Local).AddTicks(2270), "Example post 3", "user3@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
