using Microsoft.EntityFrameworkCore.Migrations;

namespace MPlan.Migrations
{
    public partial class plan_adi_eklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "DBPlan",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "DBPlan");
        }
    }
}
