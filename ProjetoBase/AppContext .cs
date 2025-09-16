using ProjetoBase.DataBase;
using ProjetoBase.Formularios;
using System.Windows.Forms;

namespace ProjetoBase
{
    public class AppContext : ApplicationContext
    {
        public AppContext()
        {
            var login = new Login();
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
