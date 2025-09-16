using FluentMigrator;
using Microsoft.Identity.Client;
using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.DataBase.Ferramentas;
using ProjetoBase.DataBase.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase.DataBase.Migrations
{
    [Migration(2025091602)]
    public class SeedUsuarioAdmin : Migration
    {
        public override void Up()
        {
            string senhaHash = BCrypt.Net.BCrypt.HashPassword("ADMIN");

            Insert.IntoTable("USUARIO").Row(new
            {

                Login = "ADMIN",
                Senha = senhaHash,
                Administrador = true,
                ResetarSenha = false,
                ReceberAlertas = true,
            });
        }

        public override void Down()
        {
            Delete.FromTable("USUARIO").Row(new { Login = "Admin", PERFIL_DE_ACESSO_ID = 1 });
        }
    }
}
