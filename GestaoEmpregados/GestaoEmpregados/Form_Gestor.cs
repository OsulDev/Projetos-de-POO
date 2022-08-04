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
    public partial class Form_Gestor : Form
    {

        public Form_Gestor()
        {
            InitializeComponent();
        }

        private void btn_menuEmp_Click(object sender, EventArgs e)
        {
            Form1 fMenu = new Form1();
            fMenu.Show();
            this.Close();
        }

        private void Form_Gestor_Load(object sender, EventArgs e)
        {

        }

        private void btn_GestorSubmeter_Click(object sender, EventArgs e)
        {
            string nomeGestorTxt = txt_nomeGestor.Text;
            string nifGestorTxt = txt_nifGestor.Text;
            string numGestorTxt = txt_numGestor.Text;
            string suplementoGestorTxt = txt_suplementoSlr.Text;

            Gestor gestor1 = new Gestor(nomeGestorTxt, Convert.ToInt32(nifGestorTxt), Convert.ToInt32(numGestorTxt), Convert.ToDouble(suplementoGestorTxt));
            FormIni.tabelaEmp.AdicionarEmp(gestor1);

            MessageBox.Show("Valor inserido!");
            txt_nomeGestor.Text = "";
            txt_nifGestor.Text = "";
            txt_numGestor.Text = "";
            txt_suplementoSlr.Text = "";
        }
    }
}
