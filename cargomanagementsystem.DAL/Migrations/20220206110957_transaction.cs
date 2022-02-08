using Microsoft.EntityFrameworkCore.Migrations;

namespace cargomanagementsystem.DAL.Migrations
{
    public partial class transaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Confirmpassword",
                table: "Register",
                newName: "ConfirmPassword");

            migrationBuilder.RenameColumn(
                name: "Custpassword",
                table: "Register",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Custname",
                table: "Register",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CustEmailid",
                table: "Register",
                newName: "Emailid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ConfirmPassword",
                table: "Register",
                newName: "Confirmpassword");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Register",
                newName: "Custpassword");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Register",
                newName: "Custname");

            migrationBuilder.RenameColumn(
                name: "Emailid",
                table: "Register",
                newName: "CustEmailid");
        }
    }
}
