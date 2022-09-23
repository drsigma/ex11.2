using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11._2
{
    internal class CategoriaProduto
    {
        private int id;
        private string descricao;
        public static int contador = 0;

        public  CategoriaProduto(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            contador++;
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
