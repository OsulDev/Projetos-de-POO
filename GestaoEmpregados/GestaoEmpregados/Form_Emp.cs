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
    public partial class Form_Emp : Form
    {
        public Form_Emp()
        {
            InitializeComponent();

        }

        private void btn_menuEmp_Click(object sender, EventArgs e)
        {           
            Form1 fMenu = new Form1();
            fMenu.Show(); 
            this.Close();
        }

        private void Form_Emp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeEmpTxt = txt_nomeEmp.Text;
            string nifEmpTxt = txt_nifEmp.Text;
            string numEmpTxt = txt_numEmp.Text;

            Empregado emp1 = new Empregado(nomeEmpTxt, Convert.ToInt32(nifEmpTxt), Convert.ToInt32(numEmpTxt));
            FormIni.tabelaEmp.AdicionarEmp(emp1);

            MessageBox.Show("Valor inserido!");
            txt_nomeEmp.Text = "";
            txt_nifEmp.Text = "";
            txt_numEmp.Text = "";
        }
    }
}
