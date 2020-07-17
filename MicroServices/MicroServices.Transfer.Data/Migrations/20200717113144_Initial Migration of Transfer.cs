using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroServices.Transfer.Data.Migrations {
    public partial class InitialMigrationofTransfer : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "TransferLogs",
                columns: table => new {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountFrom = table.Column<int>(nullable: false),
                    AccountTo = table.Column<int>(nullable: false),
                    TransferAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_TransferLogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "TransferLogs");
        }
    }
}
