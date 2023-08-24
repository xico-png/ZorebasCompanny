using System;
using System.Collections.Generic;

namespace ZorebasCompanny
{

    class Program
    {
        public static Caixa caixa = new Caixa();
        static List<Produto> listdeprodutos = new();
        static double valortotal;        

        static void Main(string[] args)
        {
            
            Console.WriteLine("ZorebasCompanny");
            Console.WriteLine("Você tem um novo produto (resistores)");
            Produto resistores = new("Resistores", 0.2f, 10, 10);
            Produto diodo= new("diodo", 0.25f, 10, 10);
            Produto botao = new("botao", 0.1f, 10, 10);
            Produto capacitor = new("capacitor", 0.2f, 10, 10);
            Produto trimpot = new("trimpot", 0.3f, 10, 10);
            listdeprodutos.Add(diodo);
            listdeprodutos.Add(botao);
            listdeprodutos.Add(capacitor);
            listdeprodutos.Add(trimpot);
            listdeprodutos.Add(resistores);
            Console.WriteLine($"o valor total é:{ValorTotal()}");
        }

        public static double ValorTotal()
        {
            valortotal = 0;
            foreach(Produto valor in listdeprodutos){valortotal += valor.GetPreco();} return valortotal;
        }
    }
}
