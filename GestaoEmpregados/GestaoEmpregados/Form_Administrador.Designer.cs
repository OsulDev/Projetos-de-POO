namespace GestaoEmpregados
{
    partial class Form_Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Administrador));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_menuEmp = new System.Windows.Forms.Button();
            this.txt_numAdmin = new System.Windows.Forms.TextBox();
            this.lbl_numAdmin = new System.Windows.Forms.Label();
            this.txt_nifAdmin = new System.Windows.Forms.TextBox();
            this.txt_nomeAdmin = new System.Windows.Forms.TextBox();
            this.lbl_nifAdmin = new System.Windows.Forms.Label();
            this.lbl_nomeAdmin = new System.Windows.Forms.Label();
            this.btn_AdminSubmeter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numpromTxt = new System.Windows.Forms.TextBox();
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
            this.lbl_titulo.Location = new System.Drawing.Point(72, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(527, 45);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "SOFTWARE DO ADMINISTRADOR";
            // 
            // btn_menuEmp
            // 
            this.btn_menuEmp.BackColor = System.Drawing.Color.Beige;
            this.btn_menuEmp.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_menuEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.btn_menuEmp.Location = new System.Drawing.Point(17, 334);
            this.btn_menuEmp.Name = "btn_menuEmp";
            this.btn_menuEmp.Size = new System.Drawing.Size(173, 64);
            this.btn_menuEmp.TabIndex = 16;
            this.btn_menuEmp.Text = "Menu";
            this.btn_menuEmp.UseVisualStyleBackColor = false;
            this.btn_menuEmp.Click += new System.EventHandler(this.btn_menuEmp_Click);
            // 
            // txt_numAdmin
            // 
            this.txt_numAdmin.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.txt_numAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.txt_numAdmin.Location = new System.Drawing.Point(311, 199);
            this.txt_numAdmin.Name = "txt_numAdmin";
            this.txt_numAdmin.Size = new System.Drawing.Size(100, 33);
            this.txt_numAdmin.TabIndex = 30;
            // 
            // lbl_numAdmin
            // 
            this.lbl_numAdmin.AutoSize = true;
            this.lbl_numAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numAdmin.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_numAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_numAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_numAdmin.Location = new System.Drawing.Point(12, 199);
            this.lbl_numAdmin.Name = "lbl_numAdmin";
            this.lbl_numAdmin.Size = new System.Drawing.Size(283, 29);
            this.lbl_numAdmin.TabIndex = 29;
            this.lbl_numAdmin.Text = "Número do Administrador:";
            // 
            // txt_nifAdmin
            // 
            this.txt_nifAdmin.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.txt_nifAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.txt_nifAdmin.Location = new System.Drawing.Point(271, 135);
            this.txt_nifAdmin.MaxLength = 999999999;
            this.txt_nifAdmin.Name = "txt_nifAdmin";
            this.txt_nifAdmin.Size = new System.Drawing.Size(197, 33);
            this.txt_nifAdmin.TabIndex = 28;
            // 
            // txt_nomeAdmin
            // 
            this.txt_nomeAdmin.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.txt_nomeAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.txt_nomeAdmin.Location = new System.Drawing.Point(291, 70);
            this.txt_nomeAdmin.Name = "txt_nomeAdmin";
            this.txt_nomeAdmin.Size = new System.Drawing.Size(335, 33);
            this.txt_nomeAdmin.TabIndex = 27;
            // 
            // lbl_nifAdmin
            // 
            this.lbl_nifAdmin.AutoSize = true;
            this.lbl_nifAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nifAdmin.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_nifAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nifAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_nifAdmin.Location = new System.Drawing.Point(12, 135);
            this.lbl_nifAdmin.Name = "lbl_nifAdmin";
            this.lbl_nifAdmin.Size = new System.Drawing.Size(238, 29);
            this.lbl_nifAdmin.TabIndex = 26;
            this.lbl_nifAdmin.Text = "NIF do Administrador:";
            // 
            // lbl_nomeAdmin
            // 
            this.lbl_nomeAdmin.AutoSize = true;
            this.lbl_nomeAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomeAdmin.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_nomeAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nomeAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_nomeAdmin.Location = new System.Drawing.Point(12, 70);
            this.lbl_nomeAdmin.Name = "lbl_nomeAdmin";
            this.lbl_nomeAdmin.Size = new System.Drawing.Size(260, 29);
            this.lbl_nomeAdmin.TabIndex = 25;
            this.lbl_nomeAdmin.Text = "Nome do Administrador:";
            // 
            // btn_AdminSubmeter
            // 
            this.btn_AdminSubmeter.BackColor = System.Drawing.Color.Beige;
            this.btn_AdminSubmeter.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_AdminSubmeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.btn_AdminSubmeter.Location = new System.Drawing.Point(249, 334);
            this.btn_AdminSubmeter.Name = "btn_AdminSubmeter";
            this.btn_AdminSubmeter.Size = new System.Drawing.Size(173, 64);
            this.btn_AdminSubmeter.TabIndex = 32;
            this.btn_AdminSubmeter.Text = "Submeter";
            this.btn_AdminSubmeter.UseVisualStyleBackColor = false;
            this.btn_AdminSubmeter.Click += new System.EventHandler(this.btn_AdminSubmeter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Número do Promoções:";
            // 
            // txt_numpromTxt
            // 
            this.txt_numpromTxt.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.txt_numpromTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.txt_numpromTxt.Location = new System.Drawing.Point(271, 258);
            this.txt_numpromTxt.Name = "txt_numpromTxt";
            this.txt_numpromTxt.Size = new System.Drawing.Size(151, 33);
            this.txt_numpromTxt.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(479, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(740, 410);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_numpromTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AdminSubmeter);
            this.Controls.Add(this.txt_numAdmin);
            this.Controls.Add(this.lbl_numAdmin);
            this.Controls.Add(this.txt_nifAdmin);
            this.Controls.Add(this.txt_nomeAdmin);
            this.Controls.Add(this.lbl_nifAdmin);
            this.Controls.Add(this.lbl_nomeAdmin);
            this.Controls.Add(this.btn_menuEmp);
            this.Controls.Add(this.lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Administrador";
            this.Load += new System.EventHandler(this.Form_Administrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_menuEmp;
        private System.Windows.Forms.TextBox txt_numAdmin;
        private System.Windows.Forms.Label lbl_numAdmin;
        private System.Windows.Forms.TextBox txt_nifAdmin;
        private System.Windows.Forms.TextBox txt_nomeAdmin;
        private System.Windows.Forms.Label lbl_nifAdmin;
        private System.Windows.Forms.Label lbl_nomeAdmin;
        private System.Windows.Forms.Button btn_AdminSubmeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numpromTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}