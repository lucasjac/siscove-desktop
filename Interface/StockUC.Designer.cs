namespace Interface
{
    partial class StockUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PanelBarcode = new System.Windows.Forms.Panel();
            this.CheckBoxBarcode = new System.Windows.Forms.CheckBox();
            this.LabelBarcode = new System.Windows.Forms.Label();
            this.TextBoxSearch2 = new System.Windows.Forms.TextBox();
            this.TextBoxBarcode = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.PanelNumeric = new System.Windows.Forms.Panel();
            this.LabelComparison = new System.Windows.Forms.Label();
            this.NumericSearch = new System.Windows.Forms.NumericUpDown();
            this.LabelQuantity = new System.Windows.Forms.Label();
            this.CheckBoxQuantity = new System.Windows.Forms.CheckBox();
            this.PanelText = new System.Windows.Forms.Panel();
            this.CheckBoxDescription = new System.Windows.Forms.CheckBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.NumericQuantity = new System.Windows.Forms.NumericUpDown();
            this.PanelWarning = new System.Windows.Forms.Panel();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.LabelSelection = new System.Windows.Forms.Label();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.DataGridViewStock = new System.Windows.Forms.DataGridView();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unity = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Prices = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Panel1.SuspendLayout();
            this.PanelBarcode.SuspendLayout();
            this.PanelNumeric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSearch)).BeginInit();
            this.PanelText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).BeginInit();
            this.PanelWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.PanelBarcode);
            this.Panel1.Controls.Add(this.TextBoxBarcode);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.PanelNumeric);
            this.Panel1.Controls.Add(this.PanelText);
            this.Panel1.Controls.Add(this.NumericQuantity);
            this.Panel1.Controls.Add(this.PanelWarning);
            this.Panel1.Controls.Add(this.ButtonNew);
            this.Panel1.Controls.Add(this.ButtonSave);
            this.Panel1.Controls.Add(this.DataGridViewStock);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.TextBoxDescription);
            this.Panel1.Controls.Add(this.LabelID);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(960, 622);
            this.Panel1.TabIndex = 14;
            // 
            // PanelBarcode
            // 
            this.PanelBarcode.BackColor = System.Drawing.Color.Transparent;
            this.PanelBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBarcode.Controls.Add(this.CheckBoxBarcode);
            this.PanelBarcode.Controls.Add(this.LabelBarcode);
            this.PanelBarcode.Controls.Add(this.TextBoxSearch2);
            this.PanelBarcode.Location = new System.Drawing.Point(305, 68);
            this.PanelBarcode.Name = "PanelBarcode";
            this.PanelBarcode.Size = new System.Drawing.Size(635, 43);
            this.PanelBarcode.TabIndex = 21;
            // 
            // CheckBoxBarcode
            // 
            this.CheckBoxBarcode.AutoSize = true;
            this.CheckBoxBarcode.Location = new System.Drawing.Point(9, 14);
            this.CheckBoxBarcode.Name = "CheckBoxBarcode";
            this.CheckBoxBarcode.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxBarcode.TabIndex = 8;
            this.CheckBoxBarcode.UseVisualStyleBackColor = true;
            this.CheckBoxBarcode.CheckedChanged += new System.EventHandler(this.CheckBoxBarcode_CheckedChanged);
            // 
            // LabelBarcode
            // 
            this.LabelBarcode.AutoSize = true;
            this.LabelBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBarcode.Location = new System.Drawing.Point(24, 9);
            this.LabelBarcode.Name = "LabelBarcode";
            this.LabelBarcode.Size = new System.Drawing.Size(156, 24);
            this.LabelBarcode.TabIndex = 0;
            this.LabelBarcode.Text = "Código de Barras";
            // 
            // TextBoxSearch2
            // 
            this.TextBoxSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch2.Location = new System.Drawing.Point(186, 6);
            this.TextBoxSearch2.Name = "TextBoxSearch2";
            this.TextBoxSearch2.Size = new System.Drawing.Size(434, 29);
            this.TextBoxSearch2.TabIndex = 9;
            this.TextBoxSearch2.TextChanged += new System.EventHandler(this.TextBoxSearch2_TextChanged);
            // 
            // TextBoxBarcode
            // 
            this.TextBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBarcode.Location = new System.Drawing.Point(20, 172);
            this.TextBoxBarcode.Name = "TextBoxBarcode";
            this.TextBoxBarcode.Size = new System.Drawing.Size(260, 29);
            this.TextBoxBarcode.TabIndex = 33;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(16, 225);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(84, 24);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "Cantidad";
            // 
            // PanelNumeric
            // 
            this.PanelNumeric.BackColor = System.Drawing.Color.Transparent;
            this.PanelNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelNumeric.Controls.Add(this.LabelComparison);
            this.PanelNumeric.Controls.Add(this.NumericSearch);
            this.PanelNumeric.Controls.Add(this.LabelQuantity);
            this.PanelNumeric.Controls.Add(this.CheckBoxQuantity);
            this.PanelNumeric.Location = new System.Drawing.Point(715, 15);
            this.PanelNumeric.Name = "PanelNumeric";
            this.PanelNumeric.Size = new System.Drawing.Size(225, 43);
            this.PanelNumeric.TabIndex = 21;
            // 
            // LabelComparison
            // 
            this.LabelComparison.AutoSize = true;
            this.LabelComparison.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelComparison.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelComparison.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelComparison.Location = new System.Drawing.Point(115, 9);
            this.LabelComparison.Name = "LabelComparison";
            this.LabelComparison.Size = new System.Drawing.Size(22, 24);
            this.LabelComparison.TabIndex = 12;
            this.LabelComparison.Text = ">";
            this.LabelComparison.Click += new System.EventHandler(this.LabelComparison_Click);
            this.LabelComparison.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelComparison_MouseDown);
            this.LabelComparison.MouseLeave += new System.EventHandler(this.LabelComparison_MouseLeave);
            this.LabelComparison.MouseHover += new System.EventHandler(this.LabelComparison_MouseHover);
            this.LabelComparison.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelComparison_MouseUp);
            // 
            // NumericSearch
            // 
            this.NumericSearch.Enabled = false;
            this.NumericSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NumericSearch.Location = new System.Drawing.Point(148, 6);
            this.NumericSearch.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericSearch.Name = "NumericSearch";
            this.NumericSearch.Size = new System.Drawing.Size(62, 29);
            this.NumericSearch.TabIndex = 11;
            this.NumericSearch.ValueChanged += new System.EventHandler(this.NumericSearch_ValueChanged);
            // 
            // LabelQuantity
            // 
            this.LabelQuantity.AutoSize = true;
            this.LabelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuantity.Location = new System.Drawing.Point(24, 9);
            this.LabelQuantity.Name = "LabelQuantity";
            this.LabelQuantity.Size = new System.Drawing.Size(84, 24);
            this.LabelQuantity.TabIndex = 0;
            this.LabelQuantity.Text = "Cantidad";
            // 
            // CheckBoxQuantity
            // 
            this.CheckBoxQuantity.AutoSize = true;
            this.CheckBoxQuantity.Location = new System.Drawing.Point(9, 15);
            this.CheckBoxQuantity.Name = "CheckBoxQuantity";
            this.CheckBoxQuantity.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxQuantity.TabIndex = 10;
            this.CheckBoxQuantity.UseVisualStyleBackColor = true;
            this.CheckBoxQuantity.CheckedChanged += new System.EventHandler(this.CheckBoxQuantity_CheckedChanged);
            // 
            // PanelText
            // 
            this.PanelText.BackColor = System.Drawing.Color.Transparent;
            this.PanelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelText.Controls.Add(this.CheckBoxDescription);
            this.PanelText.Controls.Add(this.LabelDescription);
            this.PanelText.Controls.Add(this.TextBoxSearch);
            this.PanelText.Location = new System.Drawing.Point(305, 15);
            this.PanelText.Name = "PanelText";
            this.PanelText.Size = new System.Drawing.Size(398, 43);
            this.PanelText.TabIndex = 20;
            // 
            // CheckBoxDescription
            // 
            this.CheckBoxDescription.AutoSize = true;
            this.CheckBoxDescription.Checked = true;
            this.CheckBoxDescription.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxDescription.Location = new System.Drawing.Point(9, 14);
            this.CheckBoxDescription.Name = "CheckBoxDescription";
            this.CheckBoxDescription.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxDescription.TabIndex = 8;
            this.CheckBoxDescription.UseVisualStyleBackColor = true;
            this.CheckBoxDescription.CheckedChanged += new System.EventHandler(this.CheckBoxDescription_CheckedChanged);
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescription.Location = new System.Drawing.Point(24, 9);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(110, 24);
            this.LabelDescription.TabIndex = 0;
            this.LabelDescription.Text = "Descripción";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(140, 6);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(247, 29);
            this.TextBoxSearch.TabIndex = 9;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // NumericQuantity
            // 
            this.NumericQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NumericQuantity.Location = new System.Drawing.Point(20, 251);
            this.NumericQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericQuantity.Name = "NumericQuantity";
            this.NumericQuantity.Size = new System.Drawing.Size(260, 29);
            this.NumericQuantity.TabIndex = 24;
            // 
            // PanelWarning
            // 
            this.PanelWarning.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelWarning.Controls.Add(this.LabelWarning);
            this.PanelWarning.Controls.Add(this.ButtonDelete);
            this.PanelWarning.Controls.Add(this.ButtonEdit);
            this.PanelWarning.Controls.Add(this.LabelSelection);
            this.PanelWarning.Location = new System.Drawing.Point(305, 577);
            this.PanelWarning.Name = "PanelWarning";
            this.PanelWarning.Size = new System.Drawing.Size(635, 30);
            this.PanelWarning.TabIndex = 17;
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWarning.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelWarning.Location = new System.Drawing.Point(104, 8);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(244, 15);
            this.LabelWarning.TabIndex = 0;
            this.LabelWarning.Text = "(No se pueden editar más de 100 registros)";
            this.LabelWarning.Visible = false;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonDelete.Location = new System.Drawing.Point(565, 0);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(70, 30);
            this.ButtonDelete.TabIndex = 16;
            this.ButtonDelete.Text = "x";
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonEdit.Enabled = false;
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonEdit.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.ButtonEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonEdit.Location = new System.Drawing.Point(495, 0);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(70, 30);
            this.ButtonEdit.TabIndex = 15;
            this.ButtonEdit.Text = "+";
            this.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // LabelSelection
            // 
            this.LabelSelection.AutoSize = true;
            this.LabelSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSelection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelSelection.Location = new System.Drawing.Point(4, 8);
            this.LabelSelection.Name = "LabelSelection";
            this.LabelSelection.Size = new System.Drawing.Size(95, 15);
            this.LabelSelection.TabIndex = 0;
            this.LabelSelection.Text = "Seleccionado: 1";
            // 
            // ButtonNew
            // 
            this.ButtonNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNew.Image = global::Interface.Properties.Resources.Button6;
            this.ButtonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonNew.Location = new System.Drawing.Point(155, 568);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(125, 39);
            this.ButtonNew.TabIndex = 29;
            this.ButtonNew.Text = "Nuevo";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Image = global::Interface.Properties.Resources.Button1;
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new System.Drawing.Point(20, 568);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(125, 39);
            this.ButtonSave.TabIndex = 28;
            this.ButtonSave.Text = "Guardar";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // DataGridViewStock
            // 
            this.DataGridViewStock.AllowUserToAddRows = false;
            this.DataGridViewStock.AllowUserToDeleteRows = false;
            this.DataGridViewStock.AllowUserToResizeColumns = false;
            this.DataGridViewStock.AllowUserToResizeRows = false;
            this.DataGridViewStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Description,
            this.Barcode,
            this.Quantity,
            this.State,
            this.Unity,
            this.Prices,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewStock.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewStock.Location = new System.Drawing.Point(305, 128);
            this.DataGridViewStock.Name = "DataGridViewStock";
            this.DataGridViewStock.ReadOnly = true;
            this.DataGridViewStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewStock.RowHeadersVisible = false;
            this.DataGridViewStock.RowHeadersWidth = 20;
            this.DataGridViewStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewStock.Size = new System.Drawing.Size(635, 443);
            this.DataGridViewStock.TabIndex = 30;
            this.DataGridViewStock.TabStop = false;
            this.DataGridViewStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUnity_CellContentClick);
            this.DataGridViewStock.CurrentCellChanged += new System.EventHandler(this.DataGridViewStock_CurrentCellChanged);
            this.DataGridViewStock.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewStock_DataBindingComplete);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(20, 145);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(155, 24);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Código de barras";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(20, 68);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(110, 24);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Descripción";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.Location = new System.Drawing.Point(20, 94);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(260, 29);
            this.TextBoxDescription.TabIndex = 23;
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Enabled = false;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelID.Location = new System.Drawing.Point(20, 25);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(20, 24);
            this.LabelID.TabIndex = 19;
            this.LabelID.Text = "0";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID_PRODUCT";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "description";
            this.Description.Frozen = true;
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Description.Width = 290;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "barcode";
            this.Barcode.Frozen = true;
            this.Barcode.HeaderText = "Código";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.Frozen = true;
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.Width = 170;
            // 
            // State
            // 
            this.State.DataPropertyName = "state";
            this.State.Frozen = true;
            this.State.HeaderText = "Estado";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.State.Visible = false;
            // 
            // Unity
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Unity.DefaultCellStyle = dataGridViewCellStyle2;
            this.Unity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Unity.Frozen = true;
            this.Unity.HeaderText = "Unidades";
            this.Unity.Name = "Unity";
            this.Unity.ReadOnly = true;
            this.Unity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Unity.Text = "◕";
            this.Unity.UseColumnTextForButtonValue = true;
            this.Unity.Width = 70;
            // 
            // Prices
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            this.Prices.DefaultCellStyle = dataGridViewCellStyle3;
            this.Prices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Prices.Frozen = true;
            this.Prices.HeaderText = "Precios";
            this.Prices.Name = "Prices";
            this.Prices.ReadOnly = true;
            this.Prices.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Prices.Text = "$";
            this.Prices.UseColumnTextForButtonValue = true;
            this.Prices.Width = 70;
            // 
            // Edit
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle4;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit.Frozen = true;
            this.Edit.HeaderText = "Editar";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "+";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 70;
            // 
            // Delete
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle5;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Frozen = true;
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "x";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 70;
            // 
            // StockUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Panel1);
            this.Name = "StockUC";
            this.Size = new System.Drawing.Size(960, 622);
            this.Load += new System.EventHandler(this.StockUC_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.PanelBarcode.ResumeLayout(false);
            this.PanelBarcode.PerformLayout();
            this.PanelNumeric.ResumeLayout(false);
            this.PanelNumeric.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSearch)).EndInit();
            this.PanelText.ResumeLayout(false);
            this.PanelText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).EndInit();
            this.PanelWarning.ResumeLayout(false);
            this.PanelWarning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel PanelNumeric;
        private System.Windows.Forms.NumericUpDown NumericSearch;
        private System.Windows.Forms.Label LabelQuantity;
        private System.Windows.Forms.CheckBox CheckBoxQuantity;
        private System.Windows.Forms.Panel PanelText;
        private System.Windows.Forms.CheckBox CheckBoxDescription;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.NumericUpDown NumericQuantity;
        private System.Windows.Forms.Panel PanelWarning;
        private System.Windows.Forms.Label LabelWarning;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Label LabelSelection;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.DataGridView DataGridViewStock;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelComparison;
        private System.Windows.Forms.TextBox TextBoxBarcode;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Panel PanelBarcode;
        private System.Windows.Forms.CheckBox CheckBoxBarcode;
        private System.Windows.Forms.Label LabelBarcode;
        private System.Windows.Forms.TextBox TextBoxSearch2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewButtonColumn Unity;
        private System.Windows.Forms.DataGridViewButtonColumn Prices;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
