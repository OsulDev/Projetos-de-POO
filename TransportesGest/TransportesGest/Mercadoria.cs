using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportesGest
{
    public class Mercadoria:Transporte
    {
        private double duracao;
        private double peso;
        private string tipoCarga;

        private const double PREMIO_CARGA = 599.99;



        //-------------CONSTRUTOR--------------
        public Mercadoria(string condutor, string matricula, string combustivel, double km, double duracao, double peso, string tipoCarga) : base(condutor, matricula, combustivel, km)
        {
            this.duracao = duracao;
            this.peso = peso;
            this.tipoCarga = tipoCarga;
        }


        //-------------GETTER'S E SETTER'S---------
        public double Duracao
        {
            get
            {
                return duracao;
            }

            set
            {
                duracao = value;
            }
        }

        public double Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public string TipoCarga
        {
            get
            {
                return tipoCarga;
            }

            set
            {
                tipoCarga = value;
            }
        }


        //-------------MÉTODOS--------------    
        public override double CalculaCobranca()
        {
            switch (tipoCarga)
            {
                case "Viva":
                    return (Km * base.CalculaCobranca() * duracao * peso + PREMIO_CARGA);
                case "Perigosa":
                    return (Km * base.CalculaCobranca() * duracao * peso + PREMIO_CARGA * 3);
                case "Normal":
                    return (Km * base.CalculaCobranca() * duracao * peso);
                default:
                    return -1.1;
                    //se retornar o " -1.1 " vai dar erro
            }
        }

        public override string TipoTransporte
        {
            get
            {
                return "Mercadoria";
            }
        }

        public override string ToString()
        {
            return "Duração: " + duracao + " Peso: " + peso + " Tipo de Carga: " + tipoCarga + " Prémio da Carga: " + PREMIO_CARGA;
        }
    }
}
