using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstEfCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class AddOperatorsAndWorkStationsManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Operators",
                columns: table => new
                {
                    OperatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shift = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.OperatorId);
                });

            migrationBuilder.CreateTable(
                name: "WorkStations",
                columns: table => new
                {
                    WorkStationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkStations", x => x.WorkStationId);
                });

            migrationBuilder.CreateTable(
                name: "OperatorWorkStation",
                columns: table => new
                {
                    OperatorsOperatorId = table.Column<int>(type: "int", nullable: false),
                    WorkStationsWorkStationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatorWorkStation", x => new { x.OperatorsOperatorId, x.WorkStationsWorkStationId });
                    table.ForeignKey(
                        name: "FK_OperatorWorkStation_Operators_OperatorsOperatorId",
                        column: x => x.OperatorsOperatorId,
                        principalTable: "Operators",
                        principalColumn: "OperatorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperatorWorkStation_WorkStations_WorkStationsWorkStationId",
                        column: x => x.WorkStationsWorkStationId,
                        principalTable: "WorkStations",
                        principalColumn: "WorkStationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OperatorWorkStation_WorkStationsWorkStationId",
                table: "OperatorWorkStation",
                column: "WorkStationsWorkStationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperatorWorkStation");

            migrationBuilder.DropTable(
                name: "Operators");

            migrationBuilder.DropTable(
                name: "WorkStations");
        }
    }
}
