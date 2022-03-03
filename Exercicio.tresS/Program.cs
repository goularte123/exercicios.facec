using System;

namespace Exercicio.tresS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe a distancia e"+"em KM: ");
            decimal.TryParse(Console.ReadLine(),out decimal kmPercorido);

            Console.WriteLine("informe o combustivel gasto na viagem" + "em Litros: ");
            decimal.TryParse(Console.ReadLine(), out decimal litrosGastostos);
            Console.WriteLine($"sua media foi {kmPercorido/litrosGastostos}");
            Console.ReadLine();
        }
    }
}
