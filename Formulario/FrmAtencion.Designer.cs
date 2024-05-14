namespace Formulario
{
    partial class FrmAtencion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.rtbInfoMedico = new System.Windows.Forms.RichTextBox();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(540, 38);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(217, 77);
            this.btnAtender.TabIndex = 0;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(540, 325);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(217, 88);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Location = new System.Drawing.Point(358, 26);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(57, 15);
            this.lblPacientes.TabIndex = 2;
            this.lblPacientes.Text = "Pacientes";
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Location = new System.Drawing.Point(69, 26);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(95, 15);
            this.lblMedicos.TabIndex = 3;
            this.lblMedicos.Text = "Personal Medico";
            // 
            // rtbInfoMedico
            // 
            this.rtbInfoMedico.Location = new System.Drawing.Point(12, 294);
            this.rtbInfoMedico.Name = "rtbInfoMedico";
            this.rtbInfoMedico.Size = new System.Drawing.Size(487, 144);
            this.rtbInfoMedico.TabIndex = 4;
            this.rtbInfoMedico.Text = "";
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 15;
            this.lstPacientes.Location = new System.Drawing.Point(263, 44);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(236, 244);
            this.lstPacientes.TabIndex = 5;
            // 
            // lstMedicos
            // 
            this.lstMedicos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.ItemHeight = 15;
            this.lstMedicos.Location = new System.Drawing.Point(12, 44);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstMedicos.Size = new System.Drawing.Size(236, 244);
            this.lstMedicos.TabIndex = 6;
            // 
            // FrmAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMedicos);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.rtbInfoMedico);
            this.Controls.Add(this.lblMedicos);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAtender);
            this.Name = "FrmAtencion";
            this.Text = "Atencion de pacientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAtencion_FormClosing);
            this.Load += new System.EventHandler(this.FrmAtencion_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAtender;
        private Button btnSalir;
        private Label lblPacientes;
        private Label lblMedicos;
        private RichTextBox rtbInfoMedico;
        private ListBox lstPacientes;
        private ListBox lstMedicos;
    }
}