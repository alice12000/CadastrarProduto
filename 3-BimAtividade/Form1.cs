using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_BimAtividade
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cadastrar criar lista
           
           Produto produto = new Produto();
           produto.Codigo= codigo_txt.Text;
           produto.Descricao = descricao_txt.Text;
           produto.Compra = Convert.ToDouble(compra_txt.Text);
           produto.Venda = Convert.ToDouble(venda_txt.Text);

           produto.ValorFinal = (produto.Compra * produto.Venda / 100) + produto.Compra;
           vendafim_txt.Text = produto.ValorFinal.ToString();
           produtos.Add(produto);
            //enable: colocar como falso para não aceitar receber valor;

            //adicionar na tabela: 


            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = produtos;

        }

        private void codigo_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void compra_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void vendafim_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void venda_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int index = dataGridView1.CurrentCell.RowIndex;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            codigo_txt.Clear();
            descricao_txt.Clear();
            vendafim_txt.Clear();
            compra_txt.Clear();
            venda_txt.Clear();
        }
    }
}
