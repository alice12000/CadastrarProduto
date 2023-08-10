namespace _3_BimAtividade
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.codigo_txt = new System.Windows.Forms.TextBox();
            this.descricao_txt = new System.Windows.Forms.TextBox();
            this.venda_txt = new System.Windows.Forms.TextBox();
            this.compra_txt = new System.Windows.Forms.TextBox();
            this.vendafim_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço de Aquisição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Porcentagem de venda: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor de venda: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // codigo_txt
            // 
            this.codigo_txt.Location = new System.Drawing.Point(124, 122);
            this.codigo_txt.Name = "codigo_txt";
            this.codigo_txt.Size = new System.Drawing.Size(100, 20);
            this.codigo_txt.TabIndex = 8;
            this.codigo_txt.TextChanged += new System.EventHandler(this.codigo_txt_TextChanged);
            // 
            // descricao_txt
            // 
            this.descricao_txt.Location = new System.Drawing.Point(329, 122);
            this.descricao_txt.Name = "descricao_txt";
            this.descricao_txt.Size = new System.Drawing.Size(100, 20);
            this.descricao_txt.TabIndex = 9;
            // 
            // venda_txt
            // 
            this.venda_txt.Location = new System.Drawing.Point(132, 213);
            this.venda_txt.Name = "venda_txt";
            this.venda_txt.Size = new System.Drawing.Size(100, 20);
            this.venda_txt.TabIndex = 10;
            this.venda_txt.TextChanged += new System.EventHandler(this.venda_txt_TextChanged);
            // 
            // compra_txt
            // 
            this.compra_txt.Location = new System.Drawing.Point(124, 167);
            this.compra_txt.Name = "compra_txt";
            this.compra_txt.Size = new System.Drawing.Size(100, 20);
            this.compra_txt.TabIndex = 11;
            this.compra_txt.TextChanged += new System.EventHandler(this.compra_txt_TextChanged);
            // 
            // vendafim_txt
            // 
            this.vendafim_txt.Location = new System.Drawing.Point(329, 171);
            this.vendafim_txt.Name = "vendafim_txt";
            this.vendafim_txt.Size = new System.Drawing.Size(100, 20);
            this.vendafim_txt.TabIndex = 12;
            this.vendafim_txt.TextChanged += new System.EventHandler(this.vendafim_txt_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-31, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(378, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 47);
            this.button3.TabIndex = 15;
            this.button3.Text = "Novo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(47, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 47);
            this.button4.TabIndex = 16;
            this.button4.Text = "Salvar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vendafim_txt);
            this.Controls.Add(this.compra_txt);
            this.Controls.Add(this.venda_txt);
            this.Controls.Add(this.descricao_txt);
            this.Controls.Add(this.codigo_txt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox codigo_txt;
        private System.Windows.Forms.TextBox descricao_txt;
        private System.Windows.Forms.TextBox venda_txt;
        private System.Windows.Forms.TextBox compra_txt;
        private System.Windows.Forms.TextBox vendafim_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

