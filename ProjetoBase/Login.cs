using ProjetoBase.CustomControls;
using ProjetoBase.CustomControls.Validacao;
using ProjetoBase.DataBase;
using ProjetoBase.Enumeradores;
using ProjetoBase.Ferramentas;
using ProjetoBase.Services;
using ProjetoBase.Servicos;
using System;
using System.Windows.Forms;


namespace ProjetoBase
{
    public partial class Login : FormCC
    {
        private readonly AutenticacaoServico _autenticacaoServico;
        public Login(AutenticacaoServico autenticacaoServico)
        {
            InitializeComponent();
            //Servicos
            _autenticacaoServico = autenticacaoServico;

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

            if (string.IsNullOrEmpty(text_login.Texto))
            {
                mostrarMensagemResultadoSemFechar(EnumValidacaoTelaLogin.Login_Obrigatorio);
                return;
            }
            if (string.IsNullOrEmpty(txt_senha.Texto))
            {
                mostrarMensagemResultadoSemFechar(EnumValidacaoTelaLogin.Senha_Obrigatorio);
                return;
            }

            RetornoServico retornoService = this._autenticacaoServico.Login(text_login.Texto, txt_senha.Texto);

            if (retornoService.ResultadoQuery == EnumResultadoQuery.SUCESSO)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                mostrarMensagemResultadoSemFechar(retornoService.ResultadoQuery, retornoService.Mensagem);
            }

        }


    }
}
