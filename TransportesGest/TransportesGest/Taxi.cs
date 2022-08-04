using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportesGest
{
    public class Taxi:Transporte
    {
        private double duracao;

        private const double TARIFA_ENTRADA = 45.5;


        //-------------CONSTRUTOR--------------
        public Taxi(string condutor, string matricula, string combustivel, double km, double duracao) : base(condutor, matricula, combustivel, km)
        {
            this.duracao = duracao;
        }


        //-------------GETTER'S E SETTER'S------------
        public double Duracao
        {
            get { return duracao; }
            set { duracao = value; }
        }



        //-------------MÉTODOS--------------
        public override double CalculaCobranca()
        {
            return Km * base.CalculaCobranca() * duracao;
        }

        public override string TipoTransporte
        {
            get
            {
                return "Taxi";
            }
        }

        public override string ToString()
        {
            return "Duração: " + duracao + " Tarifa de entrada: " + TARIFA_ENTRADA;
        }
    }
}
