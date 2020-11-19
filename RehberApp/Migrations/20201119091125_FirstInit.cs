using Microsoft.EntityFrameworkCore.Migrations;

namespace RehberApp.Migrations
{
    public partial class FirstInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "rehbers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    internalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shortNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shortCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isManager = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rehbers", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_rehbers_id",
                table: "rehbers",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rehbers");
        }
    }
}
