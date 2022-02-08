using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cargomanagementsystem.DAL.Migrations
{
    public partial class Trans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Details_Customer_Details_customerid",
                table: "Transaction_Details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction_Details",
                table: "Transaction_Details");

            migrationBuilder.RenameTable(
                name: "Transaction_Details",
                newName: "Transaction");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_Details_customerid",
                table: "Transaction",
                newName: "IX_Transaction_customerid");

            migrationBuilder.AlterColumn<string>(
                name: "Sending_date",
                table: "Transaction",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "Bill_no");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customer_Details_customerid",
                table: "Transaction",
                column: "customerid",
                principalTable: "Customer_Details",
                principalColumn: "Sender_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Customer_Details_customerid",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "Transaction_Details");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_customerid",
                table: "Transaction_Details",
                newName: "IX_Transaction_Details_customerid");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Sending_date",
                table: "Transaction_Details",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction_Details",
                table: "Transaction_Details",
                column: "Bill_no");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Details_Customer_Details_customerid",
                table: "Transaction_Details",
                column: "customerid",
                principalTable: "Customer_Details",
                principalColumn: "Sender_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
