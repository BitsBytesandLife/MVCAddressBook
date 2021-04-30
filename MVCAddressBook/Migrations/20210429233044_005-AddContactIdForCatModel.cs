using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCAddressBook.Migrations
{
    public partial class _005AddContactIdForCatModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Contact_ContactId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_ContactId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CategoryId",
                table: "Contact",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Category_CategoryId",
                table: "Contact",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Category_CategoryId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_CategoryId",
                table: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Category",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Category_ContactId",
                table: "Category",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Contact_ContactId",
                table: "Category",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
