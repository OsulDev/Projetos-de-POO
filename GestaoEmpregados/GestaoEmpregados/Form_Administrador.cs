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
    public partial class Form_Administrador : Form
    {
        public Form_Administrador()
        {
            InitializeComponent();
        }

        private void btn_menuEmp_Click(object sender, EventArgs e)
        {
            Form fMenu = new Form1();
            fMenu.Show();
            this.Close();
        }

        private void Form_Administrador_Load(object sender, EventArgs e)
        {

        }

        private void btn_AdminSubmeter_Click(object sender, EventArgs e)
        {
            string nomeAdminTxt = txt_nomeAdmin.Text;
            string nifAdminTxt = txt_nifAdmin.Text;
            string numAdminTxt = txt_numAdmin.Text;
            string numpromTxt = txt_numpromTxt.Text;

            Administrador admin1 = new Administrador(nomeAdminTxt, Convert.ToInt32(nifAdminTxt), Convert.ToInt32(numAdminTxt), Convert.ToInt32(numpromTxt));
            FormIni.tabelaEmp.AdicionarEmp(admin1);

            MessageBox.Show("Valor inserido!");
            txt_nomeAdmin.Text = "";
            txt_nifAdmin.Text = "";
            txt_numAdmin.Text = "";
            txt_numpromTxt.Text = "";
        }
    }
}
