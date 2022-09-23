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
    public partial class form_cadastroProduto : Form
    {
        bool cadastro = false;
        public form_cadastroProduto()
        {
            InitializeComponent();
        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {
            form_cadastroCategoria frm = new form_cadastroCategoria();
            this.Hide();
            frm.Show();
        }

        private void form_cadastroProduto_Load(object sender, EventArgs e)
        {
            foreach(CategoriaProduto categoria in Cadastro.categorias)
            {
                combo_categoria.Items.Add(categoria.Descricao);
            }
        }

        private void btn_cadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(CategoriaProduto categoria in Cadastro.categorias)
                {
                    if(categoria.Descricao == combo_categoria.SelectedItem.ToString())
                    {
                        Cadastro.produtos.Add(new Produto((int)num_IdProduto.Value,txt_nome.Text,
                            (double)num_preco.Value,categoria));
                        cadastro = true;
                        MessageBox.Show("Produto Cadastrado");
                        break;
                    }
                }
                if (!cadastro)
                {
                    MessageBox.Show("Categoria não encontrada");
                }
                else
                {
                    cadastro = false;
                }
                
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_lista_Click(object sender, EventArgs e)
        {
            form_listar frm = new form_listar();
            frm.Show();
            this.Hide();
        }
    }
}
