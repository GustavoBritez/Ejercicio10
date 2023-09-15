using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ejemplo de uso
            string binario = "1101";
            int resultado = BinarioAEntero(binario);
            Console.WriteLine($"El número binario {binario} en decimal es: {resultado}");
        }


        static int BinarioAEntero(string binario)
        {
            if (string.IsNullOrEmpty(binario))
                return 0;

            char ultimoDigito = binario[binario.Length - 1];

            int valorDigito = int.Parse(ultimoDigito.ToString());

            string binarioRestante = binario.Substring(0, binario.Length - 1);

            int valorRestante = BinarioAEntero(binarioRestante);

            int valorTotal = valorDigito * (int)Math.Pow(2, binario.Length - 1) + valorRestante;

            return valorTotal;

        }
    }
}
