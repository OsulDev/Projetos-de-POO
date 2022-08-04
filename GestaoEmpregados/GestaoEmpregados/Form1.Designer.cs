namespace GestaoEmpregados
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_emp = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_engenheiro = new System.Windows.Forms.Button();
            this.btn_gestor = new System.Windows.Forms.Button();
            this.btn_listaEmps = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_jardineiro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            resources.ApplyResources(this.lbl_titulo, "lbl_titulo");
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Name = "lbl_titulo";
            // 
            // btn_emp
            // 
            this.btn_emp.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.btn_emp, "btn_emp");
            this.btn_emp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.btn_emp.Name = "btn_emp";
            this.btn_emp.UseVisualStyleBackColor = false;
            this.btn_emp.Click += new System.EventHandler(this.btn_emp_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.btn_admin, "btn_admin");
            this.btn_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_engenheiro
            // 
            this.btn_engenheiro.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.btn_engenheiro, "btn_engenheiro");
            this.btn_engenheiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.btn_engenheiro.Name = "btn_engenheiro";
            this.btn_engenheiro.UseVisualStyleBackColor = false;
            this.btn_engenheiro.Click += new System.EventHandler(this.btn_engenheiro_Click);
            // 
            // btn_gestor
            // 
            this.btn_gestor.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.btn_gestor, "btn_gestor");
            this.btn_gestor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.btn_gestor.Name = "btn_gestor";
            this.btn_gestor.UseVisualStyleBackColor = false;
            this.btn_gestor.Click += new System.EventHandler(this.btn_gestor_Click);
            // 
            // btn_listaEmps
            // 
            this.btn_listaEmps.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.btn_listaEmps, "btn_listaEmps");
            this.btn_listaEmps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.btn_listaEmps.Name = "btn_listaEmps";
            this.btn_listaEmps.UseVisualStyleBackColor = false;
            this.btn_listaEmps.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btn_jardineiro
            // 
            this.btn_jardineiro.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.btn_jardineiro, "btn_jardineiro");
            this.btn_jardineiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.btn_jardineiro.Name = "btn_jardineiro";
            this.btn_jardineiro.UseVisualStyleBackColor = false;
            this.btn_jardineiro.Click += new System.EventHandler(this.btn_jardineiro_Click_1);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(11)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.btn_jardineiro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_listaEmps);
            this.Controls.Add(this.btn_gestor);
            this.Controls.Add(this.btn_engenheiro);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_emp);
            this.Controls.Add(this.lbl_titulo);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_emp;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_engenheiro;
        private System.Windows.Forms.Button btn_gestor;
        private System.Windows.Forms.Button btn_listaEmps;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_jardineiro;
    }
}

