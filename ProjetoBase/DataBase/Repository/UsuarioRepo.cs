using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.DataBase.Ferramentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase.DataBase.Repository
{
    public class UsuarioRepo : Repositorio<Usuario>
    {

        public Usuario ProcurarPorLogin(String login) {
            return getLista().Where(u => u.Login == login.ToUpper()).FirstOrDefault();
        }
    }
}
