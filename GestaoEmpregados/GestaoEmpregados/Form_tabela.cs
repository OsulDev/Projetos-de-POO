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
    public partial class Form_tabela : Form
    {
        public Form_tabela()
        {
            InitializeComponent();
        }



        private void Form_tabela_Load(object sender, EventArgs e)
        {
            //--------CRIAÇÃO DAS COLUNAS-------------
            dataGrid.Columns.Add("Cargo","Cargo");
            dataGrid.Columns.Add("Nome", "Nome");
            dataGrid.Columns.Add("Num", "Número do Empregado");
            dataGrid.Columns.Add("NIF", "NIF");
            dataGrid.Columns.Add("NumPromo", "Número da Promoção");
            dataGrid.Columns.Add("Premio_salario", "Prémio do Salário");
            dataGrid.Columns.Add("Suplemento_salario", "Suplemento do Salário");
            dataGrid.Columns.Add("Subsidio_alimentar", "Subsídio de Alimentação");



            //--------INTRODUZ AS LINHAS COM OS RESPETIVOS DADOS-------------
            for (int i = 0; i < FormIni.tabelaEmp.NumEmps; i++)
            {
                switch (FormIni.tabelaEmp.TabelaEmps[i].GetType().Name.ToString())
                {
                    case "Administrador":
                        dataGrid.Rows.Add("Administrador", FormIni.tabelaEmp.TabelaEmps[i].NomeEmp, FormIni.tabelaEmp.TabelaEmps[i].NumEmp, FormIni.tabelaEmp.TabelaEmps[i].NifEmp, ((Administrador)FormIni.tabelaEmp.TabelaEmps[i]).NumPromo, "-", "-", "-");
                        break;
                    case "Engenheiro":
                        dataGrid.Rows.Add("Engenheiro", FormIni.tabelaEmp.TabelaEmps[i].NomeEmp, FormIni.tabelaEmp.TabelaEmps[i].NumEmp, FormIni.tabelaEmp.TabelaEmps[i].NifEmp, "-", ((Engenheiro)FormIni.tabelaEmp.TabelaEmps[i]).Premio_salario, "-", "-");
                        break;
                    case "Gestor":
                        dataGrid.Rows.Add("Gestor", FormIni.tabelaEmp.TabelaEmps[i].NomeEmp, FormIni.tabelaEmp.TabelaEmps[i].NumEmp, FormIni.tabelaEmp.TabelaEmps[i].NifEmp, "-", "-", ((Gestor)FormIni.tabelaEmp.TabelaEmps[i]).Suplemento_salario, "-");
                        break;
                    case "Jardineiro":
                        dataGrid.Rows.Add("Jardineiro", FormIni.tabelaEmp.TabelaEmps[i].NomeEmp, FormIni.tabelaEmp.TabelaEmps[i].NumEmp, FormIni.tabelaEmp.TabelaEmps[i].NifEmp, "-", "-","-", ((Jardineiro)FormIni.tabelaEmp.TabelaEmps[i]).Subsidio_alimentar);
                        break;
                    default:
                        dataGrid.Rows.Add("Empregado", FormIni.tabelaEmp.TabelaEmps[i].NomeEmp, FormIni.tabelaEmp.TabelaEmps[i].NumEmp, FormIni.tabelaEmp.TabelaEmps[i].NifEmp, "-", "-", "-","-");
                        break;
                }
            }

            dataGrid.AutoGenerateColumns = false;
            dataGrid.AutoSize = true;
        }



        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fMenu = new Form1();
            fMenu.Show();
            this.Close();
        }
    }
}