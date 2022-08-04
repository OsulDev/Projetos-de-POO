using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportesGest
{
    public class Transporte
    {
        private const double VALOR_BASE_KM = 1.0d;
        private const double VALOR_BASE_MINUTO = 0.4d;
        private const int MAX_TRANSPORTE = 50;

        private string condutor;
        private string matricula;
        private string combustivel;
        private double km;
        private Transporte[] tabelaTransportes;
        private int numTransporte;



        //-----------------CONSTRUTORES---------------------
        public Transporte(string condutor, string matricula, string combustivel, double km)
        {
            this.condutor = condutor;
            this.matricula = matricula;
            this.combustivel = combustivel;
            this.km = km;
        }

        public Transporte()
        {
            this.tabelaTransportes = new Transporte[MAX_TRANSPORTE];
            this.numTransporte = 0;
        }



        //-------------GETTER'S E SETTER'S------------------
        public string Condutor
        {
            get
            {
                return condutor;
            }

            set
            {
                condutor = value;
            }
        }

        public string Matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                matricula = value;
            }
        }

        public string Combustivel
        {
            get
            {
                return combustivel;
            }

            set
            {
                combustivel = value;
            }
        }

        public double Km
        {
            get
            {
                return km;
            }

            set
            {
                km = value;
            }
        }

        public Transporte[] TabelaTransportes
        {
            get
            {
                return tabelaTransportes;
            }

            set
            {
                tabelaTransportes = value;
            }
        }

        public int NumTransporte
        {
            get
            {
                return numTransporte;
            }

            set
            {
                numTransporte = value;
            }
        }



        //--------------------MÉTODOS----------------------
        public virtual string TipoTransporte
        {
            get { return "Transporte"; }
        }

        public override string ToString()
        {
            return TipoTransporte + " Condutor: " + Condutor + " Matricula: " + Matricula + " Combústivel: " + Combustivel + " Km: " + Km + " COBRANÇA: " + CalculaCobranca();
        }
        
        public virtual double CalculaCobranca()
        {
            return VALOR_BASE_MINUTO * VALOR_BASE_KM;
        }

        public void AdicionarTransporte(Transporte e)
        {
            if (numTransporte < MAX_TRANSPORTE)
            {
                tabelaTransportes[numTransporte++] = e;
            }
        }
    }
}
