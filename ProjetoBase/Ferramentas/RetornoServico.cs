using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBase.Enumeradores;

namespace ProjetoBase.Ferramentas
{
    public class RetornoServico
    {
        public EnumResultadoQuery ResultadoQuery { get; set; }
        public String Mensagem { get; set; }

        public RetornoServico(){}

        public RetornoServico(EnumResultadoQuery resultadoQuery, String mensagem)
        {
            ResultadoQuery = resultadoQuery;
            Mensagem = mensagem;
        }

    }
}
