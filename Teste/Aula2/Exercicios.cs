using System;

namespace Atividade
{
    class Program2
    {
        static void Main(String[] args)
        {   
            // int aQ = 5;
            // int bQ = 10;
            // double aT = 10; //base
            // double bT = 5; //altura
            // double r = 12;
            // double p = 3.14;

            // double areaTriangulo = (aT*bT)/2;
            // double areaCirculo = p * ( r * r );
            // double areaQuadrado = aQ*bQ;

            // Console.WriteLine($"Base Triângulo:{bT}\nAltura Triangulo: {aT}\nÁrea Triângulo: {areaTriangulo}\n");
            // Console.WriteLine($"Raio: {r}\nÁrea Circulo: {areaCirculo}\n");
            // Console.WriteLine($"Base Quadrado:{bQ}\nAltura Quadrado: {aQ}\nÁrea Triângulo: {areaQuadrado}\n");


            // int aQ,bQ;
            // double aT,bT,r, areaCirculo, areaQuadrado, areaTriangulo;

            // // Leitura da área do circulo
            // Console.WriteLine("Digite o valor do raio:");
            // r = Convert.ToInt32(Console.ReadLine());
            // areaCirculo = 3.14 * ( r * r );
            // Console.Clear();
            // Console.WriteLine($"A área do circulo é de {areaCirculo}m²\nPress any key to continue...");
            // Console.ReadKey();
            // Console.Clear();

            // Leitura da área do quadrado
            // Console.WriteLine("Digite o valor da base:");
            // bQ = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Digite o valor da altura:");
            // aQ = Convert.ToInt32(Console.ReadLine());
            // areaQuadrado = (int) aQ*bQ;
            // Console.Clear();
            // Console.WriteLine($"A área do quadrado é de {areaQuadrado}m²\nPress any key to continue...");
            // Console.ReadKey();
            // Console.Clear();

            //Leitura da área do triângulo

            // Console.WriteLine("Digite o valor da base:");
            // bT = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Digite o valor da altura:");
            // aT = Convert.ToInt32(Console.ReadLine());
            // areaTriangulo = (aT*bT)/2;
            // Console.Clear();
            // Console.WriteLine($"A área do triângulo é de {areaTriangulo}m²\nPress any key to continue...");
            // Console.ReadKey();
            // Console.Clear();


            Console.WriteLine("Digite...");
            string palavras = Console.ReadLine();
            string[] sep = palavras.Split(' ');
            string p = sep[0];
            string p1 = sep[1];
            string p2 = sep[2];

        }
    }
}