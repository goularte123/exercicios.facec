using System;

namespace exercicio.tres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe um valor em $: ");
            string valorDigitado = Console.ReadLine();
            Decimal valorConvertido = 0.0m;
            decimal valorCambio = 5.22m;

            decimal.TryParse(valorDigitado, out valorConvertido);
            decimal valorCabioConvertido = valorConvertido / valorCambio;

            Console.WriteLine($"valor em R$:{valorCabioConvertido }");
            Console.ReadLine();
        }
    }
}