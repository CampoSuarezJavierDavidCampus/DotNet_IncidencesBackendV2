using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "genero",
                columns: table => new
                {
                    idGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombreGenero = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genero", x => x.idGenero);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    idPais = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombrePais = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pais", x => x.idPais);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "salon",
                columns: table => new
                {
                    idSalon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombreSalon = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    capasidadSalon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salon", x => x.idSalon);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipoPersona",
                columns: table => new
                {
                    idTipoPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcionTipoPersona = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoPersona", x => x.idTipoPersona);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "departamento",
                columns: table => new
                {
                    idDep = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombreDep = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idPaisFk = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamento", x => x.idDep);
                    table.ForeignKey(
                        name: "FK_departamento_pais_idPaisFk",
                        column: x => x.idPaisFk,
                        principalTable: "pais",
                        principalColumn: "idPais",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ciudad",
                columns: table => new
                {
                    idCiudad = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombreCiudad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idDepFk = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciudad", x => x.idCiudad);
                    table.ForeignKey(
                        name: "FK_ciudad_departamento_idDepFk",
                        column: x => x.idDepFk,
                        principalTable: "departamento",
                        principalColumn: "idDep",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    idPersona = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombrePersona = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGeneroFk = table.Column<int>(type: "int", nullable: false),
                    idCiudadFk = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    idTipoPersonaFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persona", x => x.idPersona);
                    table.ForeignKey(
                        name: "FK_persona_ciudad_idCiudadFk",
                        column: x => x.idCiudadFk,
                        principalTable: "ciudad",
                        principalColumn: "idCiudad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_persona_genero_idGeneroFk",
                        column: x => x.idGeneroFk,
                        principalTable: "genero",
                        principalColumn: "idGenero",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_persona_tipoPersona_idTipoPersonaFk",
                        column: x => x.idTipoPersonaFk,
                        principalTable: "tipoPersona",
                        principalColumn: "idTipoPersona",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "matricula",
                columns: table => new
                {
                    idMatricula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idPersonaFk = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idSalonFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_matricula", x => x.idMatricula);
                    table.ForeignKey(
                        name: "FK_matricula_persona_idPersonaFk",
                        column: x => x.idPersonaFk,
                        principalTable: "persona",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_matricula_salon_idSalonFk",
                        column: x => x.idSalonFk,
                        principalTable: "salon",
                        principalColumn: "idSalon",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "trainerSalon",
                columns: table => new
                {
                    idPerTrainerFk = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idSalonFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainerSalon", x => new { x.idSalonFk, x.idPerTrainerFk });
                    table.ForeignKey(
                        name: "FK_trainerSalon_persona_idPerTrainerFk",
                        column: x => x.idPerTrainerFk,
                        principalTable: "persona",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trainerSalon_salon_idSalonFk",
                        column: x => x.idSalonFk,
                        principalTable: "salon",
                        principalColumn: "idSalon",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ciudad_idDepFk",
                table: "ciudad",
                column: "idDepFk");

            migrationBuilder.CreateIndex(
                name: "IX_departamento_idPaisFk",
                table: "departamento",
                column: "idPaisFk");

            migrationBuilder.CreateIndex(
                name: "IX_matricula_idPersonaFk",
                table: "matricula",
                column: "idPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_matricula_idSalonFk",
                table: "matricula",
                column: "idSalonFk");

            migrationBuilder.CreateIndex(
                name: "IX_persona_idCiudadFk",
                table: "persona",
                column: "idCiudadFk");

            migrationBuilder.CreateIndex(
                name: "IX_persona_idGeneroFk",
                table: "persona",
                column: "idGeneroFk");

            migrationBuilder.CreateIndex(
                name: "IX_persona_idTipoPersonaFk",
                table: "persona",
                column: "idTipoPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_trainerSalon_idPerTrainerFk",
                table: "trainerSalon",
                column: "idPerTrainerFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "matricula");

            migrationBuilder.DropTable(
                name: "trainerSalon");

            migrationBuilder.DropTable(
                name: "persona");

            migrationBuilder.DropTable(
                name: "salon");

            migrationBuilder.DropTable(
                name: "ciudad");

            migrationBuilder.DropTable(
                name: "genero");

            migrationBuilder.DropTable(
                name: "tipoPersona");

            migrationBuilder.DropTable(
                name: "departamento");

            migrationBuilder.DropTable(
                name: "pais");
        }
    }
}
