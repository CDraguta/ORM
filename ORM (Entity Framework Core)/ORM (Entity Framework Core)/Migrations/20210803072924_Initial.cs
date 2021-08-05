using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ORM__Entity_Framework_Core_.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departament",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    denumire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_adaugare = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_modificare = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departament", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sector",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    denumire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cod_postal = table.Column<int>(type: "int", nullable: true),
                    data_adaugare = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_modificare = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sector", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Proiect",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_departament = table.Column<int>(type: "int", nullable: false),
                    nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_incepere = table.Column<DateTime>(type: "datetime2", nullable: true),
                    buget = table.Column<int>(type: "int", nullable: true),
                    termen_limita = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_adaugare = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_modificare = table.Column<DateTime>(type: "datetime2", nullable: true),
                    departamentid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proiect", x => x.id);
                    table.ForeignKey(
                        name: "FK_Proiect_Departament_departamentid",
                        column: x => x.departamentid,
                        principalTable: "Departament",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Angajat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_departament = table.Column<int>(type: "int", nullable: false),
                    id_sector = table.Column<int>(type: "int", nullable: false),
                    nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numar = table.Column<int>(type: "int", nullable: false),
                    sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_nastere = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_angajare = table.Column<DateTime>(type: "datetime2", nullable: true),
                    salariu = table.Column<int>(type: "int", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_adaugare = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_modificare = table.Column<DateTime>(type: "datetime2", nullable: true),
                    departamentid = table.Column<int>(type: "int", nullable: true),
                    sectorid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Angajat", x => x.id);
                    table.ForeignKey(
                        name: "FK_Angajat_Departament_departamentid",
                        column: x => x.departamentid,
                        principalTable: "Departament",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Angajat_Sector_sectorid",
                        column: x => x.sectorid,
                        principalTable: "Sector",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AngajatProiect",
                columns: table => new
                {
                    id_angajat = table.Column<int>(type: "int", nullable: false),
                    id_proiect = table.Column<int>(type: "int", nullable: false),
                    nr_ore_saptamana = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    data_adaugare = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_modificare = table.Column<DateTime>(type: "datetime2", nullable: true),
                    angajatid = table.Column<int>(type: "int", nullable: true),
                    proiectid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AngajatProiect", x => new { x.id_angajat, x.id_proiect });
                    table.ForeignKey(
                        name: "FK_AngajatProiect_Angajat_angajatid",
                        column: x => x.angajatid,
                        principalTable: "Angajat",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AngajatProiect_Proiect_proiectid",
                        column: x => x.proiectid,
                        principalTable: "Proiect",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartenerAngajat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_angajat = table.Column<int>(type: "int", nullable: true),
                    data_adaugare = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_modificare = table.Column<DateTime>(type: "datetime2", nullable: true),
                    angajatid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartenerAngajat", x => x.id);
                    table.ForeignKey(
                        name: "FK_PartenerAngajat_Angajat_angajatid",
                        column: x => x.angajatid,
                        principalTable: "Angajat",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Angajat_departamentid",
                table: "Angajat",
                column: "departamentid");

            migrationBuilder.CreateIndex(
                name: "IX_Angajat_sectorid",
                table: "Angajat",
                column: "sectorid");

            migrationBuilder.CreateIndex(
                name: "IX_AngajatProiect_angajatid",
                table: "AngajatProiect",
                column: "angajatid");

            migrationBuilder.CreateIndex(
                name: "IX_AngajatProiect_proiectid",
                table: "AngajatProiect",
                column: "proiectid");

            migrationBuilder.CreateIndex(
                name: "IX_PartenerAngajat_angajatid",
                table: "PartenerAngajat",
                column: "angajatid");

            migrationBuilder.CreateIndex(
                name: "IX_Proiect_departamentid",
                table: "Proiect",
                column: "departamentid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AngajatProiect");

            migrationBuilder.DropTable(
                name: "PartenerAngajat");

            migrationBuilder.DropTable(
                name: "Proiect");

            migrationBuilder.DropTable(
                name: "Angajat");

            migrationBuilder.DropTable(
                name: "Departament");

            migrationBuilder.DropTable(
                name: "Sector");
        }
    }
}
