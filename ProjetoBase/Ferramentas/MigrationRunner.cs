using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using ProjetoBase.DataBase.Migrations;


namespace ProjetoBase.Ferramentas
{
    public class MigrationRunner
    {
        public static void ApplyMigrations(string connectionString)
        {
            var serviceProvider = new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer() 
                    .WithGlobalConnectionString(connectionString)
                    .ScanIn(typeof(AlterarTamanhoNomeCargo).Assembly).For.Migrations()
                )
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);

            using (var scope = serviceProvider.CreateScope())
            {
                var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
                runner.MigrateUp();
            }
        }
    }
}
