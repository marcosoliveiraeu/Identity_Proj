﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcWebIdentity.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    AlunoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Curso = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.AlunoID);
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "AlunoID", "Curso", "Email", "Idade", "Nome" },
                values: new object[] { 1, "Química", "marcosoliveiraeu@gmail.com", 41, "Marcos" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
