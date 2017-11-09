using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_biblioteca_M14_15
{
    public partial class frLivros : Form
    {
        public frLivros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //validar os dados so form

            //copiar imagem para uma pasta 
            string nome = textBox1.Text;
            int ano = int.Parse(textBox2.Text);
            DateTime data = dateTimePicker2.Value;
            decimal preco = decimal.Parse(textBox3.Text);
            //insert into
            string sql =$@"INSERT INTO livros(nome,ano,data_aquisicao,preco) 
                            VALUES('{nome}',{ano},'{data}',{preco})";
            BaseDados bd = new BaseDados();
            bd.executaSQL(sql);


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
