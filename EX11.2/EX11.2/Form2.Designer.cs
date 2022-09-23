namespace EX11._2
{
    partial class form_cadastroProduto
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
            this.btn_lista = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cadastrarProduto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.num_preco = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num_IdProduto = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_categoria = new System.Windows.Forms.ComboBox();
            this.panel_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_preco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IdProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_menu.Controls.Add(this.pnl_menu);
            this.panel_menu.Controls.Add(this.btn_categoria);
            this.panel_menu.Controls.Add(this.btn_lista);
            this.panel_menu.Location = new System.Drawing.Point(102, 12);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(551, 82);
            this.panel_menu.TabIndex = 7;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_cadastrarProduto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.num_preco);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_nome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.num_IdProduto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.combo_categoria);
            this.panel1.Location = new System.Drawing.Point(102, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 296);
            this.panel1.TabIndex = 8;
            // 
            // btn_cadastrarProduto
            // 
            this.btn_cadastrarProduto.Location = new System.Drawing.Point(84, 243);
            this.btn_cadastrarProduto.Name = "btn_cadastrarProduto";
            this.btn_cadastrarProduto.Size = new System.Drawing.Size(157, 29);
            this.btn_cadastrarProduto.TabIndex = 8;
            this.btn_cadastrarProduto.Text = "Cadastrar Produto";
            this.btn_cadastrarProduto.UseVisualStyleBackColor = true;
            this.btn_cadastrarProduto.Click += new System.EventHandler(this.btn_cadastrarProduto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Preço";
            // 
            // num_preco
            // 
            this.num_preco.DecimalPlaces = 2;
            this.num_preco.Location = new System.Drawing.Point(84, 201);
            this.num_preco.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_preco.Name = "num_preco";
            this.num_preco.Size = new System.Drawing.Size(289, 27);
            this.num_preco.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(84, 150);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(291, 27);
            this.txt_nome.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID";
            // 
            // num_IdProduto
            // 
            this.num_IdProduto.Location = new System.Drawing.Point(86, 102);
            this.num_IdProduto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_IdProduto.Name = "num_IdProduto";
            this.num_IdProduto.Size = new System.Drawing.Size(289, 27);
            this.num_IdProduto.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cadastrar Produto";
            // 
            // combo_categoria
            // 
            this.combo_categoria.FormattingEnabled = true;
            this.combo_categoria.Location = new System.Drawing.Point(84, 49);
            this.combo_categoria.Name = "combo_categoria";
            this.combo_categoria.Size = new System.Drawing.Size(291, 28);
            this.combo_categoria.TabIndex = 0;
            // 
            // form_cadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menu);
            this.Name = "form_cadastroProduto";
            this.Text = "Cadastro Categoria";
            this.Load += new System.EventHandler(this.form_cadastroProduto_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_preco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IdProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label pnl_menu;
        private System.Windows.Forms.Button btn_categoria;
        private System.Windows.Forms.Button btn_lista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_preco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_IdProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_categoria;
        private System.Windows.Forms.Button btn_cadastrarProduto;
    }
}