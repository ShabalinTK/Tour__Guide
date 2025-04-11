using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Tour_Guide_Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Theme = table.Column<string>(type: "text", nullable: false),
                    Reviews = table.Column<int>(type: "integer", nullable: false),
                    ImageUrls = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Activities = table.Column<string>(type: "text", nullable: false),
                    Includes = table.Column<string>(type: "text", nullable: false),
                    NotIncludes = table.Column<string>(type: "text", nullable: false),
                    Safety = table.Column<string>(type: "text", nullable: false),
                    Languages = table.Column<string>(type: "text", nullable: false),
                    Duration = table.Column<string>(type: "text", nullable: false),
                    NumberOfPeople = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tours");
        }
    }
}
