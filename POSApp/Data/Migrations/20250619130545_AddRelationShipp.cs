using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationShipp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CityId",
                table: "Clients",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Cities_CityId",
                table: "Clients",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Cities_CityId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_CityId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Clients");
        }
    }
}
