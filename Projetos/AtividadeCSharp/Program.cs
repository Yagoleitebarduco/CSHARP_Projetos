using System.Globalization;

namespace AtividadeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double comodo, preco;
             

            Console.WriteLine("Qual o Seu Nome: ");
            string nome = Console.ReadLine();


            Console.WriteLine("Quantos Quartos Você tem Em sua Casa ?");
            comodo = int.Parse(Console.ReadLine());


            Console.WriteLine("Entre Com o preco de Um Produto: ");
            preco = double.Parse(Console.ReadLine());


            Console.WriteLine("Entre seu Ultimo nome, idade e altra: ");
            string nia = Console.ReadLine();


            Console.WriteLine($"{nome} \n {comodo} \n {preco}");
        }
    }
}
