﻿using ProjetoBase.CustomControls;
using ProjetoBase.DataBase;
using ProjetoBase.DataBase.Ferramentas;
using ProjetoBase.Ferramentas;
using ProjetoBase.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        private void btn_logar_Click(object sender, EventArgs e)
        {
            SessionFactory.UnflushedSession();
            MenuInicial MenuInicial = new MenuInicial();
            MenuInicial.Show();
            this.Hide();
        }
    }
}
