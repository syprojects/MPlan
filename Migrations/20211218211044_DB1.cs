using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MPlan.Migrations
{
    public partial class DB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DBUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBUsers", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_DBUsers_DBUsers_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "DBUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DBItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    BelongsTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsersUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DBItem_DBUsers_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "DBUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DBIComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBIComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DBIComments_DBItem_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "DBItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DBIComments_DBUsers_OwnerUserId",
                        column: x => x.OwnerUserId,
                        principalTable: "DBUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DBIPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: true),
                    Point = table.Column<int>(type: "int", nullable: false),
                    VoterUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBIPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DBIPoints_DBItem_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "DBItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DBIPoints_DBUsers_VoterUserId",
                        column: x => x.VoterUserId,
                        principalTable: "DBUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DBPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanType = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPercent = table.Column<int>(type: "int", nullable: false),
                    UsageType = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: true),
                    UsersUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DBPlan_DBItem_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "DBItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DBPlan_DBUsers_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "DBUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DBPComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanId = table.Column<int>(type: "int", nullable: false),
                    PlansId = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBPComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DBPComments_DBPlan_PlansId",
                        column: x => x.PlansId,
                        principalTable: "DBPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DBPComments_DBUsers_OwnerUserId",
                        column: x => x.OwnerUserId,
                        principalTable: "DBUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DBPPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanId = table.Column<int>(type: "int", nullable: false),
                    PlansId = table.Column<int>(type: "int", nullable: true),
                    Point = table.Column<int>(type: "int", nullable: false),
                    VoterUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBPPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DBPPoints_DBPlan_PlansId",
                        column: x => x.PlansId,
                        principalTable: "DBPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DBPPoints_DBUsers_VoterUserId",
                        column: x => x.VoterUserId,
                        principalTable: "DBUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DBIComments_ItemsId",
                table: "DBIComments",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_DBIComments_OwnerUserId",
                table: "DBIComments",
                column: "OwnerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DBIPoints_ItemsId",
                table: "DBIPoints",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_DBIPoints_VoterUserId",
                table: "DBIPoints",
                column: "VoterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DBItem_UsersUserId",
                table: "DBItem",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DBPComments_OwnerUserId",
                table: "DBPComments",
                column: "OwnerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DBPComments_PlansId",
                table: "DBPComments",
                column: "PlansId");

            migrationBuilder.CreateIndex(
                name: "IX_DBPlan_ItemsId",
                table: "DBPlan",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_DBPlan_UsersUserId",
                table: "DBPlan",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DBPPoints_PlansId",
                table: "DBPPoints",
                column: "PlansId");

            migrationBuilder.CreateIndex(
                name: "IX_DBPPoints_VoterUserId",
                table: "DBPPoints",
                column: "VoterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DBUsers_UsersUserId",
                table: "DBUsers",
                column: "UsersUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DBIComments");

            migrationBuilder.DropTable(
                name: "DBIPoints");

            migrationBuilder.DropTable(
                name: "DBPComments");

            migrationBuilder.DropTable(
                name: "DBPPoints");

            migrationBuilder.DropTable(
                name: "DBPlan");

            migrationBuilder.DropTable(
                name: "DBItem");

            migrationBuilder.DropTable(
                name: "DBUsers");
        }
    }
}
