using ProjetoBase.DataBase;
using ProjetoBase.DataBase.Repository;
using ProjetoBase.Formularios;
using ProjetoBase.Servicos;
using System.Windows.Forms;

namespace ProjetoBase
{
    public class AppContext : ApplicationContext
    {
        public AppContext()
        {

            UsuarioRepo usuarioRepo = new UsuarioRepo();
            AutenticacaoServico autenticacaoServico = new AutenticacaoServico(usuarioRepo);

            var login = new Login(autenticacaoServico);
            login.FormClosed += (s, e) =>
            {
                if (login.DialogResult == DialogResult.OK)
                {
                    var menu = new MenuInicial();
                    menu.FormClosed += (s2, e2) => ExitThread();
                    menu.Show();
                }
                else
                {
                    ExitThread(); 
                }
            };
            login.Show();
        }
    }
}
