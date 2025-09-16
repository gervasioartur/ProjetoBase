using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.DataBase.Repository;
using ProjetoBase.Ferramentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase.Servicos
{
    public class AutenticacaoServico
    {
        private readonly UsuarioRepo _usuarioRepo;
        
        public AutenticacaoServico(UsuarioRepo usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
        }

        public RetornoServico Login(string login, string senha)
        {
            RetornoServico retorno = new RetornoServico();
            Usuario usuario = _usuarioRepo.ProcurarPorLogin(login);

            if (usuario == null) { 
                retorno.ResultadoQuery = Enumeradores.EnumResultadoQuery.OBJETO_INEXISTENTE;
                retorno.Mensagem = "Login ou senha inválido(s)";
                return retorno;
            }

            if (!BCrypt.Net.BCrypt.Verify(senha, usuario.Senha)) {
                retorno.ResultadoQuery = Enumeradores.EnumResultadoQuery.OBJETO_INEXISTENTE;
                retorno.Mensagem = "Login ou senha inválido(s)";
                return retorno;
            }

            retorno.ResultadoQuery = Enumeradores.EnumResultadoQuery.SUCESSO;
            return retorno;
        }
    }

}
