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
    public partial class Form_Jardinheiro : Form
    {
        public Form_Jardinheiro()
        {
            InitializeComponent();
        }

        private void btn_JardineiroSubmeter_Click(object sender, EventArgs e)
        {
            string nomeJardineiroTxt = txt_nomeJardineiro.Text;
            string nifJardineiroTxt = txt_nifJardineiro.Text;
            string numJardineiroTxt = txt_numJardineiro.Text;
            string subsidioAlimentarTxt = txt_subsidio_alimentar.Text;

            Jardineiro jardineiro1 = new Jardineiro(nomeJardineiroTxt, Convert.ToInt32(nifJardineiroTxt), Convert.ToInt32(numJardineiroTxt), Convert.ToDouble(subsidioAlimentarTxt));
            FormIni.tabelaEmp.AdicionarEmp(jardineiro1);

            MessageBox.Show("Valor inserido!");
            txt_nomeJardineiro.Text = "";
            txt_nifJardineiro.Text = "";
            txt_numJardineiro.Text = "";
            txt_subsidio_alimentar.Text = "";
        }

        private void btn_menuEmp_Click(object sender, EventArgs e)
        {
            Form1 fMenu = new Form1();
            fMenu.Show();
            this.Close();
        }
    }
}
