using System.Globalization;

namespace TerceiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Escreva O Seu Nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual A Sua Idade: ");
            float idade = float.Parse(Console.ReadLine());

            Console.WriteLine($"Qual o Seu Salario: ");
            float Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine($"Seu Nome {nome} e Você Tem {idade}, Recebe {Salario}"); */



            /* 
            int num0 = 15;
            float num1 = 10f;

            Console.WriteLine(num0 / num1); 
            numero++
            numero-- 
            */

            // f = Serve Para Ele Não Arredondar os Número



            int num0 = 15;

            num0 += 10; // = num0 + 10

            Console.WriteLine(num0);

            string nome = "Yago ";
            nome += "Leite Barduco";

            Console.WriteLine(nome);
        }
    }
}
