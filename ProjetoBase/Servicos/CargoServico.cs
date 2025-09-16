using ProjetoBase.DataBase.Dominio.Funcionario;
using ProjetoBase.Enumeradores;
using ProjetoBase.Ferramentas;
using ProjetoBase.Repository;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProjetoBase.Services
{
    public class CargoServico
    {


        private readonly CargoRepo _cargoRepo;

        public CargoServico(CargoRepo cargoRepo)
        {
            _cargoRepo = cargoRepo;
        }

        public RetornoServico Cadastrar(Cargo cargo) {
            //Verifica se já existe um cargo com o mesmo nome se existir retorna messagem de erro
            RetornoServico retorno = VericaDupliciadade(cargo.Nome);
            if (retorno.ResultadoQuery == EnumResultadoQuery.OBJETO_DUPLICADO) return retorno;
            retorno.ResultadoQuery = this._cargoRepo.Salvar(cargo);
            return retorno;
        }

        public RetornoServico Atualizar(Cargo cargo) {
            //Verifica o cargo existe se não existir retorna messagem de erro
            RetornoServico retorno = new RetornoServico();
            Cargo cargoSalvo = this._cargoRepo.ProcurarPorId(cargo.Id);
            if(cargoSalvo == null)
            {
                retorno.ResultadoQuery = EnumResultadoQuery.OBJETO_INEXISTENTE;
                retorno.Mensagem = "Cargo não encontrado para o ID: " + cargo.Id;
                return retorno;
            }

            retorno.ResultadoQuery = EnumResultadoQuery.SUCESSO;
            if (!cargoSalvo.Nome.Equals(cargo.Nome)) {
                retorno = VericaDupliciadade(cargo.Nome);
                if (retorno.ResultadoQuery == EnumResultadoQuery.OBJETO_DUPLICADO) return retorno;
                retorno.ResultadoQuery = this._cargoRepo.Salvar(cargo);                
            }

            return retorno;
        }

        private RetornoServico VericaDupliciadade(String nome) {
            //Verifica se já existe um cargo com mesmo nome pra evitar duplicidade
            RetornoServico retorno = new RetornoServico();
            if (this._cargoRepo.ProcurarPorNome(nome) != null) { 
                retorno.ResultadoQuery = EnumResultadoQuery.OBJETO_DUPLICADO;
                retorno.Mensagem = "Já existe um cargo com o nome: " + nome;
            }
            return retorno;
        }
    }
}
