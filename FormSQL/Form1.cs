using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btsalvar_Click(object sender, EventArgs e)
        {


            /*string nome = tbnome
            int idade = tbidade
            string cpf = tbcpf
            string ind = tbend
            string bairro = tbbairro
            string cep = tbcep
            string cidade = tbcidade*/
            {
                Pessoa p = new Pessoa(tbnome.Text, int.Parse(tbidade.Text), tbcpf.Text, tbend.Text, tbbairro.Text, tbcep.Text, tbcidade.Text);
                MessageBox.Show("Nome do Individuo " + p.nome + "CPF: " + p.cpf);
                tbnome.Text = "";
                tbidade.Text = "";
                tbcpf.Text = "";
                tbend.Text = "";
                tbbairro.Text = "";
                tbcep.Text = "";
                tbcidade.Text = "";
                p.gravarPessoa();
            }
        }
    }
}
