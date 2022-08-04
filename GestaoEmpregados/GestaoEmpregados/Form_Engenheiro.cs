using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEmpregados
{
    public partial class Form_Engenheiro : Form
    {
        public Form_Engenheiro()
        {
            InitializeComponent();
        }

        private void Form_Engenheiro_Load(object sender, EventArgs e)
        {

        }

        private void btn_EngenheiroSubmeter_Click(object sender, EventArgs e)
        {
            string nomeEngenheiroTxt = txt_nomeEngenheiro.Text;
            string nifEngenheiroTxt = txt_nifEngenheiro.Text;
            string numEngenheiroTxt = txt_numEngenheiro.Text;
            string premioSalarioTxt = txt_premioSalario.Text;

            Engenheiro engenheiro1 = new Engenheiro(nomeEngenheiroTxt, Convert.ToInt32(nifEngenheiroTxt), Convert.ToInt32(numEngenheiroTxt), Convert.ToDouble(premioSalarioTxt));
            FormIni.tabelaEmp.AdicionarEmp(engenheiro1);

            MessageBox.Show("Valor inserido!");
            txt_nomeEngenheiro.Text = "";
            txt_nifEngenheiro.Text = "";
            txt_numEngenheiro.Text = "";
            txt_premioSalario.Text = "";
        }

        private void btn_menuEmp_Click_1(object sender, EventArgs e)
        {
            Form1 fMenu = new Form1();
            fMenu.Show();
            this.Close();
        }
    }
}
