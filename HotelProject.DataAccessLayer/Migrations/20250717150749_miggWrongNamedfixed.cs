using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class miggWrongNamedfixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ckeckout",
                table: "Bookings",
                newName: "Checkout");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Checkout",
                table: "Bookings",
                newName: "Ckeckout");
        }
    }
}
