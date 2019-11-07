using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bodhi.XYLib.Migrations
{
    public partial class add_Libray_bookinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodhiLibary",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    LibName = table.Column<string>(maxLength: 100, nullable: true),
                    LibAddress = table.Column<string>(nullable: true),
                    Share = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodhiLibary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodhiBookInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    LibaryId = table.Column<long>(nullable: true),
                    ISBN = table.Column<string>(maxLength: 100, nullable: true),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Owner = table.Column<string>(maxLength: 100, nullable: true),
                    Count = table.Column<int>(nullable: false),
                    Publisher = table.Column<string>(maxLength: 200, nullable: true),
                    Place = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodhiBookInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodhiBookInfo_BodhiLibary_LibaryId",
                        column: x => x.LibaryId,
                        principalTable: "BodhiLibary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BodhiBookInfo_LibaryId",
                table: "BodhiBookInfo",
                column: "LibaryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodhiBookInfo");

            migrationBuilder.DropTable(
                name: "BodhiLibary");
        }
    }
}
