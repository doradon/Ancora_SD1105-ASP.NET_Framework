using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlindDating.Migrations.BlindDating
{
    public partial class InitialDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatingProfile",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    firstName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    lastName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    age = table.Column<int>(nullable: false),
                    gender = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    bio = table.Column<string>(type: "text", nullable: false),
                    UserAccountId = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatingProfile", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatingProfile");
        }
    }
}
