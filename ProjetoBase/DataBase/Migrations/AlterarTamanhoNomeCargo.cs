using FluentNHibernate.MappingModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentMigrator;
using System.Linq;
using System.Text;
using System;


namespace ProjetoBase.DataBase.Migrations
{
    [Migration(202509151600)] 
    public class AlterarTamanhoNomeCargo : Migration
    {
        public override void Up()
        {
            Alter.Column("Nome")
                .OnTable("Cargo")
                .AsString(255)
                .NotNullable();
        }

        public override void Down()
        {
            Alter.Column("Nome")
                .OnTable("Cargo")
                .AsString(10)
                .NotNullable();
        }
    }
}
