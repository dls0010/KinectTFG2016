namespace KinectTFG2016
{
    partial class InicioTerapeuta
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
            this.buttonAdquerir = new System.Windows.Forms.Button();
            this.labelNuevoPaciente = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelConsultar = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdquerir
            // 
            this.buttonAdquerir.Location = new System.Drawing.Point(228, 88);
            this.buttonAdquerir.Name = "buttonAdquerir";
            this.buttonAdquerir.Size = new System.Drawing.Size(75, 23);
            this.buttonAdquerir.TabIndex = 0;
            this.buttonAdquerir.Text = "Adquerir";
            this.buttonAdquerir.UseVisualStyleBackColor = true;
            this.buttonAdquerir.Click += new System.EventHandler(this.buttonAdquerir_Click);
            // 
            // labelNuevoPaciente
            // 
            this.labelNuevoPaciente.AutoSize = true;
            this.labelNuevoPaciente.Location = new System.Drawing.Point(72, 93);
            this.labelNuevoPaciente.Name = "labelNuevoPaciente";
            this.labelNuevoPaciente.Size = new System.Drawing.Size(126, 13);
            this.labelNuevoPaciente.TabIndex = 1;
            this.labelNuevoPaciente.Text = "Adquerir nuevo paciente:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(72, 25);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(150, 13);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Elija la opción que más desee:";
            // 
            // labelConsultar
            // 
            this.labelConsultar.AutoSize = true;
            this.labelConsultar.Location = new System.Drawing.Point(72, 149);
            this.labelConsultar.Name = "labelConsultar";
            this.labelConsultar.Size = new System.Drawing.Size(121, 13);
            this.labelConsultar.TabIndex = 4;
            this.labelConsultar.Text = "Consultar mis relaciones:";
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(228, 144);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 3;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // InicioTerapeuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 249);
            this.Controls.Add(this.labelConsultar);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelNuevoPaciente);
            this.Controls.Add(this.buttonAdquerir);
            this.Name = "InicioTerapeuta";
            this.Text = "InicioTerapeuta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdquerir;
        private System.Windows.Forms.Label labelNuevoPaciente;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelConsultar;
        private System.Windows.Forms.Button buttonConsultar;
    }
}