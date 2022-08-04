namespace TransportesGest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_bazar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_registar = new System.Windows.Forms.Button();
            this.comb_tiposVeiculos = new System.Windows.Forms.ComboBox();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.txt_condutor = new System.Windows.Forms.TextBox();
            this.lbl_condutor = new System.Windows.Forms.Label();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.comb_Combustivel = new System.Windows.Forms.ComboBox();
            this.lbl_tipoVeiculo = new System.Windows.Forms.Label();
            this.lbl_combustivel = new System.Windows.Forms.Label();
            this.lbl_kmEfetuados = new System.Windows.Forms.Label();
            this.Taxi = new System.Windows.Forms.TabPage();
            this.pictureBoxTaxi = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_DuracaoTaxi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TransportePublico = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precoBilhete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numNormal = new System.Windows.Forms.NumericUpDown();
            this.numIdoso = new System.Windows.Forms.NumericUpDown();
            this.numEstudante = new System.Windows.Forms.NumericUpDown();
            this.Mercadorias = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rdb_perigosa = new System.Windows.Forms.RadioButton();
            this.rdb_viva = new System.Windows.Forms.RadioButton();
            this.rdb_normal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.txt_DuracaoTransporte = new System.Windows.Forms.TextBox();
            this.lbl_duracaoTransporte = new System.Windows.Forms.Label();
            this.lbl_toneladas = new System.Windows.Forms.Label();
            this.txt_PesoTransporte = new System.Windows.Forms.TextBox();
            this.lbl_pesoTransportado = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMatricula1 = new System.Windows.Forms.TextBox();
            this.txtMatricula2 = new System.Windows.Forms.TextBox();
            this.txtMatricula3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Taxi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaxi)).BeginInit();
            this.TransportePublico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdoso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstudante)).BeginInit();
            this.Mercadorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_bazar
            // 
            this.btn_bazar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_bazar.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold);
            this.btn_bazar.ForeColor = System.Drawing.Color.Black;
            this.btn_bazar.Location = new System.Drawing.Point(433, 379);
            this.btn_bazar.Name = "btn_bazar";
            this.btn_bazar.Size = new System.Drawing.Size(110, 54);
            this.btn_bazar.TabIndex = 21;
            this.btn_bazar.Text = "Sair";
            this.btn_bazar.UseVisualStyleBackColor = false;
            this.btn_bazar.Click += new System.EventHandler(this.btn_bazar_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.BackColor = System.Drawing.Color.Orange;
            this.btn_listar.Font = new System.Drawing.Font("Miriam Libre", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_listar.Location = new System.Drawing.Point(555, 360);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(174, 74);
            this.btn_listar.TabIndex = 20;
            this.btn_listar.Text = "LISTAR TRANSPORTES";
            this.btn_listar.UseVisualStyleBackColor = false;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_registar
            // 
            this.btn_registar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_registar.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registar.Location = new System.Drawing.Point(743, 367);
            this.btn_registar.Name = "btn_registar";
            this.btn_registar.Size = new System.Drawing.Size(135, 67);
            this.btn_registar.TabIndex = 19;
            this.btn_registar.Text = "REGISTAR TRANSPORTE";
            this.btn_registar.UseVisualStyleBackColor = false;
            this.btn_registar.Click += new System.EventHandler(this.btn_registar_Click);
            // 
            // comb_tiposVeiculos
            // 
            this.comb_tiposVeiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_tiposVeiculos.Font = new System.Drawing.Font("Miriam Libre", 10.2F, System.Drawing.FontStyle.Bold);
            this.comb_tiposVeiculos.FormattingEnabled = true;
            this.comb_tiposVeiculos.Items.AddRange(new object[] {
            "Mercadoria",
            "Transporte Público",
            "Taxi"});
            this.comb_tiposVeiculos.Location = new System.Drawing.Point(618, 37);
            this.comb_tiposVeiculos.Name = "comb_tiposVeiculos";
            this.comb_tiposVeiculos.Size = new System.Drawing.Size(204, 30);
            this.comb_tiposVeiculos.TabIndex = 1;
            this.comb_tiposVeiculos.SelectedIndexChanged += new System.EventHandler(this.comb_tiposVeiculos_SelectedIndexChanged);
            // 
            // txt_km
            // 
            this.txt_km.Font = new System.Drawing.Font("Miriam Libre", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_km.Location = new System.Drawing.Point(693, 291);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(115, 31);
            this.txt_km.TabIndex = 7;
            // 
            // txt_condutor
            // 
            this.txt_condutor.Font = new System.Drawing.Font("Miriam Libre", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_condutor.Location = new System.Drawing.Point(547, 102);
            this.txt_condutor.MaxLength = 101;
            this.txt_condutor.Name = "txt_condutor";
            this.txt_condutor.Size = new System.Drawing.Size(320, 30);
            this.txt_condutor.TabIndex = 2;
            // 
            // lbl_condutor
            // 
            this.lbl_condutor.AutoSize = true;
            this.lbl_condutor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_condutor.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_condutor.Location = new System.Drawing.Point(420, 106);
            this.lbl_condutor.Name = "lbl_condutor";
            this.lbl_condutor.Size = new System.Drawing.Size(121, 26);
            this.lbl_condutor.TabIndex = 6;
            this.lbl_condutor.Text = "CONDUTOR:";
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula.Location = new System.Drawing.Point(426, 173);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(132, 26);
            this.lbl_matricula.TabIndex = 7;
            this.lbl_matricula.Text = "MATRÍCULA:";
            // 
            // comb_Combustivel
            // 
            this.comb_Combustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_Combustivel.Font = new System.Drawing.Font("Miriam Libre", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_Combustivel.FormattingEnabled = true;
            this.comb_Combustivel.Items.AddRange(new object[] {
            "Híbrido",
            "Gasóleo",
            "Elétrico"});
            this.comb_Combustivel.Location = new System.Drawing.Point(595, 236);
            this.comb_Combustivel.Name = "comb_Combustivel";
            this.comb_Combustivel.Size = new System.Drawing.Size(142, 30);
            this.comb_Combustivel.TabIndex = 6;
            // 
            // lbl_tipoVeiculo
            // 
            this.lbl_tipoVeiculo.AutoSize = true;
            this.lbl_tipoVeiculo.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoVeiculo.Location = new System.Drawing.Point(428, 41);
            this.lbl_tipoVeiculo.Name = "lbl_tipoVeiculo";
            this.lbl_tipoVeiculo.Size = new System.Drawing.Size(179, 26);
            this.lbl_tipoVeiculo.TabIndex = 12;
            this.lbl_tipoVeiculo.Text = "TIPO DE VEÍCULO:";
            // 
            // lbl_combustivel
            // 
            this.lbl_combustivel.AutoSize = true;
            this.lbl_combustivel.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_combustivel.Location = new System.Drawing.Point(426, 240);
            this.lbl_combustivel.Name = "lbl_combustivel";
            this.lbl_combustivel.Size = new System.Drawing.Size(154, 26);
            this.lbl_combustivel.TabIndex = 13;
            this.lbl_combustivel.Text = "COMBÚSTIVEL:";
            // 
            // lbl_kmEfetuados
            // 
            this.lbl_kmEfetuados.AutoSize = true;
            this.lbl_kmEfetuados.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kmEfetuados.Font = new System.Drawing.Font("Miriam Libre", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kmEfetuados.Location = new System.Drawing.Point(426, 297);
            this.lbl_kmEfetuados.Name = "lbl_kmEfetuados";
            this.lbl_kmEfetuados.Size = new System.Drawing.Size(237, 25);
            this.lbl_kmEfetuados.TabIndex = 14;
            this.lbl_kmEfetuados.Text = "KILÓMETROS EFETUADOS:";
            // 
            // Taxi
            // 
            this.Taxi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.Taxi.Controls.Add(this.pictureBoxTaxi);
            this.Taxi.Controls.Add(this.label11);
            this.Taxi.Controls.Add(this.txt_DuracaoTaxi);
            this.Taxi.Controls.Add(this.label10);
            this.Taxi.Location = new System.Drawing.Point(4, 29);
            this.Taxi.Name = "Taxi";
            this.Taxi.Size = new System.Drawing.Size(394, 388);
            this.Taxi.TabIndex = 2;
            this.Taxi.Text = "Táxi";
            // 
            // pictureBoxTaxi
            // 
            this.pictureBoxTaxi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTaxi.Image")));
            this.pictureBoxTaxi.Location = new System.Drawing.Point(9, 168);
            this.pictureBoxTaxi.Name = "pictureBoxTaxi";
            this.pictureBoxTaxi.Size = new System.Drawing.Size(370, 217);
            this.pictureBoxTaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTaxi.TabIndex = 22;
            this.pictureBoxTaxi.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(98, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 26);
            this.label11.TabIndex = 23;
            this.label11.Text = "minutos (15,5)";
            // 
            // txt_DuracaoTaxi
            // 
            this.txt_DuracaoTaxi.Font = new System.Drawing.Font("Miriam Libre", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DuracaoTaxi.Location = new System.Drawing.Point(9, 92);
            this.txt_DuracaoTaxi.Name = "txt_DuracaoTaxi";
            this.txt_DuracaoTaxi.Size = new System.Drawing.Size(83, 40);
            this.txt_DuracaoTaxi.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Miriam Libre", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(329, 33);
            this.label10.TabIndex = 22;
            this.label10.Text = "DURAÇÃO DO TRANSPORTE:";
            // 
            // TransportePublico
            // 
            this.TransportePublico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.TransportePublico.Controls.Add(this.label7);
            this.TransportePublico.Controls.Add(this.txt_precoBilhete);
            this.TransportePublico.Controls.Add(this.label6);
            this.TransportePublico.Controls.Add(this.pictureBox1);
            this.TransportePublico.Controls.Add(this.label5);
            this.TransportePublico.Controls.Add(this.label4);
            this.TransportePublico.Controls.Add(this.label3);
            this.TransportePublico.Controls.Add(this.label2);
            this.TransportePublico.Controls.Add(this.numNormal);
            this.TransportePublico.Controls.Add(this.numIdoso);
            this.TransportePublico.Controls.Add(this.numEstudante);
            this.TransportePublico.Location = new System.Drawing.Point(4, 29);
            this.TransportePublico.Name = "TransportePublico";
            this.TransportePublico.Padding = new System.Windows.Forms.Padding(3);
            this.TransportePublico.Size = new System.Drawing.Size(394, 388);
            this.TransportePublico.TabIndex = 1;
            this.TransportePublico.Text = "Transporte Público";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Miriam Libre", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(349, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 37);
            this.label7.TabIndex = 21;
            this.label7.Text = "€";
            // 
            // txt_precoBilhete
            // 
            this.txt_precoBilhete.Font = new System.Drawing.Font("Miriam Libre", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precoBilhete.Location = new System.Drawing.Point(260, 39);
            this.txt_precoBilhete.Name = "txt_precoBilhete";
            this.txt_precoBilhete.Size = new System.Drawing.Size(83, 40);
            this.txt_precoBilhete.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Miriam Libre", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 33);
            this.label6.TabIndex = 20;
            this.label6.Text = "PREÇO DO BILHETE:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Miriam Libre", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "TIPO DE BILHETE / VENDIDO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Miriam Libre", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 17;
            this.label4.Text = "Estudante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Miriam Libre", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Idoso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Miriam Libre", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Normal:";
            // 
            // numNormal
            // 
            this.numNormal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numNormal.Font = new System.Drawing.Font("Miriam Libre", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNormal.Location = new System.Drawing.Point(317, 172);
            this.numNormal.Name = "numNormal";
            this.numNormal.Size = new System.Drawing.Size(77, 34);
            this.numNormal.TabIndex = 15;
            this.numNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numIdoso
            // 
            this.numIdoso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numIdoso.Font = new System.Drawing.Font("Miriam Libre", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIdoso.Location = new System.Drawing.Point(317, 247);
            this.numIdoso.Name = "numIdoso";
            this.numIdoso.Size = new System.Drawing.Size(77, 34);
            this.numIdoso.TabIndex = 16;
            this.numIdoso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numEstudante
            // 
            this.numEstudante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numEstudante.Font = new System.Drawing.Font("Miriam Libre", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEstudante.Location = new System.Drawing.Point(317, 317);
            this.numEstudante.Name = "numEstudante";
            this.numEstudante.Size = new System.Drawing.Size(77, 34);
            this.numEstudante.TabIndex = 17;
            this.numEstudante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Mercadorias
            // 
            this.Mercadorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.Mercadorias.Controls.Add(this.pictureBox3);
            this.Mercadorias.Controls.Add(this.rdb_perigosa);
            this.Mercadorias.Controls.Add(this.rdb_viva);
            this.Mercadorias.Controls.Add(this.rdb_normal);
            this.Mercadorias.Controls.Add(this.label1);
            this.Mercadorias.Controls.Add(this.lbl_horas);
            this.Mercadorias.Controls.Add(this.txt_DuracaoTransporte);
            this.Mercadorias.Controls.Add(this.lbl_duracaoTransporte);
            this.Mercadorias.Controls.Add(this.lbl_toneladas);
            this.Mercadorias.Controls.Add(this.txt_PesoTransporte);
            this.Mercadorias.Controls.Add(this.lbl_pesoTransportado);
            this.Mercadorias.Location = new System.Drawing.Point(4, 29);
            this.Mercadorias.Name = "Mercadorias";
            this.Mercadorias.Padding = new System.Windows.Forms.Padding(3);
            this.Mercadorias.Size = new System.Drawing.Size(394, 388);
            this.Mercadorias.TabIndex = 0;
            this.Mercadorias.Text = "Mercadorias";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(173, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(197, 172);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // rdb_perigosa
            // 
            this.rdb_perigosa.AutoSize = true;
            this.rdb_perigosa.Font = new System.Drawing.Font("Miriam Libre", 13.8F, System.Drawing.FontStyle.Underline);
            this.rdb_perigosa.Location = new System.Drawing.Point(9, 326);
            this.rdb_perigosa.Name = "rdb_perigosa";
            this.rdb_perigosa.Size = new System.Drawing.Size(134, 36);
            this.rdb_perigosa.TabIndex = 13;
            this.rdb_perigosa.TabStop = true;
            this.rdb_perigosa.Text = "Perigosa";
            this.rdb_perigosa.UseVisualStyleBackColor = true;
            // 
            // rdb_viva
            // 
            this.rdb_viva.AutoSize = true;
            this.rdb_viva.Font = new System.Drawing.Font("Miriam Libre", 13.8F, System.Drawing.FontStyle.Underline);
            this.rdb_viva.Location = new System.Drawing.Point(9, 271);
            this.rdb_viva.Name = "rdb_viva";
            this.rdb_viva.Size = new System.Drawing.Size(86, 36);
            this.rdb_viva.TabIndex = 12;
            this.rdb_viva.TabStop = true;
            this.rdb_viva.Text = "Viva";
            this.rdb_viva.UseVisualStyleBackColor = true;
            // 
            // rdb_normal
            // 
            this.rdb_normal.AutoSize = true;
            this.rdb_normal.Font = new System.Drawing.Font("Miriam Libre", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_normal.Location = new System.Drawing.Point(9, 217);
            this.rdb_normal.Name = "rdb_normal";
            this.rdb_normal.Size = new System.Drawing.Size(120, 36);
            this.rdb_normal.TabIndex = 11;
            this.rdb_normal.TabStop = true;
            this.rdb_normal.Text = "Normal";
            this.rdb_normal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Libre", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "TIPO DE CARGA:";
            // 
            // lbl_horas
            // 
            this.lbl_horas.AutoSize = true;
            this.lbl_horas.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horas.Location = new System.Drawing.Point(299, 104);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(88, 20);
            this.lbl_horas.TabIndex = 19;
            this.lbl_horas.Text = "horas (2,5)";
            // 
            // txt_DuracaoTransporte
            // 
            this.txt_DuracaoTransporte.Font = new System.Drawing.Font("Miriam Libre", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DuracaoTransporte.Location = new System.Drawing.Point(215, 99);
            this.txt_DuracaoTransporte.Name = "txt_DuracaoTransporte";
            this.txt_DuracaoTransporte.Size = new System.Drawing.Size(78, 30);
            this.txt_DuracaoTransporte.TabIndex = 10;
            // 
            // lbl_duracaoTransporte
            // 
            this.lbl_duracaoTransporte.AutoSize = true;
            this.lbl_duracaoTransporte.Location = new System.Drawing.Point(3, 104);
            this.lbl_duracaoTransporte.Name = "lbl_duracaoTransporte";
            this.lbl_duracaoTransporte.Size = new System.Drawing.Size(201, 20);
            this.lbl_duracaoTransporte.TabIndex = 18;
            this.lbl_duracaoTransporte.Text = "DURAÇÃO DO TRANSPORTE:";
            // 
            // lbl_toneladas
            // 
            this.lbl_toneladas.AutoSize = true;
            this.lbl_toneladas.Location = new System.Drawing.Point(299, 35);
            this.lbl_toneladas.Name = "lbl_toneladas";
            this.lbl_toneladas.Size = new System.Drawing.Size(84, 20);
            this.lbl_toneladas.TabIndex = 16;
            this.lbl_toneladas.Text = "toneladas";
            // 
            // txt_PesoTransporte
            // 
            this.txt_PesoTransporte.Font = new System.Drawing.Font("Miriam Libre", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PesoTransporte.Location = new System.Drawing.Point(192, 30);
            this.txt_PesoTransporte.Name = "txt_PesoTransporte";
            this.txt_PesoTransporte.Size = new System.Drawing.Size(101, 30);
            this.txt_PesoTransporte.TabIndex = 9;
            // 
            // lbl_pesoTransportado
            // 
            this.lbl_pesoTransportado.AutoSize = true;
            this.lbl_pesoTransportado.Location = new System.Drawing.Point(6, 35);
            this.lbl_pesoTransportado.Name = "lbl_pesoTransportado";
            this.lbl_pesoTransportado.Size = new System.Drawing.Size(165, 20);
            this.lbl_pesoTransportado.TabIndex = 15;
            this.lbl_pesoTransportado.Text = "PESO TRANSPORTADO:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Mercadorias);
            this.tabControl1.Controls.Add(this.TransportePublico);
            this.tabControl1.Controls.Add(this.Taxi);
            this.tabControl1.Font = new System.Drawing.Font("Miriam Libre", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(402, 421);
            this.tabControl1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Miriam Libre", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(613, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Miriam Libre", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(688, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "-";
            // 
            // txtMatricula1
            // 
            this.txtMatricula1.Font = new System.Drawing.Font("Miriam Libre", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMatricula1.Location = new System.Drawing.Point(569, 168);
            this.txtMatricula1.MaxLength = 2;
            this.txtMatricula1.Name = "txtMatricula1";
            this.txtMatricula1.Size = new System.Drawing.Size(38, 30);
            this.txtMatricula1.TabIndex = 3;
            // 
            // txtMatricula2
            // 
            this.txtMatricula2.Font = new System.Drawing.Font("Miriam Libre", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMatricula2.Location = new System.Drawing.Point(644, 168);
            this.txtMatricula2.MaxLength = 2;
            this.txtMatricula2.Name = "txtMatricula2";
            this.txtMatricula2.Size = new System.Drawing.Size(38, 30);
            this.txtMatricula2.TabIndex = 4;
            // 
            // txtMatricula3
            // 
            this.txtMatricula3.Font = new System.Drawing.Font("Miriam Libre", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMatricula3.Location = new System.Drawing.Point(717, 168);
            this.txtMatricula3.MaxLength = 2;
            this.txtMatricula3.Name = "txtMatricula3";
            this.txtMatricula3.Size = new System.Drawing.Size(38, 30);
            this.txtMatricula3.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Miriam Libre", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(579, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(253, 26);
            this.label12.TabIndex = 22;
            this.label12.Text = "Primeiro e último nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(139)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(889, 448);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMatricula3);
            this.Controls.Add(this.txtMatricula2);
            this.Controls.Add(this.txtMatricula1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_kmEfetuados);
            this.Controls.Add(this.lbl_combustivel);
            this.Controls.Add(this.lbl_tipoVeiculo);
            this.Controls.Add(this.comb_Combustivel);
            this.Controls.Add(this.lbl_matricula);
            this.Controls.Add(this.lbl_condutor);
            this.Controls.Add(this.txt_condutor);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.comb_tiposVeiculos);
            this.Controls.Add(this.btn_registar);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_bazar);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Transportes";
            this.Taxi.ResumeLayout(false);
            this.Taxi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaxi)).EndInit();
            this.TransportePublico.ResumeLayout(false);
            this.TransportePublico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdoso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstudante)).EndInit();
            this.Mercadorias.ResumeLayout(false);
            this.Mercadorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_bazar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_registar;
        private System.Windows.Forms.ComboBox comb_tiposVeiculos;
        private System.Windows.Forms.TextBox txt_km;
        private System.Windows.Forms.TextBox txt_condutor;
        private System.Windows.Forms.Label lbl_condutor;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.ComboBox comb_Combustivel;
        private System.Windows.Forms.Label lbl_tipoVeiculo;
        private System.Windows.Forms.Label lbl_combustivel;
        private System.Windows.Forms.Label lbl_kmEfetuados;
        private System.Windows.Forms.TabPage Taxi;
        private System.Windows.Forms.TabPage TransportePublico;
        private System.Windows.Forms.TabPage Mercadorias;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.RadioButton rdb_perigosa;
        private System.Windows.Forms.RadioButton rdb_viva;
        private System.Windows.Forms.RadioButton rdb_normal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.TextBox txt_DuracaoTransporte;
        private System.Windows.Forms.Label lbl_duracaoTransporte;
        private System.Windows.Forms.Label lbl_toneladas;
        private System.Windows.Forms.TextBox txt_PesoTransporte;
        private System.Windows.Forms.Label lbl_pesoTransportado;
        private System.Windows.Forms.NumericUpDown numEstudante;
        private System.Windows.Forms.NumericUpDown numNormal;
        private System.Windows.Forms.NumericUpDown numIdoso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_precoBilhete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_DuracaoTaxi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBoxTaxi;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtMatricula1;
        private System.Windows.Forms.TextBox txtMatricula2;
        private System.Windows.Forms.TextBox txtMatricula3;
        private System.Windows.Forms.Label label12;
    }
}

