using Microsoft.EntityFrameworkCore.Migrations;

namespace MPlan.Migrations
{
    public partial class plan_adi_degisti1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DBPlan_DBItem_ItemsId",
                table: "DBPlan");

            migrationBuilder.DropIndex(
                name: "IX_DBPlan_ItemsId",
                table: "DBPlan");

            migrationBuilder.DropColumn(
                name: "ItemsId",
                table: "DBPlan");

            migrationBuilder.CreateTable(
                name: "ItemsPlans",
                columns: table => new
                {
                    Items1Id = table.Column<int>(type: "int", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsPlans", x => new { x.Items1Id, x.PlanId });
                    table.ForeignKey(
                        name: "FK_ItemsPlans_DBItem_Items1Id",
                        column: x => x.Items1Id,
                        principalTable: "DBItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemsPlans_DBPlan_PlanId",
                        column: x => x.PlanId,
                        principalTable: "DBPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsPlans_PlanId",
                table: "ItemsPlans",
                column: "PlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsPlans");

            migrationBuilder.AddColumn<int>(
                name: "ItemsId",
                table: "DBPlan",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DBPlan_ItemsId",
                table: "DBPlan",
                column: "ItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_DBPlan_DBItem_ItemsId",
                table: "DBPlan",
                column: "ItemsId",
                principalTable: "DBItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
