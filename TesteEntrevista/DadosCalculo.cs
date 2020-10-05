using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEntrevista
{
    public class DadosCalculo : DadosLiberacao
    {
        public string QtdParcelas { get; set; }
        public string Valor { get; set; }
        public int TipoCredito { get; set; }
        public string DataPrimeiroVencimento { get; set; }


        
        public StatusLiberacao StatusLiberacao { get; set; }
    }
}
