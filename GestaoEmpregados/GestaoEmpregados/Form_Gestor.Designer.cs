namespace GestaoEmpregados
{
    partial class Form_Gestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gestor));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_menuEmp = new System.Windows.Forms.Button();
            this.txt_numGestor = new System.Windows.Forms.TextBox();
            this.lbl_numGestor = new System.Windows.Forms.Label();
            this.txt_nifGestor = new System.Windows.Forms.TextBox();
            this.txt_nomeGestor = new System.Windows.Forms.TextBox();
            this.lbl_nifGestor = new System.Windows.Forms.Label();
            this.lbl_nomeGestor = new System.Windows.Forms.Label();
            this.btn_GestorSubmeter = new System.Windows.Forms.Button();
            this.lbl_suplementoSalario = new System.Windows.Forms.Label();
            this.txt_suplementoSlr = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Beige;
            this.lbl_titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_titulo.Location = new System.Drawing.Point(74, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(378, 45);
            this.lbl_titulo.TabIndex = 4;
            this.lbl_titulo.Text = "SOFTWARE DO GESTOR";
            // 
            // btn_menuEmp
            // 
            this.btn_menuEmp.BackColor = System.Drawing.Color.Beige;
            this.btn_menuEmp.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_menuEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.btn_menuEmp.Location = new System.Drawing.Point(20, 343);
            this.btn_menuEmp.Name = "btn_menuEmp";
            this.btn_menuEmp.Size = new System.Drawing.Size(173, 64);
            this.btn_menuEmp.TabIndex = 17;
            this.btn_menuEmp.Text = "Menu";
            this.btn_menuEmp.UseVisualStyleBackColor = false;
            this.btn_menuEmp.Click += new System.EventHandler(this.btn_menuEmp_Click);
            // 
            // txt_numGestor
            // 
            this.txt_numGestor.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.txt_numGestor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.txt_numGestor.Location = new System.Drawing.Point(225, 207);
            this.txt_numGestor.Name = "txt_numGestor";
            this.txt_numGestor.Size = new System.Drawing.Size(100, 33);
            this.txt_numGestor.TabIndex = 23;
            // 
            // lbl_numGestor
            // 
            this.lbl_numGestor.AutoSize = true;
            this.lbl_numGestor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numGestor.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_numGestor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_numGestor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_numGestor.Location = new System.Drawing.Point(15, 211);
            this.lbl_numGestor.Name = "lbl_numGestor";
            this.lbl_numGestor.Size = new System.Drawing.Size(204, 29);
            this.lbl_numGestor.TabIndex = 22;
            this.lbl_numGestor.Text = "Número do Gestor:";
            // 
            // txt_nifGestor
            // 
            this.txt_nifGestor.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.txt_nifGestor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.txt_nifGestor.Location = new System.Drawing.Point(189, 152);
            this.txt_nifGestor.MaxLength = 999999999;
            this.txt_nifGestor.Name = "txt_nifGestor";
            this.txt_nifGestor.Size = new System.Drawing.Size(197, 33);
            this.txt_nifGestor.TabIndex = 21;
            // 
            // txt_nomeGestor
            // 
            this.txt_nomeGestor.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.txt_nomeGestor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.txt_nomeGestor.Location = new System.Drawing.Point(213, 88);
            this.txt_nomeGestor.Name = "txt_nomeGestor";
            this.txt_nomeGestor.Size = new System.Drawing.Size(311, 33);
            this.txt_nomeGestor.TabIndex = 20;
            // 
            // lbl_nifGestor
            // 
            this.lbl_nifGestor.AutoSize = true;
            this.lbl_nifGestor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nifGestor.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_nifGestor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nifGestor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_nifGestor.Location = new System.Drawing.Point(12, 152);
            this.lbl_nifGestor.Name = "lbl_nifGestor";
            this.lbl_nifGestor.Size = new System.Drawing.Size(159, 29);
            this.lbl_nifGestor.TabIndex = 19;
            this.lbl_nifGestor.Text = "NIF do Gestor:";
            // 
            // lbl_nomeGestor
            // 
            this.lbl_nomeGestor.AutoSize = true;
            this.lbl_nomeGestor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomeGestor.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_nomeGestor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nomeGestor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_nomeGestor.Location = new System.Drawing.Point(12, 88);
            this.lbl_nomeGestor.Name = "lbl_nomeGestor";
            this.lbl_nomeGestor.Size = new System.Drawing.Size(181, 29);
            this.lbl_nomeGestor.TabIndex = 18;
            this.lbl_nomeGestor.Text = "Nome do Gestor:";
            // 
            // btn_GestorSubmeter
            // 
            this.btn_GestorSubmeter.BackColor = System.Drawing.Color.Beige;
            this.btn_GestorSubmeter.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_GestorSubmeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.btn_GestorSubmeter.Location = new System.Drawing.Point(213, 343);
            this.btn_GestorSubmeter.Name = "btn_GestorSubmeter";
            this.btn_GestorSubmeter.Size = new System.Drawing.Size(173, 64);
            this.btn_GestorSubmeter.TabIndex = 27;
            this.btn_GestorSubmeter.Text = "Submeter";
            this.btn_GestorSubmeter.UseVisualStyleBackColor = false;
            this.btn_GestorSubmeter.Click += new System.EventHandler(this.btn_GestorSubmeter_Click);
            // 
            // lbl_suplementoSalario
            // 
            this.lbl_suplementoSalario.AutoSize = true;
            this.lbl_suplementoSalario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_suplementoSalario.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_suplementoSalario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_suplementoSalario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_suplementoSalario.Location = new System.Drawing.Point(12, 269);
            this.lbl_suplementoSalario.Name = "lbl_suplementoSalario";
            this.lbl_suplementoSalario.Size = new System.Drawing.Size(243, 29);
            this.lbl_suplementoSalario.TabIndex = 28;
            this.lbl_suplementoSalario.Text = "Suplemento do salário:";
            // 
            // txt_suplementoSlr
            // 
            this.txt_suplementoSlr.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.txt_suplementoSlr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.txt_suplementoSlr.Location = new System.Drawing.Point(267, 265);
            this.txt_suplementoSlr.Name = "txt_suplementoSlr";
            this.txt_suplementoSlr.Size = new System.Drawing.Size(107, 33);
            this.txt_suplementoSlr.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(392, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Gestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(667, 419);
            this.Controls.Add(this.txt_suplementoSlr);
            this.Controls.Add(this.lbl_suplementoSalario);
            this.Controls.Add(this.btn_GestorSubmeter);
            this.Controls.Add(this.txt_numGestor);
            this.Controls.Add(this.lbl_numGestor);
            this.Controls.Add(this.txt_nifGestor);
            this.Controls.Add(this.txt_nomeGestor);
            this.Controls.Add(this.lbl_nifGestor);
            this.Controls.Add(this.lbl_nomeGestor);
            this.Controls.Add(this.btn_menuEmp);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Gestor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Gestor";
            this.Load += new System.EventHandler(this.Form_Gestor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_menuEmp;
        private System.Windows.Forms.TextBox txt_numGestor;
        private System.Windows.Forms.Label lbl_numGestor;
        private System.Windows.Forms.TextBox txt_nifGestor;
        private System.Windows.Forms.TextBox txt_nomeGestor;
        private System.Windows.Forms.Label lbl_nifGestor;
        private System.Windows.Forms.Label lbl_nomeGestor;
        private System.Windows.Forms.Button btn_GestorSubmeter;
        private System.Windows.Forms.Label lbl_suplementoSalario;
        private System.Windows.Forms.TextBox txt_suplementoSlr;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}