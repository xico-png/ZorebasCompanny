using System;
using System.Collections.Generic;
 namespace ZorebasCompanny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZorebasCompanny");
            Console.WriteLine("Você tem um novo produto");
            List<Produto> listdeprodutos = new();
            Produto resistores = new("Resistores", 0.2f, 10, 10);
            listdeprodutos.Add(resistores);
            


        }
    }
}
