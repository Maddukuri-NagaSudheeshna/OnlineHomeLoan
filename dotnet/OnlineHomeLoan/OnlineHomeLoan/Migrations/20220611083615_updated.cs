using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineHomeLoan.Migrations
{
    public partial class updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "AdminLogin",
                newName: "AdminPassword");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "AdminLogin",
                newName: "AdminEmailID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdminPassword",
                table: "AdminLogin",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "AdminEmailID",
                table: "AdminLogin",
                newName: "Password");
        }
    }
}
