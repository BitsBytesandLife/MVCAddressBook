﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCAddressBook.Migrations
{
    public partial class _003AddedCategoryIdOnContactModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Contact",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Contact");
        }
    }
}
