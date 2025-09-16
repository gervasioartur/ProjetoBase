namespace ProjetoBase
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_logar = new ProjetoBase.CustomControls.BotaoCC();
            this.btn_cancelar = new ProjetoBase.CustomControls.BotaoCC();
            this.txt_senha = new ProjetoBase.CustomControls.TextboxLabelCC();
            this.text_login = new ProjetoBase.CustomControls.TextboxLabelCC();
            this.SuspendLayout();
            // 
            // btn_logar
            // 
            this.btn_logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btn_logar.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_logar.Location = new System.Drawing.Point(198, 169);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.NivelDeAcesso = null;
            this.btn_logar.Size = new System.Drawing.Size(120, 35);
            this.btn_logar.TabIndex = 0;
            this.btn_logar.Text = "LOGIN";
            this.btn_logar.TipoBotao = ProjetoBase.Enumeradores.TipoBotao.BotaoGenerico;
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_cancelar.Location = new System.Drawing.Point(29, 169);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NivelDeAcesso = null;
            this.btn_cancelar.Size = new System.Drawing.Size(120, 35);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TipoBotao = ProjetoBase.Enumeradores.TipoBotao.Cancelar;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_senha.CorLabel = System.Drawing.Color.Black;
            this.txt_senha.Location = new System.Drawing.Point(29, 113);
            this.txt_senha.MultiLinha = false;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.NomeDisplay = "Senha";
            this.txt_senha.Obrigatorio = true;
            this.txt_senha.PedirSenhaAlterarSomenteLeitura = true;
            this.txt_senha.PermitirAlterarSomenteLeitura = false;
            this.txt_senha.PermitirValorNegativo = false;
            this.txt_senha.Senha = false;
            this.txt_senha.Size = new System.Drawing.Size(289, 35);
            this.txt_senha.SomenteLeitura = false;
            this.txt_senha.TabIndex = 3;
            this.txt_senha.TamanhoMaximo = 255;
            this.txt_senha.TamanhoTextBox = null;
            this.txt_senha.Texto = null;
            this.txt_senha.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            this.txt_senha.Paint += new System.Windows.Forms.PaintEventHandler(this.txt_senha_Paint);
            // 
            // text_login
            // 
            this.text_login.Caixa = System.Windows.Forms.CharacterCasing.Upper;
            this.text_login.CorLabel = System.Drawing.Color.Black;
            this.text_login.Location = new System.Drawing.Point(29, 46);
            this.text_login.MultiLinha = false;
            this.text_login.Name = "text_login";
            this.text_login.NomeDisplay = "Login";
            this.text_login.Obrigatorio = true;
            this.text_login.PedirSenhaAlterarSomenteLeitura = true;
            this.text_login.PermitirAlterarSomenteLeitura = false;
            this.text_login.PermitirValorNegativo = false;
            this.text_login.Senha = false;
            this.text_login.Size = new System.Drawing.Size(289, 35);
            this.text_login.SomenteLeitura = false;
            this.text_login.TabIndex = 4;
            this.text_login.TamanhoMaximo = 255;
            this.text_login.TamanhoTextBox = null;
            this.text_login.Texto = null;
            this.text_login.TipoTextBox = ProjetoBase.Enumeradores.TipoTextBox.Texto;
            this.text_login.Paint += new System.Windows.Forms.PaintEventHandler(this.text_login_Paint);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 231);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.text_login);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_logar);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ProjetoBase.CustomControls.BotaoCC btn_logar;
        private CustomControls.BotaoCC btn_cancelar;
        private CustomControls.TextboxLabelCC txt_senha;
        private CustomControls.TextboxLabelCC text_login;
    }
}