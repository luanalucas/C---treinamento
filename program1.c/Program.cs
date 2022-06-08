using System;
using System.Globalization;

namespace program1.c
{
    class Program
    {
        static void Main()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: \n");
            Console.WriteLine(produto1 + ", cujo preço é " + preco1);
            Console.WriteLine(produto2+ ", cujo preço é "+ preco2);
            Console.WriteLine("Registro: "+ idade+ " anos de idade, codigo"+ codigo+ " e gênero: "+ genero);
            Console.WriteLine("Medida com oito casas decimais: "+ medida);
            Console.WriteLine("Arredondado (três casas decimais): "+ string.Format("{0:0.000}", medida));
            Console.WriteLine("Separador decimal invariant culture: "+ medida.ToString("F3", CultureInfo.InvariantCulture)); //ponto
        }
    }
}
