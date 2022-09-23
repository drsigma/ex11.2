using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX11._2
{
    public partial class form_listar : Form
    {
        public form_listar()
        {
            InitializeComponent();
        }

        private void btn_cadastrarProduto_Click(object sender, EventArgs e)
        {
            form_cadastroProduto frm = new form_cadastroProduto();
            frm.Show();
            this.Hide();
        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {
            form_cadastroCategoria frm = new form_cadastroCategoria();
            this.Hide();
            frm.Show();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            txt_categorias.Text = "";
            txt_produtos.Text = "";
            try
            {
                if (Produto.contador > 0)
                {
                    foreach(Produto produto in Cadastro.produtos)
                    {
                        txt_produtos.Text += "Id Produto: " + produto.Id + Environment.NewLine +
                            "Nome: " + produto.Descricao + Environment.NewLine +
                            "Preço: " + produto.Preco + Environment.NewLine +
                            "Categoria Id: " + produto.Categoria.Id + Environment.NewLine +
                            "Categoria: " + produto.Categoria.Descricao + Environment.NewLine;
                    }
                }
                else
                {
                    MessageBox.Show("Não foram encontrados Produtos");
                }
                if(CategoriaProduto.contador > 0)
                {
                    foreach(CategoriaProduto categoria in Cadastro.categorias)
                    {
                        txt_categorias.Text += "Id Categoria: " + categoria.Id + Environment.NewLine +
                            "Categoria: " + categoria.Descricao + Environment.NewLine;
                    }
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
