using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoWebApi.Migrations
{
    public partial class initializingdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    todo = table.Column<string>(maxLength: 50, nullable: false),
                    isCompleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "id", "isCompleted", "todo" },
                values: new object[,]
                {
                    { 1, false, "do the laundry" },
                    { 2, false, "read a novel" },
                    { 3, false, "play game" },
                    { 4, false, "visit a friend" },
                    { 5, false, "write code" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");
        }
    }
}
