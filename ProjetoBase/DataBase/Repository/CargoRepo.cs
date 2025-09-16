using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.DataBase.Ferramentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase.Repository
{
    public class CargoRepo : Repositorio<Cargo>
    {
        public CargoRepo() { }

        public Cargo ProcurarPorNome(String nome)
        {  
            return getLista().Where(c => c.Nome.ToUpper() == nome.ToUpper()).FirstOrDefault();
        }

        // Pega o valor que realmente esta no banco sem ser o cacheado
        public Cargo ProcurarPorId(int id)
        {
            var cargo = getSessao(false).Get<Cargo>(id);
            if (cargo != null) Refresh(cargo);
            return cargo;
        }
    }
}
