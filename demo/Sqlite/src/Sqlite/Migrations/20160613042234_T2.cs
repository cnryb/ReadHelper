using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sqlite.Migrations
{
    public partial class T2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T2",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    Name2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T2", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T2");
        }
    }
}
