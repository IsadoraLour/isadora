using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Estoque
    {
        public double EstoqueMedio { get; set; }

        public void CalcularEstoqueMedio(int QuantidadeMin, int QuantidadeMax)
        {
            EstoqueMedio = (QuantidadeMin + QuantidadeMax) / 2;
        }

        public void Dolar()
        {
            Console.WriteLine("Digite a atual cortação do Dólar");
            double dolar = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga um valor:");
            double valor = int.Parse(Console.ReadLine());
            double resul = valor / dolar;

            Console.WriteLine($"US:{valor} = R$ {resul}. DOl:{dolar}");
        }
    }
}