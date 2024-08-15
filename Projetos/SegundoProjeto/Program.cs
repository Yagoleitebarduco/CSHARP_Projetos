using System.Globalization;

namespace SegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INT, FLOAT, BOOL, STRING

            int idade = 33;
            string nomeCompleto = "Yago Leite Barduco";

            var cidade = "Registro";

            dynamic estado = "SP";
            double salario = 2100.250;

            Console.WriteLine("Meu Nome é " + nomeCompleto); // Concatenação
            Console.WriteLine($"Atualmente, Tenho {idade}"); // Interpolação 
            Console.WriteLine("Moro em {0}", cidade);         // Place Holder

            Console.WriteLine($"Seu Slario e R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");


            const float PI = 3.145656f;

            Console.WriteLine("O Valor de PI é" + PI);

            PI = 4
        }
    }
}
