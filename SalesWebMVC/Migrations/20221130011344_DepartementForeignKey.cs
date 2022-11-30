using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMVC.Migrations
{
    public partial class DepartementForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departement_DepartementId",
                table: "Seller");

            migrationBuilder.AlterColumn<int>(
                name: "DepartementId",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departement_DepartementId",
                table: "Seller",
                column: "DepartementId",
                principalTable: "Departement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departement_DepartementId",
                table: "Seller");

            migrationBuilder.AlterColumn<int>(
                name: "DepartementId",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departement_DepartementId",
                table: "Seller",
                column: "DepartementId",
                principalTable: "Departement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
