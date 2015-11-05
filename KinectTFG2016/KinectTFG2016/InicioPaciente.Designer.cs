namespace KinectTFG2016
{
    partial class InicioPaciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConsultarHistorico = new System.Windows.Forms.Button();
            this.buttonHacerEjercicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Enabled = false;
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(102, 16);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(172, 20);
            this.textBoxNombreUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // buttonConsultarHistorico
            // 
            this.buttonConsultarHistorico.Location = new System.Drawing.Point(102, 86);
            this.buttonConsultarHistorico.Name = "buttonConsultarHistorico";
            this.buttonConsultarHistorico.Size = new System.Drawing.Size(132, 23);
            this.buttonConsultarHistorico.TabIndex = 3;
            this.buttonConsultarHistorico.Text = "Consultar Historico";
            this.buttonConsultarHistorico.UseVisualStyleBackColor = true;
            // 
            // buttonHacerEjercicio
            // 
            this.buttonHacerEjercicio.Location = new System.Drawing.Point(102, 139);
            this.buttonHacerEjercicio.Name = "buttonHacerEjercicio";
            this.buttonHacerEjercicio.Size = new System.Drawing.Size(132, 23);
            this.buttonHacerEjercicio.TabIndex = 4;
            this.buttonHacerEjercicio.Text = "Hacer Ejercicio";
            this.buttonHacerEjercicio.UseVisualStyleBackColor = true;
            // 
            // InicioPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 251);
            this.Controls.Add(this.buttonHacerEjercicio);
            this.Controls.Add(this.buttonConsultarHistorico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.label1);
            this.Name = "InicioPaciente";
            this.Text = "InicioPaciente";
            this.Load += new System.EventHandler(this.InicioPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConsultarHistorico;
        private System.Windows.Forms.Button buttonHacerEjercicio;
    }
}