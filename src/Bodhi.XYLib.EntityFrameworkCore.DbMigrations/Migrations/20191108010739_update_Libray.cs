using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bodhi.XYLib.Migrations
{
    public partial class update_Libray : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "BodhiLibary");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "BodhiLibary");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BodhiLibary");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "BodhiLibary");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "BodhiLibary");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "BodhiBookInfo");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "BodhiBookInfo");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BodhiBookInfo");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "BodhiBookInfo");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "BodhiBookInfo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "BodhiLibary",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "BodhiLibary",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BodhiLibary",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "BodhiLibary",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "BodhiLibary",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "BodhiBookInfo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "BodhiBookInfo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BodhiBookInfo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "BodhiBookInfo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "BodhiBookInfo",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
