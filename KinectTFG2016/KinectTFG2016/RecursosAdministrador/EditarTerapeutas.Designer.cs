﻿namespace KinectTFG2016.RecursosAdministrador
{
    partial class EditarTerapeutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarTerapeutas));
            this.kinectBDDRecursosAdministrador = new KinectTFG2016.RecursosAdministrador.KinectBDDRecursosAdministrador();
            this.terapeutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terapeutasTableAdapter = new KinectTFG2016.RecursosAdministrador.KinectBDDRecursosAdministradorTableAdapters.TerapeutasTableAdapter();
            this.tableAdapterManager = new KinectTFG2016.RecursosAdministrador.KinectBDDRecursosAdministradorTableAdapters.TableAdapterManager();
            this.terapeutasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.terapeutasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.terapeutasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kinectBDDRecursosAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terapeutasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terapeutasBindingNavigator)).BeginInit();
            this.terapeutasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.terapeutasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kinectBDDRecursosAdministrador
            // 
            this.kinectBDDRecursosAdministrador.DataSetName = "KinectBDDRecursosAdministrador";
            this.kinectBDDRecursosAdministrador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // terapeutasBindingSource
            // 
            this.terapeutasBindingSource.DataMember = "Terapeutas";
            this.terapeutasBindingSource.DataSource = this.kinectBDDRecursosAdministrador;
            // 
            // terapeutasTableAdapter
            // 
            this.terapeutasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministradoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PacientesTableAdapter = null;
            this.tableAdapterManager.TerapeutasTableAdapter = this.terapeutasTableAdapter;
            this.tableAdapterManager.UpdateOrder = KinectTFG2016.RecursosAdministrador.KinectBDDRecursosAdministradorTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // terapeutasBindingNavigator
            // 
            this.terapeutasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.terapeutasBindingNavigator.BindingSource = this.terapeutasBindingSource;
            this.terapeutasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.terapeutasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.terapeutasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.terapeutasBindingNavigatorSaveItem});
            this.terapeutasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.terapeutasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.terapeutasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.terapeutasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.terapeutasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.terapeutasBindingNavigator.Name = "terapeutasBindingNavigator";
            this.terapeutasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.terapeutasBindingNavigator.Size = new System.Drawing.Size(832, 25);
            this.terapeutasBindingNavigator.TabIndex = 0;
            this.terapeutasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // terapeutasBindingNavigatorSaveItem
            // 
            this.terapeutasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.terapeutasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("terapeutasBindingNavigatorSaveItem.Image")));
            this.terapeutasBindingNavigatorSaveItem.Name = "terapeutasBindingNavigatorSaveItem";
            this.terapeutasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.terapeutasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.terapeutasBindingNavigatorSaveItem.Click += new System.EventHandler(this.terapeutasBindingNavigatorSaveItem_Click);
            // 
            // terapeutasDataGridView
            // 
            this.terapeutasDataGridView.AllowUserToOrderColumns = true;
            this.terapeutasDataGridView.AutoGenerateColumns = false;
            this.terapeutasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terapeutasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.terapeutasDataGridView.DataSource = this.terapeutasBindingSource;
            this.terapeutasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terapeutasDataGridView.Location = new System.Drawing.Point(0, 25);
            this.terapeutasDataGridView.Name = "terapeutasDataGridView";
            this.terapeutasDataGridView.Size = new System.Drawing.Size(832, 411);
            this.terapeutasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idTerapeuta";
            this.dataGridViewTextBoxColumn1.HeaderText = "idTerapeuta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombreTerapeuta";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombreTerapeuta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellidosTerapeuta";
            this.dataGridViewTextBoxColumn3.HeaderText = "apellidosTerapeuta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "usuario";
            this.dataGridViewTextBoxColumn4.HeaderText = "usuario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nifTerapeuta";
            this.dataGridViewTextBoxColumn5.HeaderText = "nifTerapeuta";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nacimientoTerapeuta";
            this.dataGridViewTextBoxColumn6.HeaderText = "nacimientoTerapeuta";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // EditarTerapeutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 436);
            this.Controls.Add(this.terapeutasDataGridView);
            this.Controls.Add(this.terapeutasBindingNavigator);
            this.Name = "EditarTerapeutas";
            this.Text = "EditarTerapeutas";
            this.Load += new System.EventHandler(this.EditarTerapeutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kinectBDDRecursosAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terapeutasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terapeutasBindingNavigator)).EndInit();
            this.terapeutasBindingNavigator.ResumeLayout(false);
            this.terapeutasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.terapeutasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KinectBDDRecursosAdministrador kinectBDDRecursosAdministrador;
        private System.Windows.Forms.BindingSource terapeutasBindingSource;
        private KinectBDDRecursosAdministradorTableAdapters.TerapeutasTableAdapter terapeutasTableAdapter;
        private KinectBDDRecursosAdministradorTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator terapeutasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton terapeutasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView terapeutasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}