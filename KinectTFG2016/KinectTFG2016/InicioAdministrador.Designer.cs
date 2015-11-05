namespace KinectTFG2016
{
    partial class InicioAdministrador
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
            this.buttonEditarPacientes = new System.Windows.Forms.Button();
            this.buttonEditarTerapeutas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEditarPacientes
            // 
            this.buttonEditarPacientes.Location = new System.Drawing.Point(79, 101);
            this.buttonEditarPacientes.Name = "buttonEditarPacientes";
            this.buttonEditarPacientes.Size = new System.Drawing.Size(112, 23);
            this.buttonEditarPacientes.TabIndex = 0;
            this.buttonEditarPacientes.Text = "Editar Pacientes";
            this.buttonEditarPacientes.UseVisualStyleBackColor = true;
            this.buttonEditarPacientes.Click += new System.EventHandler(this.buttonEditarPacientes_Click);
            // 
            // buttonEditarTerapeutas
            // 
            this.buttonEditarTerapeutas.Location = new System.Drawing.Point(79, 168);
            this.buttonEditarTerapeutas.Name = "buttonEditarTerapeutas";
            this.buttonEditarTerapeutas.Size = new System.Drawing.Size(112, 23);
            this.buttonEditarTerapeutas.TabIndex = 1;
            this.buttonEditarTerapeutas.Text = "Editar Terapeutas";
            this.buttonEditarTerapeutas.UseVisualStyleBackColor = true;
            this.buttonEditarTerapeutas.Click += new System.EventHandler(this.buttonEditarTerapeutas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu Administrador";
            // 
            // InicioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 278);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditarTerapeutas);
            this.Controls.Add(this.buttonEditarPacientes);
            this.Name = "InicioAdministrador";
            this.Text = "InicioAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditarPacientes;
        private System.Windows.Forms.Button buttonEditarTerapeutas;
        private System.Windows.Forms.Label label1;
    }
}