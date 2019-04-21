using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksList.Migrations
{
    public partial class ChangeAuthorFieldTypeInBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Book",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Author",
                table: "Book",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
