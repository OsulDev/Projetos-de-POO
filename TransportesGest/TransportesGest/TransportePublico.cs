using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportesGest
{
    public class TransportePublico : Transporte
    {

        private double precoBilhete;
        private int qtddEstudante;
        private int qtddIdoso;
        private int qtddNormal;


        //-------------CONSTRUTOR--------------
        public TransportePublico(string condutor, string matricula, string combustivel, double km, double precoBilhete, int qtddEstudante, int qtddIdoso, int qtddNormal) : base(condutor, matricula, combustivel, km)
        {
            this.precoBilhete = precoBilhete;
            this.qtddEstudante = qtddEstudante;
            this.qtddIdoso = qtddIdoso;
            this.qtddNormal = qtddNormal;
        }


        //--------GETTER'S E SETTER'S---------
        public double PrecoBilhete
        {
            get
            {
                return precoBilhete;
            }

            set
            {
                precoBilhete = value;
            }
        }

        public int QtddEstudante
        {
            get
            {
                return qtddEstudante;
            }

            set
            {
                qtddEstudante = value;
            }
        }

        public int QtddIdoso
        {
            get
            {
                return qtddIdoso;
            }

            set
            {
                qtddIdoso = value;
            }
        }

        public int QtddNormal
        {
            get
            {
                return qtddNormal;
            }

            set
            {
                qtddNormal = value;
            }
        }


        //-------------MÉTODOS--------------
        public override string TipoTransporte
        {
            get
            {
                return "Transporte Publico";
            }
        }


        public override double CalculaCobranca()
        {
            double amostra = ((qtddNormal * precoBilhete) + (qtddIdoso * (precoBilhete * 0.5)) + (qtddEstudante * (precoBilhete * 0.8))) * base.Km;
            if (amostra == 0)
            {
                return -1.1;
            }
            return amostra;
        }

        public override string ToString()
        {
            return "Preço do Bilhete: " + precoBilhete + " Quantidade de Bilhetes de Estudantes: " + qtddEstudante + " Quantidade de Bihetes de Idosos: " + qtddIdoso + " Quantidade de Bilhetes Normais: " + qtddNormal;
        }
    }
}
