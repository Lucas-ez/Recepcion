using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recepcion.Migrations
{
    /// <inheritdoc />
    public partial class CreationDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingreso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteDni = table.Column<int>(type: "int", nullable: false),
                    ClienteNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingreso", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingreso");
        }
    }
}
