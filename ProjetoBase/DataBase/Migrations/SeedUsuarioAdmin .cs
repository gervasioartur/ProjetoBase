using FluentMigrator;
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
            Insert.IntoTable("USUARIO").Row(new
            {
                Login = "Admin",
                Senha = "Admin",
                Administrador = true,
                ResetarSenha = false,
                ReceberAlertas = true,
                PERFIL_DE_ACESSO_ID = 1 // Esse perfil de acessso é o Superusuario, que deve ter sido criado na migração anterior
            });
        }

        public override void Down()
        {
            Delete.FromTable("USUARIO").Row(new { Login = "Admin", PERFIL_DE_ACESSO_ID = 1 });
        }
    }
}
