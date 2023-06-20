using System.Globalization;

namespace PrimeiroProjeto 
{
    #region
    #endregion
    #region Aula1
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
    //    }
    //}
    #endregion
    #region Tipos de Dados
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        bool completo = false;
    //        char genero = 'F';
    //        char letra = '\u0041';
    //        byte n1 = 126;
    //        int n2 = 1000;
    //        int n3 = 2147483647;
    //        long n4 = 2147483648L;
    //        float n5 = 4.5f;
    //        double n6 = 4.5;
    //        String nome = "Maria Green";
    //        Object obj1 = "Alex Brown";
    //        Object obj2 = 4.5f;
    //        Console.WriteLine(completo);
    //        Console.WriteLine(genero);
    //        Console.WriteLine(letra);
    //        Console.WriteLine(n1);
    //        Console.WriteLine(n2);
    //        Console.WriteLine(n3);
    //        Console.WriteLine(n4);
    //        Console.WriteLine(n5);
    //        Console.WriteLine(n6);
    //        Console.WriteLine(nome);
    //        Console.WriteLine(obj1);
    //        Console.WriteLine(obj2);
    //    }
    //}
    #endregion
    #region Saida de Dados
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        double x = 10.35784;
    //        int y = 32;
    //        string z = "Maria";
    //        char w = 'F';

    //        Console.Write("Olá mundo!");
    //        Console.WriteLine("Bom dia!");
    //        Console.WriteLine("Até mais.");

    //        Console.WriteLine();
    //        Console.WriteLine(x);
    //        Console.WriteLine(x.ToString("F2"));
    //        Console.WriteLine(x.ToString("F4"));
    //        Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

    //        Console.WriteLine();
    //        Console.WriteLine("RESULTADO = " + x);
    //        Console.WriteLine("O valor do troco é " + x + " reais");
    //        Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

    //        Console.WriteLine();
    //        Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region Placeholders - Concatenação - Interpolação
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int idade = 32;
    //        double saldo = 10.35784;
    //        String nome = "Maria";

    //        Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

    //        Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

    //        Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
    //        + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
    //    }
    //}
    #endregion
    #region Exercício001
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string produto1 = "Computador";
    //        string produto2 = "Mesa de escritório";
    //        byte idade = 30;
    //        int codigo = 5290;
    //        char genero = 'M';
    //        double preco1 = 2100.0;
    //        double preco2 = 650.50;
    //        double medida = 53.234567;
    //        Console.WriteLine("Produtos:");
    //        Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
    //        Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto2, preco2);
    //        Console.WriteLine();
    //        Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
    //        Console.WriteLine();
    //        Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
    //        Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
    //        Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
    //    }
    //}
    #endregion
    #region Triangulo sem classe
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        double xA, xB, xC, yA, yB, yC;
    //        Console.WriteLine("Entre com as medidas do triângulo X:");
    //        xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    //        xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    //        xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    //        Console.WriteLine("Entre com as medidas do triângulo Y:");
    //        yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    //        yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    //        yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    //        double p = (xA + xB + xC) / 2.0;
    //        double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
    //        p = (yA + yB + yC) / 2.0;
    //        double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
    //        Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
    //        Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
    //        if (areaX > areaY)
    //        {
    //            Console.WriteLine("Maior área: X");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Maior área: Y");
    //        }
    //    }
    //}

    #endregion
    #region Triangulo com Classe
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
    #endregion
}