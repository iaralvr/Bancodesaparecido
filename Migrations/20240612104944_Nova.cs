using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoApi.Migrations
{
    /// <inheritdoc />
    public partial class Nova : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioSenha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaRoupa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaCor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaSexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaObservacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaLocalDesaparecimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaDtDesaparecimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PessoaDtEncontro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PessoaStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.PessoaId);
                    table.ForeignKey(
                        name: "FK_Pessoa_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Observacao",
                columns: table => new
                {
                    ObservacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObservacaoDescricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservacaoLocal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservacaoData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observacao", x => x.ObservacaoId);
                    table.ForeignKey(
                        name: "FK_Observacao_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId");
                    table.ForeignKey(
                        name: "FK_Observacao_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Observacao_PessoaId",
                table: "Observacao",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Observacao_UsuarioId",
                table: "Observacao",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_UsuarioId",
                table: "Pessoa",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Observacao");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
