/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CacaAoBugMVC
{
    internal class PassagemParametro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Passagem de Parametro por Valor ***");
            double valor = 10;
            if (PassagemParametroValor(valor))
            Console.WriteLine($"Valor do método Main -> PassagemParametroValor: {valor}");

            Console.WriteLine("\n\n*** Passagem de Parametro por Ref ***");
            double valor1 = 10;
            if (PassagemParametroReferenciaRef(ref valor1))
            {
                Console.WriteLine($"Valor do método Main -> PassagemParametrorReferenciaRef: {valor1}");
            }

            Console.WriteLine("\n\n*** Passagem de Parametro por Out ***");
            double valor2 = 10;
            if (PassagemParametroReferenciaOut(out valor2))
            {
                Console.WriteLine($"Valor do método Main -> PassagemParametroReferenciaOut: {valor2}");
            }

            Console.WriteLine("\n\n*** Passagem de Parametro por In ***");
            double valor3 = 100;
            if (PassagemParametroReferenciaIN(in valor3))
            {
                Console.WriteLine($"Valor do método Main -> PassagemParametroReferenciaIN: {valor3}");
            }
        }

        public static bool PassagemParametroValor(double valor)
        {
            valor = valor * 10;
            Console.WriteLine($"Valor do método PassagemParametroValor: {valor}");
            return true;
        }

        public static bool PassagemParametroReferenciaRef(ref double valor1)
        {
            valor1 = valor1 * 10;
            Console.WriteLine($"Valor do método PassagemParametroReferenciaRef: {valor1}");
            return true;
        }

        public static bool PassagemParametroReferenciaOut(out double valor2)
        { 
            valor2 = 10;
            valor2 = valor2 * 10;
            Console.WriteLine($"Valor do método PassagemParametroReferenciaOut: {valor2}");
            return true;
        }

        public static bool PassagemParametroReferenciaIN(in double valor3)
        {
            Console.WriteLine($"Valor do método PassagemParametroReferenciaIN: {valor3}");
            return true;
        }
    }
}
*/