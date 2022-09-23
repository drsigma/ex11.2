namespace EX11._2
{
    partial class form_listar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_menu = new System.Windows.Forms.Panel();
            this.pnl_menu = new System.Windows.Forms.Label();
            this.btn_categoria = new System.Windows.Forms.Button();
            this.btn_cadastrarProduto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_listar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_categorias = new System.Windows.Forms.TextBox();
            this.txt_produtos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_menu.Controls.Add(this.pnl_menu);
            this.panel_menu.Controls.Add(this.btn_categoria);
            this.panel_menu.Controls.Add(this.btn_cadastrarProduto);
            this.panel_menu.Location = new System.Drawing.Point(106, 24);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(551, 82);
            this.panel_menu.TabIndex = 8;
            // 
            // pnl_menu
            // 
            this.pnl_menu.AutoSize = true;
            this.pnl_menu.Location = new System.Drawing.Point(255, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(46, 20);
            this.pnl_menu.TabIndex = 6;
            this.pnl_menu.Text = "Menu";
            // 
            // btn_categoria
            // 
            this.btn_categoria.Location = new System.Drawing.Point(326, 31);
            this.btn_categoria.Name = "btn_categoria";
            this.btn_categoria.Size = new System.Drawing.Size(157, 29);
            this.btn_categoria.TabIndex = 7;
            this.btn_categoria.Text = "Cadastrar Categoria";
            this.btn_categoria.UseVisualStyleBackColor = true;
            this.btn_categoria.Click += new System.EventHandler(this.btn_categoria_Click);
            // 
            // btn_cadastrarProduto
            // 
            this.btn_cadastrarProduto.Location = new System.Drawing.Point(84, 31);
            this.btn_cadastrarProduto.Name = "btn_cadastrarProduto";
            this.btn_cadastrarProduto.Size = new System.Drawing.Size(157, 29);
            this.btn_cadastrarProduto.TabIndex = 6;
            this.btn_cadastrarProduto.Text = "Cadastrar Produto";
            this.btn_cadastrarProduto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_cadastrarProduto.UseVisualStyleBackColor = true;
            this.btn_cadastrarProduto.Click += new System.EventHandler(this.btn_cadastrarProduto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_listar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_categorias);
            this.panel1.Controls.Add(this.txt_produtos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(106, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 313);
            this.panel1.TabIndex = 9;
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(22, 273);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(157, 29);
            this.btn_listar.TabIndex = 8;
            this.btn_listar.Text = "Listar";
            this.btn_listar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Categorias";
            // 
            // txt_categorias
            // 
            this.txt_categorias.Location = new System.Drawing.Point(277, 43);
            this.txt_categorias.Multiline = true;
            this.txt_categorias.Name = "txt_categorias";
            this.txt_categorias.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_categorias.Size = new System.Drawing.Size(252, 224);
            this.txt_categorias.TabIndex = 10;
            // 
            // txt_produtos
            // 
            this.txt_produtos.Location = new System.Drawing.Point(22, 43);
            this.txt_produtos.Multiline = true;
            this.txt_produtos.Name = "txt_produtos";
            this.txt_produtos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_produtos.Size = new System.Drawing.Size(237, 224);
            this.txt_produtos.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Listar Produtos e Categorias";
            // 
            // form_listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menu);
            this.Name = "form_listar";
            this.Text = "Listar Itens";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label pnl_menu;
        private System.Windows.Forms.Button btn_categoria;
        private System.Windows.Forms.Button btn_cadastrarProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_categorias;
        private System.Windows.Forms.TextBox txt_produtos;
        private System.Windows.Forms.Label label1;
    }
}