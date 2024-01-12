using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect.Migrations
{
    /// <inheritdoc />
    public partial class ProprAnimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProprietarID",
                table: "Animal",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Animal_ProprietarID",
                table: "Animal",
                column: "ProprietarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Proprietar_ProprietarID",
                table: "Animal",
                column: "ProprietarID",
                principalTable: "Proprietar",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Proprietar_ProprietarID",
                table: "Animal");

            migrationBuilder.DropIndex(
                name: "IX_Animal_ProprietarID",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "ProprietarID",
                table: "Animal");
        }
    }
}
