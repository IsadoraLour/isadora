using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vendedor
    {
        public int Identificacao { get; set; }
        public double PrecoUnitario{ get; set; }
        public int QuantidadeVendida { get; set; }

    }

    public void CalcularPrecoUnitarioPeca (Peca peca)
    {
        PrecoUnitarioPeca = (peca.Valor * QuantidadeVendida) * 0.05;
    }
}
