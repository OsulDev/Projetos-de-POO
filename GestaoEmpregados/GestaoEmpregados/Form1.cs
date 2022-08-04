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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Empresa tabelaEmp)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Form fAdmin = new Form_Administrador();
            this.Hide();
            fAdmin.ShowDialog();
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            Form_Emp fEmp= new Form_Emp();
            this.Hide();
            fEmp.ShowDialog();
        }

        private void btn_engenheiro_Click(object sender, EventArgs e)
        {
            Form_Engenheiro fEngenheiro = new Form_Engenheiro();
            this.Hide();
            fEngenheiro.ShowDialog();
        }

        private void btn_gestor_Click(object sender, EventArgs e)
        {
            Form_Gestor fGestor = new Form_Gestor();
            this.Hide();
            fGestor.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_tabela ftabela = new Form_tabela();
            this.Hide();
            ftabela.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_jardineiro_Click_1(object sender, EventArgs e)
        {
            Form_Jardinheiro fjardineiro = new Form_Jardinheiro();
            this.Hide();
            fjardineiro.ShowDialog();
        }
    }
}
