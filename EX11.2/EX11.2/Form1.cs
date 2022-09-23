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
    public partial class form_cadastroCategoria : Form
    {
        public form_cadastroCategoria()
        {
            InitializeComponent();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Cadastro.categorias.Add(new CategoriaProduto((int)num_catId.Value, txt_categoria.Text));
                panel_menu.Enabled = true;
                MessageBox.Show("Cadastro Realizado!");
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            form_cadastroProduto frm = new form_cadastroProduto();
            frm.Show();
            this.Hide();
        }

        private void form_cadastroCategoria_Load(object sender, EventArgs e)
        {
            if(CategoriaProduto.contador <= 0)
            {
                panel_menu.Enabled = false;
            }
            else
            {
                panel_menu.Enabled = true;
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
