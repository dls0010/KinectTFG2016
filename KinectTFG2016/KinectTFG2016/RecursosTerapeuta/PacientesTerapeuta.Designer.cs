namespace KinectTFG2016.RecursosTerapeuta
{
    partial class PacientesTerapeuta
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
            this.components = new System.ComponentModel.Container();
            this.kinectBDDataSet = new KinectTFG2016.KinectBDDataSet();
            this.kinectBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relacionesTableAdapter = new KinectTFG2016.KinectBDDataSetTableAdapters.RelacionesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxNombreTerapeuta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kinectBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinectBDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kinectBDDataSet
            // 
            this.kinectBDDataSet.DataSetName = "KinectBDDataSet";
            this.kinectBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kinectBDDataSetBindingSource
            // 
            this.kinectBDDataSetBindingSource.DataSource = this.kinectBDDataSet;
            this.kinectBDDataSetBindingSource.Position = 0;
            // 
            // relacionesBindingSource
            // 
            this.relacionesBindingSource.DataMember = "Relaciones";
            this.relacionesBindingSource.DataSource = this.kinectBDDataSetBindingSource;
            // 
            // relacionesTableAdapter
            // 
            this.relacionesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(878, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxNombreTerapeuta
            // 
            this.textBoxNombreTerapeuta.Location = new System.Drawing.Point(68, 12);
            this.textBoxNombreTerapeuta.Name = "textBoxNombreTerapeuta";
            this.textBoxNombreTerapeuta.Size = new System.Drawing.Size(171, 20);
            this.textBoxNombreTerapeuta.TabIndex = 1;
            this.textBoxNombreTerapeuta.TextChanged += new System.EventHandler(this.textBoxNombreTerapeuta_TextChanged);
            // 
            // PacientesTerapeuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 319);
            this.Controls.Add(this.textBoxNombreTerapeuta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PacientesTerapeuta";
            this.Text = "PacientesTerapeuta";
            this.Load += new System.EventHandler(this.PacientesTerapeuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kinectBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinectBDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource kinectBDDataSetBindingSource;
        private KinectBDDataSet kinectBDDataSet;
        private System.Windows.Forms.BindingSource relacionesBindingSource;
        private KinectBDDataSetTableAdapters.RelacionesTableAdapter relacionesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNombreTerapeuta;
    }
}