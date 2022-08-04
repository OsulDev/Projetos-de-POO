using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportesGest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //--------CRIAÇÃO DAS COLUNAS-------------
            dataGridView1.Columns.Add("Cobranca", "A COBRAR");
            dataGridView1.Columns.Add("Matricula", "Matrícula");
            dataGridView1.Columns.Add("Combustivel", "Combustível");
            dataGridView1.Columns.Add("Km", "Km");
            dataGridView1.Columns.Add("Condutor", "Condutor");
            dataGridView1.Columns.Add("TipoVeiculo", "Tipo de Veículo");
            dataGridView1.Columns.Add("Peso", "Peso");
            dataGridView1.Columns.Add("Duracao", "Duração");
            dataGridView1.Columns.Add("TipoCarga", "Tipo de Carga");
            dataGridView1.Columns.Add("PrecoBilhete", "Preço do Bilhete");



            //--------POR OS OBJETOS NO DATAGRIDVIEW1-------------
            for (int i = 0; i < Form1.arrayTransporte.NumTransporte; i++)
            {
                switch (Form1.arrayTransporte.TabelaTransportes[i].GetType().Name.ToString())
                {
                    case "Mercadoria":
                        dataGridView1.Rows.Add(Form1.arrayTransporte.TabelaTransportes[i].CalculaCobranca() + "€", Form1.arrayTransporte.TabelaTransportes[i].Matricula, Form1.arrayTransporte.TabelaTransportes[i].Combustivel, Form1.arrayTransporte.TabelaTransportes[i].Km, Form1.arrayTransporte.TabelaTransportes[i].Condutor, Form1.arrayTransporte.TabelaTransportes[i].TipoTransporte, ((Mercadoria)Form1.arrayTransporte.TabelaTransportes[i]).Peso, ((Mercadoria)Form1.arrayTransporte.TabelaTransportes[i]).Duracao, ((Mercadoria)Form1.arrayTransporte.TabelaTransportes[i]).TipoCarga, "-");
                        break;
                    case "TransportePublico":
                        dataGridView1.Rows.Add(((TransportePublico)Form1.arrayTransporte.TabelaTransportes[i]).CalculaCobranca() + "€", Form1.arrayTransporte.TabelaTransportes[i].Matricula, Form1.arrayTransporte.TabelaTransportes[i].Combustivel, Form1.arrayTransporte.TabelaTransportes[i].Km, Form1.arrayTransporte.TabelaTransportes[i].Condutor, Form1.arrayTransporte.TabelaTransportes[i].TipoTransporte, "-", "-", "-", ((TransportePublico)Form1.arrayTransporte.TabelaTransportes[i]).PrecoBilhete + "€");
                        break;
                    case "Taxi":
                        dataGridView1.Rows.Add(((Taxi)Form1.arrayTransporte.TabelaTransportes[i]).CalculaCobranca() + "€", Form1.arrayTransporte.TabelaTransportes[i].Matricula, Form1.arrayTransporte.TabelaTransportes[i].Combustivel, Form1.arrayTransporte.TabelaTransportes[i].Km, Form1.arrayTransporte.TabelaTransportes[i].Condutor, Form1.arrayTransporte.TabelaTransportes[i].TipoTransporte, "-", "-", "-", "-");
                        break;
                    default:
                        break;
                }
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSize = true;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
