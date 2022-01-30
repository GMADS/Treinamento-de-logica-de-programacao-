using System;

namespace Calculo_de_perimetro_e_area
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de calculo de area e perimetro de retangulo");

            Console.WriteLine("Digite a largura");
            var width = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura");
            var height = float.Parse(Console.ReadLine());

            var area = CalculateArea(width, height);
            var perimeter = CalculatePerimeter(width, height);

            Console.WriteLine($"A area do retangulo é: {area}");
            Console.WriteLine($"O perimetro do retangulo é: {perimeter}");

            Console.ReadLine();
        }

        private static float CalculateArea(float width, float height) =>
            width * height;

        private static float CalculatePerimeter(float width, float height) =>        
            (width * 2) + (height * 2);
        
    }
}
