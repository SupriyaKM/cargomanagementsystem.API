using Microsoft.EntityFrameworkCore.Migrations;

namespace cargomanagementsystem.DAL.Migrations
{
    public partial class CargoCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer_Details",
                columns: table => new
                {
                    Sender_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sender_mobno = table.Column<int>(type: "int", nullable: false),
                    Sender_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sender_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sender_pincode = table.Column<int>(type: "int", nullable: false),
                    Receiver_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receiver_id = table.Column<int>(type: "int", nullable: false),
                    Receiver_mobno = table.Column<int>(type: "int", nullable: false),
                    Receiver_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receiver_city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receiver_pincode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Details", x => x.Sender_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer_Details");
        }
    }
}
