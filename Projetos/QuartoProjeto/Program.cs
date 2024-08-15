using System.Globalization;

namespace QuartoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;

            x = new Triangulo(); // New = Instanciação
            y = new Triangulo();    


            // Lados do Triângulo X
            Console.WriteLine("Entre com as Medidas do triangulo X: ");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            // Lados do Triângulo Y
            Console.WriteLine("Entre com as Medidas do triangulo Y: ");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Caucular Area do Triângulo X
            double areaX = x.Area();


            // Caucular Area so Triangulo Y
            double areaY = y.Area();


            // Exibição da area X
            Console.WriteLine($"Area de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            // Exibicao da area Y
            Console.WriteLine($"Area de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");


            if (areaX > areaY) {
                Console.WriteLine(($"Maior area é X: {areaX} "));
            } else {
                Console.WriteLine($"Maior area é Y: {areaY}");
            }
        }
    }
}
