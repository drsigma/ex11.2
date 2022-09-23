using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11._2
{
    internal class Produto
    {
        private int id;
        private string descricao;
        private double preco;
        private CategoriaProduto categoria;
        public static int contador = 0;

        public Produto(int id, string descricao, double preco, CategoriaProduto categoria)
        {
            Id = id;
            Descricao = descricao;
            Preco = preco;
            Categoria = categoria;
            contador++;
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }
        internal CategoriaProduto Categoria { get => categoria; set => categoria = value; }
    }
}
