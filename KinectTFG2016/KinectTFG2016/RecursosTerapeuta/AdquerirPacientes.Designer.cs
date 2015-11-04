namespace KinectTFG2016.RecursosTerapeuta
{
    partial class AdquerirPacientes
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
            System.Windows.Forms.Label idPacienteLabel;
            System.Windows.Forms.Label nombrePacienteLabel;
            System.Windows.Forms.Label apellidosPacienteLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label nifPacienteLabel;
            System.Windows.Forms.Label telefonoPacienteLabel;
            System.Windows.Forms.Label nacimientoPacienteLabel;
            System.Windows.Forms.Label estadoPacienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdquerirPacientes));
            this.pacientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinectBDDataSet = new KinectTFG2016.KinectBDDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pacientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.textBoxIDPaciente = new System.Windows.Forms.TextBox();
            this.textBoxNombrePaciente = new System.Windows.Forms.TextBox();
            this.textBoxApellidosPaciente = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.textBoxNifPaciente = new System.Windows.Forms.TextBox();
            this.textBoxTelefonoPaciente = new System.Windows.Forms.TextBox();
            this.nacimientoPacienteDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.estadoPacienteTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nifPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimientoPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAsignar = new System.Windows.Forms.Button();
            this.pacientesTableAdapter = new KinectTFG2016.KinectBDDataSetTableAdapters.PacientesTableAdapter();
            this.tableAdapterManager = new KinectTFG2016.KinectBDDataSetTableAdapters.TableAdapterManager();
            idPacienteLabel = new System.Windows.Forms.Label();
            nombrePacienteLabel = new System.Windows.Forms.Label();
            apellidosPacienteLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            nifPacienteLabel = new System.Windows.Forms.Label();
            telefonoPacienteLabel = new System.Windows.Forms.Label();
            nacimientoPacienteLabel = new System.Windows.Forms.Label();
            estadoPacienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingNavigator)).BeginInit();
            this.pacientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinectBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // idPacienteLabel
            // 
            idPacienteLabel.AutoSize = true;
            idPacienteLabel.Location = new System.Drawing.Point(244, 215);
            idPacienteLabel.Name = "idPacienteLabel";
            idPacienteLabel.Size = new System.Drawing.Size(63, 13);
            idPacienteLabel.TabIndex = 1;
            idPacienteLabel.Text = "id Paciente:";
            // 
            // nombrePacienteLabel
            // 
            nombrePacienteLabel.AutoSize = true;
            nombrePacienteLabel.Location = new System.Drawing.Point(244, 241);
            nombrePacienteLabel.Name = "nombrePacienteLabel";
            nombrePacienteLabel.Size = new System.Drawing.Size(90, 13);
            nombrePacienteLabel.TabIndex = 3;
            nombrePacienteLabel.Text = "nombre Paciente:";
            // 
            // apellidosPacienteLabel
            // 
            apellidosPacienteLabel.AutoSize = true;
            apellidosPacienteLabel.Location = new System.Drawing.Point(244, 267);
            apellidosPacienteLabel.Name = "apellidosPacienteLabel";
            apellidosPacienteLabel.Size = new System.Drawing.Size(96, 13);
            apellidosPacienteLabel.TabIndex = 5;
            apellidosPacienteLabel.Text = "apellidos Paciente:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(244, 293);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(44, 13);
            usuarioLabel.TabIndex = 7;
            usuarioLabel.Text = "usuario:";
            // 
            // nifPacienteLabel
            // 
            nifPacienteLabel.AutoSize = true;
            nifPacienteLabel.Location = new System.Drawing.Point(244, 319);
            nifPacienteLabel.Name = "nifPacienteLabel";
            nifPacienteLabel.Size = new System.Drawing.Size(66, 13);
            nifPacienteLabel.TabIndex = 9;
            nifPacienteLabel.Text = "nif Paciente:";
            // 
            // telefonoPacienteLabel
            // 
            telefonoPacienteLabel.AutoSize = true;
            telefonoPacienteLabel.Location = new System.Drawing.Point(244, 345);
            telefonoPacienteLabel.Name = "telefonoPacienteLabel";
            telefonoPacienteLabel.Size = new System.Drawing.Size(93, 13);
            telefonoPacienteLabel.TabIndex = 11;
            telefonoPacienteLabel.Text = "telefono Paciente:";
            // 
            // nacimientoPacienteLabel
            // 
            nacimientoPacienteLabel.AutoSize = true;
            nacimientoPacienteLabel.Location = new System.Drawing.Point(244, 372);
            nacimientoPacienteLabel.Name = "nacimientoPacienteLabel";
            nacimientoPacienteLabel.Size = new System.Drawing.Size(106, 13);
            nacimientoPacienteLabel.TabIndex = 13;
            nacimientoPacienteLabel.Text = "nacimiento Paciente:";
            // 
            // estadoPacienteLabel
            // 
            estadoPacienteLabel.AutoSize = true;
            estadoPacienteLabel.Location = new System.Drawing.Point(244, 397);
            estadoPacienteLabel.Name = "estadoPacienteLabel";
            estadoPacienteLabel.Size = new System.Drawing.Size(87, 13);
            estadoPacienteLabel.TabIndex = 15;
            estadoPacienteLabel.Text = "estado Paciente:";
            // 
            // pacientesBindingNavigator
            // 
            this.pacientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacientesBindingNavigator.BindingSource = this.pacientesBindingSource;
            this.pacientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pacientesBindingNavigatorSaveItem});
            this.pacientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacientesBindingNavigator.Name = "pacientesBindingNavigator";
            this.pacientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacientesBindingNavigator.Size = new System.Drawing.Size(879, 25);
            this.pacientesBindingNavigator.TabIndex = 0;
            this.pacientesBindingNavigator.Text = "bindingNavigator1";
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
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.kinectBDDataSet;
            // 
            // kinectBDDataSet
            // 
            this.kinectBDDataSet.DataSetName = "KinectBDDataSet";
            this.kinectBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pacientesBindingNavigatorSaveItem
            // 
            this.pacientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pacientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacientesBindingNavigatorSaveItem.Image")));
            this.pacientesBindingNavigatorSaveItem.Name = "pacientesBindingNavigatorSaveItem";
            this.pacientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(117, 22);
            this.pacientesBindingNavigatorSaveItem.Text = "ASIGNAR PACIENTE";
            this.pacientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacientesBindingNavigatorSaveItem_Click);
            // 
            // textBoxIDPaciente
            // 
            this.textBoxIDPaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "idPaciente", true));
            this.textBoxIDPaciente.Enabled = false;
            this.textBoxIDPaciente.Location = new System.Drawing.Point(356, 212);
            this.textBoxIDPaciente.Name = "textBoxIDPaciente";
            this.textBoxIDPaciente.Size = new System.Drawing.Size(200, 20);
            this.textBoxIDPaciente.TabIndex = 2;
            // 
            // textBoxNombrePaciente
            // 
            this.textBoxNombrePaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "nombrePaciente", true));
            this.textBoxNombrePaciente.Enabled = false;
            this.textBoxNombrePaciente.Location = new System.Drawing.Point(356, 238);
            this.textBoxNombrePaciente.Name = "textBoxNombrePaciente";
            this.textBoxNombrePaciente.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombrePaciente.TabIndex = 4;
            // 
            // textBoxApellidosPaciente
            // 
            this.textBoxApellidosPaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "apellidosPaciente", true));
            this.textBoxApellidosPaciente.Enabled = false;
            this.textBoxApellidosPaciente.Location = new System.Drawing.Point(356, 264);
            this.textBoxApellidosPaciente.Name = "textBoxApellidosPaciente";
            this.textBoxApellidosPaciente.Size = new System.Drawing.Size(200, 20);
            this.textBoxApellidosPaciente.TabIndex = 6;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "usuario", true));
            this.usuarioTextBox.Enabled = false;
            this.usuarioTextBox.Location = new System.Drawing.Point(356, 290);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.usuarioTextBox.TabIndex = 8;
            // 
            // textBoxNifPaciente
            // 
            this.textBoxNifPaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "nifPaciente", true));
            this.textBoxNifPaciente.Enabled = false;
            this.textBoxNifPaciente.Location = new System.Drawing.Point(356, 316);
            this.textBoxNifPaciente.Name = "textBoxNifPaciente";
            this.textBoxNifPaciente.Size = new System.Drawing.Size(200, 20);
            this.textBoxNifPaciente.TabIndex = 10;
            // 
            // textBoxTelefonoPaciente
            // 
            this.textBoxTelefonoPaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "telefonoPaciente", true));
            this.textBoxTelefonoPaciente.Enabled = false;
            this.textBoxTelefonoPaciente.Location = new System.Drawing.Point(356, 342);
            this.textBoxTelefonoPaciente.Name = "textBoxTelefonoPaciente";
            this.textBoxTelefonoPaciente.Size = new System.Drawing.Size(200, 20);
            this.textBoxTelefonoPaciente.TabIndex = 12;
            // 
            // nacimientoPacienteDateTimePicker
            // 
            this.nacimientoPacienteDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pacientesBindingSource, "nacimientoPaciente", true));
            this.nacimientoPacienteDateTimePicker.Enabled = false;
            this.nacimientoPacienteDateTimePicker.Location = new System.Drawing.Point(356, 368);
            this.nacimientoPacienteDateTimePicker.Name = "nacimientoPacienteDateTimePicker";
            this.nacimientoPacienteDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.nacimientoPacienteDateTimePicker.TabIndex = 14;
            // 
            // estadoPacienteTextBox
            // 
            this.estadoPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "estadoPaciente", true));
            this.estadoPacienteTextBox.Location = new System.Drawing.Point(356, 394);
            this.estadoPacienteTextBox.Name = "estadoPacienteTextBox";
            this.estadoPacienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.estadoPacienteTextBox.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPacienteDataGridViewTextBoxColumn,
            this.nombrePacienteDataGridViewTextBoxColumn,
            this.apellidosPacienteDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.nifPacienteDataGridViewTextBoxColumn,
            this.telefonoPacienteDataGridViewTextBoxColumn,
            this.nacimientoPacienteDataGridViewTextBoxColumn,
            this.estadoPacienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pacientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // idPacienteDataGridViewTextBoxColumn
            // 
            this.idPacienteDataGridViewTextBoxColumn.DataPropertyName = "idPaciente";
            this.idPacienteDataGridViewTextBoxColumn.HeaderText = "idPaciente";
            this.idPacienteDataGridViewTextBoxColumn.Name = "idPacienteDataGridViewTextBoxColumn";
            this.idPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrePacienteDataGridViewTextBoxColumn
            // 
            this.nombrePacienteDataGridViewTextBoxColumn.DataPropertyName = "nombrePaciente";
            this.nombrePacienteDataGridViewTextBoxColumn.HeaderText = "nombrePaciente";
            this.nombrePacienteDataGridViewTextBoxColumn.Name = "nombrePacienteDataGridViewTextBoxColumn";
            // 
            // apellidosPacienteDataGridViewTextBoxColumn
            // 
            this.apellidosPacienteDataGridViewTextBoxColumn.DataPropertyName = "apellidosPaciente";
            this.apellidosPacienteDataGridViewTextBoxColumn.HeaderText = "apellidosPaciente";
            this.apellidosPacienteDataGridViewTextBoxColumn.Name = "apellidosPacienteDataGridViewTextBoxColumn";
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // nifPacienteDataGridViewTextBoxColumn
            // 
            this.nifPacienteDataGridViewTextBoxColumn.DataPropertyName = "nifPaciente";
            this.nifPacienteDataGridViewTextBoxColumn.HeaderText = "nifPaciente";
            this.nifPacienteDataGridViewTextBoxColumn.Name = "nifPacienteDataGridViewTextBoxColumn";
            // 
            // telefonoPacienteDataGridViewTextBoxColumn
            // 
            this.telefonoPacienteDataGridViewTextBoxColumn.DataPropertyName = "telefonoPaciente";
            this.telefonoPacienteDataGridViewTextBoxColumn.HeaderText = "telefonoPaciente";
            this.telefonoPacienteDataGridViewTextBoxColumn.Name = "telefonoPacienteDataGridViewTextBoxColumn";
            // 
            // nacimientoPacienteDataGridViewTextBoxColumn
            // 
            this.nacimientoPacienteDataGridViewTextBoxColumn.DataPropertyName = "nacimientoPaciente";
            this.nacimientoPacienteDataGridViewTextBoxColumn.HeaderText = "nacimientoPaciente";
            this.nacimientoPacienteDataGridViewTextBoxColumn.Name = "nacimientoPacienteDataGridViewTextBoxColumn";
            // 
            // estadoPacienteDataGridViewTextBoxColumn
            // 
            this.estadoPacienteDataGridViewTextBoxColumn.DataPropertyName = "estadoPaciente";
            this.estadoPacienteDataGridViewTextBoxColumn.HeaderText = "estadoPaciente";
            this.estadoPacienteDataGridViewTextBoxColumn.Name = "estadoPacienteDataGridViewTextBoxColumn";
            // 
            // pacientesBindingSource1
            // 
            this.pacientesBindingSource1.DataMember = "Pacientes";
            this.pacientesBindingSource1.DataSource = this.kinectBDDataSet;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(879, 25);
            this.fillByToolStrip.TabIndex = 18;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(156, 22);
            this.fillByToolStripButton.Text = "FILTRAR PACIENTES LIBRES";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ponga aqui su nombre:";
            // 
            // buttonAsignar
            // 
            this.buttonAsignar.Location = new System.Drawing.Point(633, 280);
            this.buttonAsignar.Name = "buttonAsignar";
            this.buttonAsignar.Size = new System.Drawing.Size(181, 52);
            this.buttonAsignar.TabIndex = 20;
            this.buttonAsignar.Text = "Asignar Paciente";
            this.buttonAsignar.UseVisualStyleBackColor = true;
            this.buttonAsignar.Click += new System.EventHandler(this.buttonAsignar_Click);
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.RelacionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KinectTFG2016.KinectBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AdquerirPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 434);
            this.Controls.Add(this.buttonAsignar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(idPacienteLabel);
            this.Controls.Add(this.textBoxIDPaciente);
            this.Controls.Add(nombrePacienteLabel);
            this.Controls.Add(this.textBoxNombrePaciente);
            this.Controls.Add(apellidosPacienteLabel);
            this.Controls.Add(this.textBoxApellidosPaciente);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(nifPacienteLabel);
            this.Controls.Add(this.textBoxNifPaciente);
            this.Controls.Add(telefonoPacienteLabel);
            this.Controls.Add(this.textBoxTelefonoPaciente);
            this.Controls.Add(nacimientoPacienteLabel);
            this.Controls.Add(this.nacimientoPacienteDateTimePicker);
            this.Controls.Add(estadoPacienteLabel);
            this.Controls.Add(this.estadoPacienteTextBox);
            this.Controls.Add(this.pacientesBindingNavigator);
            this.Name = "AdquerirPacientes";
            this.Text = "AsignarPacientes";
            this.Load += new System.EventHandler(this.AsignarPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingNavigator)).EndInit();
            this.pacientesBindingNavigator.ResumeLayout(false);
            this.pacientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinectBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KinectBDDataSet kinectBDDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private KinectBDDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private KinectBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pacientesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pacientesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox textBoxIDPaciente;
        private System.Windows.Forms.TextBox textBoxNombrePaciente;
        private System.Windows.Forms.TextBox textBoxApellidosPaciente;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox textBoxNifPaciente;
        private System.Windows.Forms.TextBox textBoxTelefonoPaciente;
        private System.Windows.Forms.DateTimePicker nacimientoPacienteDateTimePicker;
        private System.Windows.Forms.TextBox estadoPacienteTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nifPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimientoPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pacientesBindingSource1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAsignar;
    }
}