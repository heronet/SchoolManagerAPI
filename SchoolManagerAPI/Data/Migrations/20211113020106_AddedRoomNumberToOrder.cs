using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagerApi.Data.Migrations
{
    public partial class AddedRoomNumberToOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomNumber",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomNumber",
                table: "Orders");
        }
    }
}
