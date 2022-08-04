using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportesGest
{
    public partial class Form1 : Form
    {
        double abecula; //Variaveis para usar no try and catch
        int letras = 0, numeros = 0, matriculaOPum = 0, matriculaOPdois = 0;

        public static Transporte arrayTransporte = new Transporte();

        public Form1()
        {
            InitializeComponent();

            //vai retirar as setas das numericUPdown
            numEstudante.Controls.RemoveAt(0);
            numIdoso.Controls.RemoveAt(0);
            numNormal.Controls.RemoveAt(0);

            //vai deixar as tabpages inacessiveis
            this.TransportePublico.Parent = null;
            this.Mercadorias.Parent = null;
            this.Taxi.Parent = null;
        }

        private void btn_bazar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        //Método para converter os rdb para string
        public string ConverterBotoesRadio()
        {
            if (rdb_normal.Checked)
            {             
                return "Normal";
            }
            else if (rdb_viva.Checked)
            {
                return "Viva";
            }
            else if (rdb_perigosa.Checked)
            {
                return "Perigosa";
            }
            return "";
        }

        public void VerificarMatricula()
        {
            //Uma breve explicação sobre esta função
            //aqui vou verificar se a textbox contém 2 números
            //se tiver 2 números irá adicionar +1 á variavel numeros
            //o mesmo acontece para as letras
            //so adiciona +1 aos números ou ás letras se a textbox tiverem 2 números ou 2 letras
            //assim é possivel controlar quantidade de letras e numeros que a matricula pode ter
            if (String.Join("", Regex.Split(txtMatricula1.Text, @"[^\d]")).Length == 2)
            {
                numeros++;
            }

            if (String.Join("", Regex.Split(txtMatricula1.Text, @"[^[a-zA-Z]")).Length == 2)
            {
                letras++;
            }

            if (String.Join("", Regex.Split(txtMatricula2.Text, @"[^\d]")).Length == 2)
            {
                numeros++;
            }

            if (String.Join("", Regex.Split(txtMatricula2.Text, @"[^[a-zA-Z]")).Length == 2)
            {
                letras++;
            }

            if (String.Join("", Regex.Split(txtMatricula3.Text, @"[^\d]")).Length == 2)
            {
                numeros++;
            }

            if (String.Join("", Regex.Split(txtMatricula3.Text, @"[^[a-zA-Z]")).Length == 2)
            {
                letras++;
            }
        }

        //é o que o nome pretende
        public void LimparTudo()
        {
            comb_tiposVeiculos.Text = "";
            txt_condutor.Text = "";
            txtMatricula1.Text = "";
            txtMatricula2.Text = "";
            txtMatricula3.Text = "";
            comb_Combustivel.SelectedIndex = -1;
            txt_km.Text = "";
            txt_DuracaoTaxi.Text = "";
            txt_PesoTransporte.Text = "";
            txt_DuracaoTransporte.Text = "";
            txt_precoBilhete.Text = "";
            numNormal.Text = "0";
            numIdoso.Text = "0";
            numEstudante.Text = "0";
            rdb_normal.Checked = false;
            rdb_viva.Checked = false;
            rdb_perigosa.Checked = false;
        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            //--------ESTE CÓDIGO VAI VERIFICAR SE A COMBOBOX DO TIPO DE VEICULO ESTÁ SELECIONADA-------
            try
            {
                if (comb_tiposVeiculos.SelectedIndex == -1)
                {
                    throw new SelecioneTipoTransporteException();
                }
            }
            catch (SelecioneTipoTransporteException selecioneTipoVeiculo)
            {
                MessageBox.Show(selecioneTipoVeiculo.Message);
            }

            //---------Converter as textboxs para string-----------
            string txtCondutor = txt_condutor.Text;
            string txtMatricula = txtMatricula1.Text.ToUpper() + "-" + txtMatricula2.Text.ToUpper() + "-" + txtMatricula3.Text.ToUpper();
            string txtCombustivel = comb_Combustivel.Text;
            string txtKm = txt_km.Text;
            string txtDuracaoTaxi = txt_DuracaoTaxi.Text;
            string txtPesoDuracao = txt_PesoTransporte.Text;
            string txtDuracaoTransporte = txt_DuracaoTransporte.Text;
            string txtPrecoBilhete = txt_precoBilhete.Text;
            string txtPrecoNormal = numNormal.Text;
            string txtPrecoIdoso = numIdoso.Text;
            string txtPrecoEstudante = numEstudante.Text;

            
            //-------------------Criar os objetos-------------------
            try
            {
                switch (comb_tiposVeiculos.Text)
                {
                    case ("Mercadoria"):

                        if (txt_km.Text.Contains("."))      //Vai converter os pontos em vírgulas do Km :)
                        {
                            txt_km.Text = txt_km.Text.Replace(".", ",");
                            txtKm = txt_km.Text;
                        }

                        if (txt_DuracaoTransporte.Text.Contains("."))      //Vai converter os pontos em vírgulas da duração do transporte
                        {
                            txt_DuracaoTransporte.Text = txt_DuracaoTransporte.Text.Replace(".", ",");
                            txtDuracaoTransporte = txt_DuracaoTransporte.Text;
                        }

                        if (txt_PesoTransporte.Text.Contains("."))      //Vai converter os pontos em vírgulas da duração do peso
                        {
                            txt_PesoTransporte.Text = txt_PesoTransporte.Text.Replace(".", ",");
                            txtPesoDuracao = txt_PesoTransporte.Text;
                        }

                        if (txtCondutor.Equals(""))   //Vai dar erro se o nome for vazio
                            throw new NomeVazioException();

                        if (txtKm.Equals(""))   //Vai dar erro se os Km forem vazios
                            throw new KmVazioException();

                        if (!double.TryParse(txt_km.Text, out abecula))   //Vai dar erro se os km não forem double
                            throw new KmErradoException();

                        if (txtPesoDuracao.Equals(""))   //Vai dar erro se o peso for vazio
                            throw new PesoVazioException();

                        if (!double.TryParse(txt_km.Text, out abecula))   //Vai dar erro se o peso não for double
                            throw new PesoErradoException();

                        if (txtDuracaoTransporte.Equals(""))   //Vai dar erro se o peso for vazio
                            throw new DuracaoVaziaException();

                        //Vai tentar transformar a textbox em double e se não conseguir manda erro
                        if (!double.TryParse(txt_DuracaoTransporte.Text, out abecula))
                            throw new DuracaoErradaException();

                        if (txtKm.Equals("0") & double.TryParse(txt_DuracaoTransporte.Text, out abecula))
                            throw new KmZeroMinutosUmException();
                            //Vai dar erro se os Km forem 0 e a duração maior que 0

                        if (txt_DuracaoTransporte.Text.Equals("0") & double.TryParse(txt_km.Text, out abecula))
                            throw new MinutosZeroKmUmException();
                        //Vai dar erro se a duração for 0 e os Km maior que 0

                        if (txt_PesoTransporte.Text.Equals("0"))
                            throw new PesoTransportadoZeroException();

                        Mercadoria mercadoria1 = new Mercadoria(txtCondutor, txtMatricula, txtCombustivel, Convert.ToDouble(txtKm), Convert.ToDouble(txtDuracaoTransporte), Convert.ToDouble(txtPesoDuracao), ConverterBotoesRadio());

                        if (mercadoria1.CalculaCobranca() == -1.1)  //Vai dar erro se não escolher o tipo de carga
                            throw new TipoCargaVazioException();

                        if (txtCondutor.Length < 5 | !Regex.IsMatch(txtCondutor, @"^[A-Z][a-zãõçé]+\s+[A-Z][a-zãõçé.]+$"))
                            throw new NomeInvalidoException();  //Vai dar erro se o nome não for válido

                        VerificarMatricula();
                        if (numeros != 2 | letras != 1)     //Vai dar erro se a matrícula não for válida
                        {
                            throw new MatriculaInvalidaException();  
                        }
                        //se a variavel não tiver 4 números(numeros = 2) e 2 letras(letras = 1) vai dar erro :)
                        
                        numeros = 0;
                        letras = 0;

                        if (comb_Combustivel.SelectedIndex == -1)   //Vai dar erro se não selecionar o combustivel
                            throw new EscolhaCombustivelInvalidaException();

                        MessageBox.Show("Valores inseridos!");
                        Form1.arrayTransporte.AdicionarTransporte(mercadoria1);
                        break;

                    case ("Transporte Público"):

                        if (txt_km.Text.Contains("."))      //Vai converter os pontos em vírgulas do Km :)
                        {
                            txt_km.Text = txt_km.Text.Replace(".", ",");
                            txtKm = txt_km.Text;
                        }

                        if (txt_precoBilhete.Text.Contains("."))      //Vai converter os pontos em vírgulas do preço do bilhete
                        {
                            txt_precoBilhete.Text = txt_precoBilhete.Text.Replace(".", ",");
                            txtPrecoBilhete = txt_precoBilhete.Text;
                        }

                        if (txtCondutor.Equals(""))   //Vai dar erro se o nome for vazio
                            throw new NomeVazioException();

                        if (txtKm.Equals(""))   //Vai dar erro se os Km forem vazios
                            throw new KmVazioException();

                        if (!double.TryParse(txt_km.Text, out abecula))   //Vai dar erro se os km não forem double
                            throw new KmErradoException();

                        if (txtPrecoBilhete.Equals(""))   //Vai dar erro se o preço dos bilhetes forem vazios
                            throw new PrecoBilheteVazioException();

                        if (!double.TryParse(txt_precoBilhete.Text, out abecula))   //Vai dar erro se os preços dos bilhetes não forem double
                            throw new PrecoBilheteErradoException();

                        if (txtKm.Equals("0"))  //Vai dar erro se os Km forem zero :(
                            throw new KmZeroException();

                        TransportePublico transportepublico1 = new TransportePublico(txtCondutor, txtMatricula, txtCombustivel, Convert.ToDouble(txtKm), Convert.ToDouble(txtPrecoBilhete), Convert.ToInt32(txtPrecoEstudante), Convert.ToInt32(txtPrecoIdoso), Convert.ToInt32(txtPrecoNormal));

                        if (transportepublico1.CalculaCobranca() == -1.1)   //Vai dar erro se não inserir nenhum bilhete
                            throw new QuantidadeBilhetesVazioException();

                        if (txtCondutor.Length < 5 | !Regex.IsMatch(txtCondutor, @"^[A-Z][a-zãõçé]+\s+[A-Z][a-zãõçé.]+$"))
                            throw new NomeInvalidoException();  //Vai dar erro se o nome não for válido

                        VerificarMatricula();
                        //Estes 2 Ifs vão permitir usar matrículas com 4 números e 2 letras ou 4 letras e 2 números
                        if (numeros == 2 & letras == 1)
                        {
                            matriculaOPum = 1;
                        }

                        if (numeros == 1 & letras == 2)
                        {
                            matriculaOPdois = 1;
                        }

                        if (matriculaOPum != 1 & matriculaOPdois != 1)     //Vai dar erro se a matrícula não for válida
                        {
                            throw new MatriculaInvalidaException();  
                        }
                        //se a variavel não tiver 4 números(numeros = 2) e 2 letras(letras = 1) vai dar erro :)
                        
                        
                        numeros = 0;
                        letras = 0;

                        if (comb_Combustivel.SelectedIndex == -1)   //Vai dar erro se não selecionar o combustivel
                            throw new EscolhaCombustivelInvalidaException();

                        MessageBox.Show("Valores inseridos!");
                        Form1.arrayTransporte.AdicionarTransporte(transportepublico1);
                        break;

                    case ("Taxi"):

                        if (txt_km.Text.Contains("."))      //Vai converter os pontos em vírgulas do Km
                        {
                            txt_km.Text = txt_km.Text.Replace(".", ",");
                            txtKm = txt_km.Text;
                        }

                        if (txt_DuracaoTaxi.Text.Contains("."))      //Vai converter os pontos em vírgulas da duração do taxi
                        {
                            txt_DuracaoTaxi.Text = txt_DuracaoTaxi.Text.Replace(".", ",");
                            txtDuracaoTaxi = txt_DuracaoTaxi.Text;
                        }

                        if (txtCondutor.Equals(""))   //Vai dar erro se o nome for vazio
                            throw new NomeVazioException();

                        if (txtCondutor.Length < 5 | !Regex.IsMatch(txtCondutor, @"^[A-Z][a-zãõçé]+\s+[A-Z][a-zãõçé.]+$")) 
                            throw new NomeInvalidoException();  //Vai dar erro se o nome não for válido

                        if (comb_Combustivel.SelectedIndex == -1)   //Vai dar erro se não selecionar o combustivel
                            throw new EscolhaCombustivelInvalidaException();

                        if (txtKm.Equals(""))   //Vai dar erro se os Km forem vazios
                            throw new KmVazioException();

                        if (!double.TryParse(txt_km.Text, out abecula))   //Vai dar erro se os km não forem double
                            throw new KmErradoException();

                        if (txtDuracaoTaxi.Equals(""))   //Vai dar erro se os Km forem vazios
                            throw new DuracaoTaxiVaziaException();

                        if (!double.TryParse(txt_DuracaoTaxi.Text, out abecula))  //Vai dar erro se a duração do taxi não inteira
                            throw new DuracaoTaxiErradaException();

                        if (txtKm.Equals("0") & double.TryParse(txt_DuracaoTaxi.Text, out abecula))
                            throw new KmZeroMinutosUmException();
                            //Vai dar erro se os Km forem 0 e a duração maior que 0

                        if (txt_DuracaoTaxi.Text.Equals("0") & double.TryParse(txt_km.Text, out abecula))
                            throw new MinutosZeroKmUmException();
                            //Vai dar erro se a duração for 0 e os Km maior que 0

                        Taxi taxi1 = new Taxi(txtCondutor, txtMatricula, txtCombustivel, Convert.ToDouble(txtKm), Convert.ToDouble(txtDuracaoTaxi));

                        VerificarMatricula();
                        if (numeros != 2 | letras != 1)     //Vai dar erro se a matrícula não for válida
                        {
                            throw new MatriculaInvalidaException();  
                        }
                        //se a variavel não tiver 4 números(numeros = 2) e 2 letras(letras = 1) vai dar erro :)

                        numeros = 0; 
                        letras = 0; //É preciso dar um reset nas variáveis a cada ciclo

                        MessageBox.Show("Valores inseridos!");
                        Form1.arrayTransporte.AdicionarTransporte(taxi1);
                        break;
                    default:
                        break;
                }
            }


            //-----------AQUI É UM MONTE DE CATCH PARA MOSTRAR A MENSAGEM DE ERRO-----------

            catch (NomeVazioException nomeVazio)
            {
                MessageBox.Show(nomeVazio.Message);
            }

            catch (NomeInvalidoException nomeInvalido)
            {
                MessageBox.Show(nomeInvalido.Message);
            }

            catch (EscolhaCombustivelInvalidaException combustivelInvalido)
            {
                MessageBox.Show(combustivelInvalido.Message);
            }

            catch (MatriculaInvalidaException matriculaInvalida)
            {
                MessageBox.Show(matriculaInvalida.Message);
            }

            catch (TipoCargaVazioException tipoCargaVazio)
            {
                MessageBox.Show(tipoCargaVazio.Message);
            }

            catch (KmVazioException kmVazio)
            {
                MessageBox.Show(kmVazio.Message);
            }

            catch (PesoVazioException pesoVazio)
            {
                MessageBox.Show(pesoVazio.Message);
            }

            catch (DuracaoVaziaException duracaoVazia)
            {
                MessageBox.Show(duracaoVazia.Message);
            }

            catch (DuracaoErradaException duracaoErrada)
            {
                MessageBox.Show(duracaoErrada.Message);
            }

            catch (DuracaoTaxiVaziaException duracaoTaxiVazia)
            {
                MessageBox.Show(duracaoTaxiVazia.Message);
            }

            catch (DuracaoTaxiErradaException duracaoTaxiErrada)
            {
                MessageBox.Show(duracaoTaxiErrada.Message);
            }

            catch (QuantidadeBilhetesVazioException quantidadeBilhetesVazio)
            {
                MessageBox.Show(quantidadeBilhetesVazio.Message);
            }

            catch (PrecoBilheteVazioException precoBilheteVazio)
            {
                MessageBox.Show(precoBilheteVazio.Message);
            }

            catch (PrecoBilheteErradoException precoBilheteErrado)
            {
                MessageBox.Show(precoBilheteErrado.Message);
            }

            catch (KmZeroMinutosUmException kmZeroMinutosUm)
            {
                MessageBox.Show(kmZeroMinutosUm.Message);
            }

            catch (MinutosZeroKmUmException minutosZeroKmUm)
            {
                MessageBox.Show(minutosZeroKmUm.Message);
            }

            catch (KmZeroException kmZero)
            {
                MessageBox.Show(kmZero.Message);
            }

            catch (PesoTransportadoZeroException pesoTransportadoZero)
            {
                MessageBox.Show(pesoTransportadoZero.Message);
            }

            catch (OverflowException)
            {
                MessageBox.Show("Ocorreu um erro ao calcular a cobrança! Os valores inseridos ultrapassaram o limite!");
            }

            catch (Exception Erro) //Esta exceção está aqui caso haja algum erro mas em princípio não deve haver
            {                      //Por isso tanto faz ela estar aqui ou não
                MessageBox.Show(Erro.Message);
            }

            matriculaOPum = 0;
            matriculaOPdois = 0;
            numeros = 0; //Quando adicionar um transporte as variáveis (numeros & letras) continuam com o mesmo valor
            letras = 0; //Por isso é preciso dar um reset nas variáveis

            LimparTudo();
        }


        //---------DEPENDENDO DO TRANSPORTE SELECIONADO, IRÁ PARA A TABPAGE DO MESMO---------- (não sei bem como descrever...)
        private void comb_tiposVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_tiposVeiculos.SelectedIndex == 0) //seleciona mercadoria
            {
                this.Mercadorias.Parent = this.tabControl1;
                this.TransportePublico.Parent = null;
                this.Taxi.Parent = null;
                tabControl1.SelectedIndex = 0;
            }
            if (comb_tiposVeiculos.SelectedIndex == 1) //seleciona transporte publico
            {
                this.TransportePublico.Parent = this.tabControl1;
                this.Mercadorias.Parent = null;
                this.Taxi.Parent = null;
                tabControl1.SelectedIndex = 1;
            }
            if (comb_tiposVeiculos.SelectedIndex == 2) //seleciona taxi
            {
                this.Taxi.Parent = this.tabControl1;
                this.TransportePublico.Parent = null;
                this.Mercadorias.Parent = null;
                tabControl1.SelectedIndex = 2;
            }                 
        }
    }
}
                //510 linhas de código!!!!!!! :D