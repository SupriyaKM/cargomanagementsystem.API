using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cargomanagementsystem.DAL.Migrations
{
    public partial class addMigratonTransction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transaction_Details",
                columns: table => new
                {
                    Bill_no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerid = table.Column<int>(type: "int", nullable: false),
                    Type_of_Goods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Goods_Qty = table.Column<int>(type: "int", nullable: false),
                    Trans_amount = table.Column<int>(type: "int", nullable: false),
                    Sending_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction_Details", x => x.Bill_no);
                    table.ForeignKey(
                        name: "FK_Transaction_Details_Customer_Details_customerid",
                        column: x => x.customerid,
                        principalTable: "Customer_Details",
                        principalColumn: "Sender_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_Details_customerid",
                table: "Transaction_Details",
                column: "customerid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction_Details");
        }
    }
}
