using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEntrevista
{
    public class DadosLiberacao 
    {
        public decimal ValorTotalComJuros { get; set; }
        public decimal ValorDoJuros { get; set; }
        public bool LiberaValor { get; set; }
        public bool LiberaParcela { get; set; }

        public enum StatusLiberacao
        {            
            Reprovado=0,
            Aprovado
        }

       
    }
}
