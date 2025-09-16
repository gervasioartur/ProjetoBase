using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoBase.DataBase.Migrations
{
    [Migration(202509151601)]
    public class SeedPerfilDeAcessoSuperUsuario : Migration
    {        public override void Up()
        {
            Insert.IntoTable("PERFIL_DE_ACESSO").Row(new
            {
                Nome = "SUPERUSUARIO",
            });
        }

        public override void Down()
        {
            Delete.FromTable("PERFIL_DE_ACESSO").Row(new { Nome = "SUPERUSUARIO" });
        }
    }
}
