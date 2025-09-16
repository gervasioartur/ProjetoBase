using ProjetoBase.CustomControls;
using ProjetoBase.DataBase;
using System.Windows.Forms; 
using System;


namespace ProjetoBase
{
    public partial class Login : FormCC
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void text_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_senha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            SessionFactory.UnflushedSession();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
