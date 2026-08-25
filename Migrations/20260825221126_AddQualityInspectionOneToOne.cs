using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstEfCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class AddQualityInspectionOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QualityInspection",
                columns: table => new
                {
                    QualityInspectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InspectorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassedInspection = table.Column<bool>(type: "bit", nullable: false),
                    InspectionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkOrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualityInspection", x => x.QualityInspectionId);
                    table.ForeignKey(
                        name: "FK_QualityInspection_WorkOrders_WorkOrderId",
                        column: x => x.WorkOrderId,
                        principalTable: "WorkOrders",
                        principalColumn: "WorkOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QualityInspection_WorkOrderId",
                table: "QualityInspection",
                column: "WorkOrderId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QualityInspection");
        }
    }
}
