using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exe12
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            double[] valoresProdutos  = new double [5];

            for (int i = 0; i < 5; i++) ;

            Console.Write($"Digite o valor do {i + 1}° produto: $ ");
            valoresProdutos[i] =double.Parse( Console.ReadLine() );

            double total = 0;
            foreach (int i in valoresProdutos) total += valoresProdutos[i];

            Console.Write("Digite o valor do pagamento: R$ ");
            double pagamento = double.Parse( Console.ReadLine() );

            double troco = pagamento - total;

            Console.WriteLine($"Troco a ser devolvido: R$ {troco:F2}");
        }
    }
}
