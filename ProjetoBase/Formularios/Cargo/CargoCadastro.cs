using ProjetoBase.CustomControls;
using ProjetoBase.CustomControls.Validacao;
using ProjetoBase.DataBase;
using ProjetoBase.DataBase.Dominio;
using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.DataBase.Ferramentas;
using ProjetoBase.Enumeradores;
using ProjetoBase.Ferramentas;
using ProjetoBase.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBase.Formularios
{
    public partial class CargoCadastro : FormCC
    {
        Cargo cargo = null;
        private readonly CargoService _cargoService;

        public CargoCadastro(Cargo cargo, CargoService cargoService)
        {
            InitializeComponent();
            this.cargo = cargo;
            _cargoService = cargoService;
            carregarCargo();
        }

        //Carrega dados de um Cargo se ja cadastrado
        public void carregarCargo()
        {
            if (cargo != null)
            {
                txt_codigo.Texto = cargo.Codigo;
                txt_nome.Texto = cargo.Nome;
                btn_cadastrar.TipoBotao = TipoBotao.Salvar;
            }
        }

        private void PessoaNovo_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_tipo_ato_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_Paint(object sender, PaintEventArgs e)
        {

        }


        //Cadastrar ou salvar cargo
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            RetornoValidacaoDados retorno = ValidacaoDadosObrigatorios.validarPanelObrigatorio(panel_cargo);
            if (retorno.Valido)
            {
                //Se for nulo, é um novo cargo se não, é uma atualização
                RetornoServico retornoServico = new RetornoServico();
                if (cargo == null || cargo.Id == 0)
                {
                    cargo = new Cargo();
                    cargo.Nome = txt_nome.Texto;
                    retornoServico = _cargoService.Cadastrar(cargo);
                }
                else {
                    cargo.Nome = txt_nome.Texto;
                    retornoServico = _cargoService.Atualizar(cargo);
                }

                DispararEventoSalvo(cargo);
                if (retornoServico.ResultadoQuery == EnumResultadoQuery.SUCESSO)
                {
                   mostrarMensagemResultado(retornoServico.ResultadoQuery);
                }
                else {
                    mostrarMensagemResultadoSemFechar(retornoServico.ResultadoQuery, retornoServico.Mensagem);
                }

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cancelarEdicao(cargo);
        }
    }
}
