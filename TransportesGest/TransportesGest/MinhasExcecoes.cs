using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportesGest
{
    public class NomeInvalidoException:Exception
    {
        public NomeInvalidoException():base(string.Format("O seu nome não é válido!")) { }
    }

    public class SelecioneTipoTransporteException : Exception
    {
        public SelecioneTipoTransporteException() : base(string.Format("Selecione o tipo de veículo!")) { }
    }

    public class EscolhaCombustivelInvalidaException:Exception
    {
        public EscolhaCombustivelInvalidaException() : base(string.Format("Ocorreu um erro. Insira o tipo de combústivel!")) { }
    }

    public class MatriculaInvalidaException : Exception
    {
        public MatriculaInvalidaException() : base(string.Format("A sua matrícula não é válida!")) { }
    }

    public class KmVazioException : Exception
    {
        public KmVazioException() : base(string.Format("Ocorreu um erro. Insira a quantidade de kilómetros percorridos!")) { }
    }

    public class KmErradoException : Exception
    {
        public KmErradoException() : base(string.Format("Ocorreu um erro. A quantidade de kilómetros foi mal introduzida!")) { }
    }

    public class KmZeroException : Exception
    {
        public KmZeroException() : base(string.Format("Ocorreu um erro. A quantidade de kilómetros têm de ser superior a zero!")) { }
    }

    public class PesoTransportadoZeroException : Exception
    {
        public PesoTransportadoZeroException() : base(string.Format("Ocorreu um erro. A quantidade de peso transportado têm de ser superior a zero!")) { }
    }

    public class PesoVazioException : Exception
    {
        public PesoVazioException() : base(string.Format("Ocorreu um erro. Insira a quantidade de peso transportado!")) { }
    }

    public class NomeVazioException : Exception
    {
        public NomeVazioException() : base(string.Format("Ocorreu um erro. Insira o seu nome!")) { }
    }

    public class PesoErradoException : Exception
    {
        public PesoErradoException() : base(string.Format("Ocorreu um erro. A quantidade de peso foi mal introduzida!")) { }
    }

    public class DuracaoVaziaException : Exception
    {
        public DuracaoVaziaException() : base(string.Format("Ocorreu um erro. Insira a duração percorrida pelo transporte!")) { }
    }

    public class DuracaoErradaException : Exception
    {
        public DuracaoErradaException() : base(string.Format("Ocorreu um erro. A duração do transporte foi mal introduzida!")) { }
    }

    public class DuracaoTaxiVaziaException : Exception
    {
        public DuracaoTaxiVaziaException() : base(string.Format("Ocorreu um erro. Insira a duração percorrida pelo taxi!")) { }
    }

    public class DuracaoTaxiErradaException : Exception
    {
        public DuracaoTaxiErradaException() : base(string.Format("Ocorreu um erro. A duração do taxi foi mal introduzida!")) { }
    }

    public class KmZeroMinutosUmException : Exception
    {
        public KmZeroMinutosUmException() : base(string.Format("Ocorreu um erro. É impossivel percorrer zero kilómetros quando adicionou a duração!")) { }
    }

    public class MinutosZeroKmUmException : Exception
    {
        public MinutosZeroKmUmException() : base(string.Format("Ocorreu um erro. É impossivel dizer que percorreu esses kilómetros quando a duração é zero!")) { }
    }

    public class TipoCargaVazioException : Exception
    {
        public TipoCargaVazioException() : base(string.Format("Ocorreu um erro. Inseriu o tipo de carga?")) { }
    }

    public class QuantidadeBilhetesVazioException : Exception
    {
        public QuantidadeBilhetesVazioException() : base(string.Format("Ocorreu um erro. Inseriu a quantidade de bilhetes vendidos?")) { }
    }

    public class PrecoBilheteVazioException : Exception
    {
        public PrecoBilheteVazioException() : base(string.Format("Ocorreu um erro. Insira o preço dos bilhetes!")) { }
    }

    public class PrecoBilheteErradoException : Exception
    {
        public PrecoBilheteErradoException() : base(string.Format("Ocorreu um erro. O preço introduzido não é válido!")) { }
    }
}
