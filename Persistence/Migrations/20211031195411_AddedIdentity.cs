using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddedIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DestinationImages_Tickets_TicketId",
                table: "DestinationImages");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "To",
                table: "Tickets",
                newName: "GoingTo");

            migrationBuilder.RenameColumn(
                name: "Returning",
                table: "Tickets",
                newName: "ReturningDate");

            migrationBuilder.RenameColumn(
                name: "Departing",
                table: "Tickets",
                newName: "DepartingDate");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "DestinationImages",
                newName: "TripId");

            migrationBuilder.RenameIndex(
                name: "IX_DestinationImages_TicketId",
                table: "DestinationImages",
                newName: "IX_DestinationImages_TripId");

            migrationBuilder.AddColumn<int>(
                name: "LeavingFromId",
                table: "Tickets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PriceId",
                table: "Tickets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Destination",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_LeavingFromId",
                table: "Tickets",
                column: "LeavingFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PriceId",
                table: "Tickets",
                column: "PriceId");

            migrationBuilder.AddForeignKey(
                name: "FK_DestinationImages_Tickets_TripId",
                table: "DestinationImages",
                column: "TripId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Currency_PriceId",
                table: "Tickets",
                column: "PriceId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Destination_LeavingFromId",
                table: "Tickets",
                column: "LeavingFromId",
                principalTable: "Destination",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DestinationImages_Tickets_TripId",
                table: "DestinationImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Currency_PriceId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Destination_LeavingFromId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "Destination");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_LeavingFromId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_PriceId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "LeavingFromId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PriceId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "ReturningDate",
                table: "Tickets",
                newName: "Returning");

            migrationBuilder.RenameColumn(
                name: "GoingTo",
                table: "Tickets",
                newName: "To");

            migrationBuilder.RenameColumn(
                name: "DepartingDate",
                table: "Tickets",
                newName: "Departing");

            migrationBuilder.RenameColumn(
                name: "TripId",
                table: "DestinationImages",
                newName: "TicketId");

            migrationBuilder.RenameIndex(
                name: "IX_DestinationImages_TripId",
                table: "DestinationImages",
                newName: "IX_DestinationImages_TicketId");

            migrationBuilder.AddColumn<string>(
                name: "From",
                table: "Tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DestinationImages_Tickets_TicketId",
                table: "DestinationImages",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
