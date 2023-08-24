using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorebasCompanny
{
    class Produto
    {
        private string nome;
        private double preco;
        private int id;
        private int quantidadedeprodutos; 
        
        public Produto(string nome, float preco, int id, int quantidadedeprodutos)
        {
            this.nome = nome;
            this.preco = preco;
            
            this.id = id;
            this.quantidadedeprodutos = quantidadedeprodutos;
        }
        public void SetPreco(double preco)
        {
            this.preco = preco;
        }
        public double GetPreco()
        {
            return preco;
        }
        public void SetNome(string nomedoproduto)
        {
           this.nome = nomedoproduto;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetId(int iddoproduto)
        {
            this.id = iddoproduto;
        }
        public int GetId()
        {
            return id;
        }
        public void SetQuantidade(int quantia)
        {
            this.quantidadedeprodutos = quantia;
        }
        public int GetQuantia()
        {
            return quantidadedeprodutos;
        }
        public void removeitem(int quantidade)
        {
            this.quantidadedeprodutos -= quantidade;
        }
        public void Vendeu()
        {
            this.id--;
            this.quantidadedeprodutos--;
        }
    }
}
