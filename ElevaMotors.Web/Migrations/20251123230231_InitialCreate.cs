using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElevaMotors.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Chassi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ValorCompra = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorVenda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustoTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EhConsignado = table.Column<bool>(type: "bit", nullable: false),
                    EhParceria = table.Column<bool>(type: "bit", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataVenda = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
