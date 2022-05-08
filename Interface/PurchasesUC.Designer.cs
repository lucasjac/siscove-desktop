namespace Interface
{
    partial class PurchasesUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.CheckBoxF = new System.Windows.Forms.CheckBox();
            this.ComboBoxPrice = new System.Windows.Forms.ComboBox();
            this.NumericQuantity = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxProduct = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LabelInfoID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.LabelSelection = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxDistributor = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.DataGridViewPurchases = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LabelID = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.panel4);
            this.Panel1.Controls.Add(this.LabelInfoID);
            this.Panel1.Controls.Add(this.panel3);
            this.Panel1.Controls.Add(this.panel2);
            this.Panel1.Controls.Add(this.ButtonSave);
            this.Panel1.Controls.Add(this.ButtonNew);
            this.Panel1.Controls.Add(this.DataGridViewPurchases);
            this.Panel1.Controls.Add(this.LabelID);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(960, 622);
            this.Panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ButtonAdd);
            this.panel4.Controls.Add(this.CheckBoxF);
            this.panel4.Controls.Add(this.ComboBoxPrice);
            this.panel4.Controls.Add(this.NumericQuantity);
            this.panel4.Controls.Add(this.ComboBoxProduct);
            this.panel4.Controls.Add(this.Label1);
            this.panel4.Controls.Add(this.Label3);
            this.panel4.Controls.Add(this.Label2);
            this.panel4.Location = new System.Drawing.Point(24, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 295);
            this.panel4.TabIndex = 109;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonAdd.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Image = global::Interface.Properties.Resources.Button6;
            this.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new System.Drawing.Point(124, 240);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(125, 39);
            this.ButtonAdd.TabIndex = 115;
            this.ButtonAdd.Text = "Añadir";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // CheckBoxF
            // 
            this.CheckBoxF.AutoSize = true;
            this.CheckBoxF.Font = new System.Drawing.Font("Square721 BT", 14.25F);
            this.CheckBoxF.Location = new System.Drawing.Point(210, 113);
            this.CheckBoxF.Name = "CheckBoxF";
            this.CheckBoxF.Size = new System.Drawing.Size(40, 27);
            this.CheckBoxF.TabIndex = 114;
            this.CheckBoxF.Text = "F";
            this.CheckBoxF.UseVisualStyleBackColor = true;
            // 
            // ComboBoxPrice
            // 
            this.ComboBoxPrice.Font = new System.Drawing.Font("Square721 BT", 14.25F);
            this.ComboBoxPrice.FormattingEnabled = true;
            this.ComboBoxPrice.Location = new System.Drawing.Point(14, 190);
            this.ComboBoxPrice.Name = "ComboBoxPrice";
            this.ComboBoxPrice.Size = new System.Drawing.Size(235, 31);
            this.ComboBoxPrice.TabIndex = 113;
            // 
            // NumericQuantity
            // 
            this.NumericQuantity.Font = new System.Drawing.Font("Square721 BT", 14.25F);
            this.NumericQuantity.Location = new System.Drawing.Point(14, 113);
            this.NumericQuantity.Name = "NumericQuantity";
            this.NumericQuantity.Size = new System.Drawing.Size(178, 31);
            this.NumericQuantity.TabIndex = 112;
            // 
            // ComboBoxProduct
            // 
            this.ComboBoxProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxProduct.Font = new System.Drawing.Font("Square721 BT", 14.25F);
            this.ComboBoxProduct.FormattingEnabled = true;
            this.ComboBoxProduct.Location = new System.Drawing.Point(14, 36);
            this.ComboBoxProduct.Name = "ComboBoxProduct";
            this.ComboBoxProduct.Size = new System.Drawing.Size(235, 31);
            this.ComboBoxProduct.TabIndex = 111;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(10, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(95, 23);
            this.Label1.TabIndex = 108;
            this.Label1.Text = "Producto";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(10, 164);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(68, 23);
            this.Label3.TabIndex = 110;
            this.Label3.Text = "Precio";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(10, 87);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(91, 23);
            this.Label2.TabIndex = 109;
            this.Label2.Text = "Cantidad";
            // 
            // LabelInfoID
            // 
            this.LabelInfoID.AutoSize = true;
            this.LabelInfoID.Enabled = false;
            this.LabelInfoID.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfoID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelInfoID.Location = new System.Drawing.Point(49, 20);
            this.LabelInfoID.Name = "LabelInfoID";
            this.LabelInfoID.Size = new System.Drawing.Size(23, 23);
            this.LabelInfoID.TabIndex = 108;
            this.LabelInfoID.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.LabelWarning);
            this.panel3.Controls.Add(this.ButtonDelete);
            this.panel3.Controls.Add(this.ButtonEdit);
            this.panel3.Controls.Add(this.LabelSelection);
            this.panel3.Location = new System.Drawing.Point(305, 572);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 30);
            this.panel3.TabIndex = 106;
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWarning.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelWarning.Location = new System.Drawing.Point(104, 8);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(262, 15);
            this.LabelWarning.TabIndex = 0;
            this.LabelWarning.Text = "(No se pueden editar más de 50 registros)";
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
            this.ButtonDelete.TabIndex = 15;
            this.ButtonDelete.Text = "x";
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonDelete.UseVisualStyleBackColor = false;
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
            this.ButtonEdit.TabIndex = 14;
            this.ButtonEdit.Text = "+";
            this.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonEdit.UseVisualStyleBackColor = false;
            // 
            // LabelSelection
            // 
            this.LabelSelection.AutoSize = true;
            this.LabelSelection.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSelection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelSelection.Location = new System.Drawing.Point(4, 8);
            this.LabelSelection.Name = "LabelSelection";
            this.LabelSelection.Size = new System.Drawing.Size(101, 15);
            this.LabelSelection.TabIndex = 0;
            this.LabelSelection.Text = "Seleccionado: 1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.ComboBoxDistributor);
            this.panel2.Controls.Add(this.Label5);
            this.panel2.Controls.Add(this.Label4);
            this.panel2.Location = new System.Drawing.Point(305, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 49);
            this.panel2.TabIndex = 105;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Square721 BT", 14.25F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(465, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 31);
            this.dateTimePicker1.TabIndex = 108;
            // 
            // ComboBoxDistributor
            // 
            this.ComboBoxDistributor.Font = new System.Drawing.Font("Square721 BT", 14.25F);
            this.ComboBoxDistributor.FormattingEnabled = true;
            this.ComboBoxDistributor.Items.AddRange(new object[] {
            "No definido"});
            this.ComboBoxDistributor.Location = new System.Drawing.Point(134, 10);
            this.ComboBoxDistributor.Name = "ComboBoxDistributor";
            this.ComboBoxDistributor.Size = new System.Drawing.Size(242, 31);
            this.ComboBoxDistributor.TabIndex = 107;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(394, 14);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(65, 23);
            this.Label5.TabIndex = 107;
            this.Label5.Text = "Fecha";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(10, 14);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(118, 23);
            this.Label4.TabIndex = 106;
            this.Label4.Text = "Distribuidor";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSave.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Image = global::Interface.Properties.Resources.Button1;
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new System.Drawing.Point(20, 563);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(125, 39);
            this.ButtonSave.TabIndex = 93;
            this.ButtonSave.Text = "Guardar";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonNew
            // 
            this.ButtonNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonNew.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNew.Image = global::Interface.Properties.Resources.Button6;
            this.ButtonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonNew.Location = new System.Drawing.Point(155, 563);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(125, 39);
            this.ButtonNew.TabIndex = 94;
            this.ButtonNew.Text = "Nuevo";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // DataGridViewPurchases
            // 
            this.DataGridViewPurchases.AllowUserToAddRows = false;
            this.DataGridViewPurchases.AllowUserToDeleteRows = false;
            this.DataGridViewPurchases.AllowUserToResizeColumns = false;
            this.DataGridViewPurchases.AllowUserToResizeRows = false;
            this.DataGridViewPurchases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPurchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.DataGridViewPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDInfo,
            this.IDProduct,
            this.Descripcion,
            this.Price,
            this.Quantity,
            this.Total,
            this.Invoice,
            this.F,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewPurchases.DefaultCellStyle = dataGridViewCellStyle24;
            this.DataGridViewPurchases.Location = new System.Drawing.Point(305, 89);
            this.DataGridViewPurchases.Name = "DataGridViewPurchases";
            this.DataGridViewPurchases.ReadOnly = true;
            this.DataGridViewPurchases.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPurchases.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.DataGridViewPurchases.RowHeadersVisible = false;
            this.DataGridViewPurchases.RowHeadersWidth = 20;
            this.DataGridViewPurchases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPurchases.Size = new System.Drawing.Size(635, 462);
            this.DataGridViewPurchases.TabIndex = 98;
            this.DataGridViewPurchases.TabStop = false;
            this.DataGridViewPurchases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSales_CellContentClick);
            this.DataGridViewPurchases.CurrentCellChanged += new System.EventHandler(this.DataGridViewSales_CurrentCellChanged);
            this.DataGridViewPurchases.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewSales_DataBindingComplete);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_sale";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // IDInfo
            // 
            this.IDInfo.DataPropertyName = "id_sale_info";
            this.IDInfo.Frozen = true;
            this.IDInfo.HeaderText = "ID_Info";
            this.IDInfo.Name = "IDInfo";
            this.IDInfo.ReadOnly = true;
            this.IDInfo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDInfo.Visible = false;
            // 
            // IDProduct
            // 
            this.IDProduct.DataPropertyName = "id_product";
            this.IDProduct.Frozen = true;
            this.IDProduct.HeaderText = "ID_Product";
            this.IDProduct.Name = "IDProduct";
            this.IDProduct.ReadOnly = true;
            this.IDProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDProduct.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.Frozen = true;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descripcion.Width = 159;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.Frozen = true;
            this.Price.HeaderText = "Precio c/u";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.Width = 177;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.Frozen = true;
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.Width = 178;
            // 
            // Total
            // 
            this.Total.Frozen = true;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Invoice
            // 
            this.Invoice.DataPropertyName = "bool";
            this.Invoice.Frozen = true;
            this.Invoice.HeaderText = "Factura";
            this.Invoice.Name = "Invoice";
            this.Invoice.ReadOnly = true;
            this.Invoice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Invoice.Visible = false;
            this.Invoice.Width = 178;
            // 
            // F
            // 
            this.F.Frozen = true;
            this.F.HeaderText = "";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            this.F.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.F.Width = 40;
            // 
            // Edit
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle22;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit.Frozen = true;
            this.Edit.HeaderText = "Editar";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "+";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 70;
            // 
            // Delete
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle23;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Frozen = true;
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "x";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 70;
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Enabled = false;
            this.LabelID.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelID.Location = new System.Drawing.Point(20, 20);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(23, 23);
            this.LabelID.TabIndex = 79;
            this.LabelID.Text = "0";
            // 
            // PurchasesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Panel1);
            this.Name = "PurchasesUC";
            this.Size = new System.Drawing.Size(960, 622);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPurchases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.DataGridView DataGridViewPurchases;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelWarning;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Label LabelSelection;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox ComboBoxDistributor;
        private System.Windows.Forms.Label LabelInfoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.CheckBox CheckBoxF;
        private System.Windows.Forms.ComboBox ComboBoxPrice;
        private System.Windows.Forms.NumericUpDown NumericQuantity;
        private System.Windows.Forms.ComboBox ComboBoxProduct;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
    }
}
