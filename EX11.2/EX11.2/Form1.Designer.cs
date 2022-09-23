namespace EX11._2
{
    partial class form_cadastroCategoria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.num_catId = new System.Windows.Forms.NumericUpDown();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.pnl_menu = new System.Windows.Forms.Label();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.btn_lista = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.num_catId)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // num_catId
            // 
            this.num_catId.Location = new System.Drawing.Point(204, 104);
            this.num_catId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_catId.Name = "num_catId";
            this.num_catId.Size = new System.Drawing.Size(150, 27);
            this.num_catId.TabIndex = 0;
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(204, 159);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(150, 27);
            this.txt_categoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_cadastro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.num_catId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_categoria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(130, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 276);
            this.panel1.TabIndex = 4;
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Location = new System.Drawing.Point(226, 221);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(94, 29);
            this.btn_cadastro.TabIndex = 5;
            this.btn_cadastro.Text = "Cadastrar";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cadastro Categoria";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_menu.Controls.Add(this.pnl_menu);
            this.panel_menu.Controls.Add(this.btn_produtos);
            this.panel_menu.Controls.Add(this.btn_lista);
            this.panel_menu.Enabled = false;
            this.panel_menu.Location = new System.Drawing.Point(130, 24);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(551, 82);
            this.panel_menu.TabIndex = 6;
            // 
            // pnl_menu
            // 
            this.pnl_menu.AutoSize = true;
            this.pnl_menu.Location = new System.Drawing.Point(245, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(46, 20);
            this.pnl_menu.TabIndex = 6;
            this.pnl_menu.Text = "Menu";
            // 
            // btn_produtos
            // 
            this.btn_produtos.Location = new System.Drawing.Point(326, 31);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(157, 29);
            this.btn_produtos.TabIndex = 7;
            this.btn_produtos.Text = "Cadastrar Produtos";
            this.btn_produtos.UseVisualStyleBackColor = true;
            this.btn_produtos.Click += new System.EventHandler(this.btn_produtos_Click);
            // 
            // btn_lista
            // 
            this.btn_lista.Location = new System.Drawing.Point(84, 31);
            this.btn_lista.Name = "btn_lista";
            this.btn_lista.Size = new System.Drawing.Size(157, 29);
            this.btn_lista.TabIndex = 6;
            this.btn_lista.Text = "Listar Itens";
            this.btn_lista.UseVisualStyleBackColor = true;
            this.btn_lista.Click += new System.EventHandler(this.btn_lista_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // form_cadastroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 483);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel1);
            this.Name = "form_cadastroCategoria";
            this.Text = "Cadastro Categoria";
            this.Load += new System.EventHandler(this.form_cadastroCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_catId)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_catId;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label pnl_menu;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.Button btn_lista;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
