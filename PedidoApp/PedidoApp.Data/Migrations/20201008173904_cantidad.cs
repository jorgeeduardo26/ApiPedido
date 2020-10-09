using Microsoft.EntityFrameworkCore.Migrations;

namespace PedidoApp.Data.Migrations
{
    public partial class cantidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "PedidoProducto",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "PedidoProducto");
        }
    }
}
