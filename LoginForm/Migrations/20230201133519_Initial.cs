using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LoginForm.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecoveryEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Email);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Email", "Name", "Password", "RecoveryEmail" },
                values: new object[,]
                {
                    { "Root@Root1", "Root", "Root", "Root@Root1" },
                    { "Root@Root2", "Root2", "Root", "Root@Root2" },
                    { "Root@Root3", "Root3", "Root", "Root@Root3" },
                    { "Root@Root4", "Root4", "Root", "Root@Root4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
