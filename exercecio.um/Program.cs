using System;

namespace exercecio.um
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe um valor em R$: ");
            string valorDigitado = Console.ReadLine();
            Decimal valorConvertido = 0.0m;
            decimal valorCambio = 0.1932m;  

            decimal.TryParse(valorDigitado, out valorConvertido);
            decimal valorCabioConvertido = valorConvertido / valorCambio;

            Console.WriteLine($"valor em $:{valorCabioConvertido }");
            Console.ReadLine();
        }
    }
}
