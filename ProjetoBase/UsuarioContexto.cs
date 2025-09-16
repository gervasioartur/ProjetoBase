using ProjetoBase.DataBase.Dominio.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase
{
    public class UsuarioContexto
    {
        public static Usuario UsuarioLogado { get; private set; }

        public static void Autenticar(Usuario usuario)
        {
            UsuarioLogado = usuario;
        }

        public static void Logout()
        {
            UsuarioLogado = null;
        }

        public static bool PossuiAcesso(string nivel)
        {
            if (UsuarioLogado == null) return false;
            return UsuarioLogado.NivelDeAcesso.Any(n => n.Nome == nivel);
        }
    }
}
