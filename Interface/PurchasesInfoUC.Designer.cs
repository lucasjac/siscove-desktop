namespace Interface
{
    partial class PurchasesInfoUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Label6 = new System.Windows.Forms.Label();
            this.ComboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.PriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.LabelEqual2 = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Label4 = new System.Windows.Forms.Label();
            this.QuantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.LabelEqual = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.ComboBoxProduct = new System.Windows.Forms.ComboBox();
            this.ComboBoxList = new System.Windows.Forms.ComboBox();
            this.UntilTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.SinceTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LabelInfoID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.LabelSelection = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.DataGridViewPurchasesInfo = new System.Windows.Forms.DataGridView();
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
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumeric)).BeginInit();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumeric)).BeginInit();
            this.Panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPurchasesInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.ButtonNew);
            this.Panel1.Controls.Add(this.panel7);
            this.Panel1.Controls.Add(this.panel6);
            this.Panel1.Controls.Add(this.panel5);
            this.Panel1.Controls.Add(this.Panel4);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Controls.Add(this.ComboBoxList);
            this.Panel1.Controls.Add(this.UntilTimePicker);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.SinceTimePicker);
            this.Panel1.Controls.Add(this.LabelInfoID);
            this.Panel1.Controls.Add(this.panel3);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.DataGridViewPurchasesInfo);
            this.Panel1.Controls.Add(this.LabelID);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(960, 622);
            this.Panel1.TabIndex = 0;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // ButtonNew
            // 
            this.ButtonNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonNew.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNew.Image = global::Interface.Properties.Resources.Button6;
            this.ButtonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonNew.Location = new System.Drawing.Point(20, 562);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(125, 39);
            this.ButtonNew.TabIndex = 114;
            this.ButtonNew.Text = "   Limpiar";
            this.ButtonNew.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.Label6);
            this.panel7.Controls.Add(this.ComboBoxCustomer);
            this.panel7.Location = new System.Drawing.Point(20, 362);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(265, 51);
            this.panel7.TabIndex = 124;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(8, 14);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(73, 23);
            this.Label6.TabIndex = 112;
            this.Label6.Text = "Cliente";
            // 
            // ComboBoxCustomer
            // 
            this.ComboBoxCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxCustomer.Font = new System.Drawing.Font("Square721 BT", 14.25F);
            this.ComboBoxCustomer.FormattingEnabled = true;
            this.ComboBoxCustomer.Location = new System.Drawing.Point(87, 11);
            this.ComboBoxCustomer.Name = "ComboBoxCustomer";
            this.ComboBoxCustomer.Size = new System.Drawing.Size(171, 31);
            this.ComboBoxCustomer.TabIndex = 113;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Label);
            this.panel6.Location = new System.Drawing.Point(210, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(75, 71);
            this.panel6.TabIndex = 126;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(17, 24);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(40, 23);
            this.Label.TabIndex = 124;
            this.Label.Text = "S/F";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Label5);
            this.panel5.Controls.Add(this.PriceNumeric);
            this.panel5.Controls.Add(this.LabelEqual2);
            this.panel5.Location = new System.Drawing.Point(20, 288);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 51);
            this.panel5.TabIndex = 125;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(8, 14);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 23);
            this.Label5.TabIndex = 117;
            this.Label5.Text = "Precio";
            // 
            // PriceNumeric
            // 
            this.PriceNumeric.Font = new System.Drawing.Font("Square721 BT", 14.25F);
            this.PriceNumeric.Location = new System.Drawing.Point(105, 12);
            this.PriceNumeric.Name = "PriceNumeric";
            this.PriceNumeric.Size = new System.Drawing.Size(153, 31);
            this.PriceNumeric.TabIndex = 118;
            // 
            // LabelEqual2
            // 
            this.LabelEqual2.AutoSize = true;
            this.LabelEqual2.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEqual2.Location = new System.Drawing.Point(73, 14);
            this.LabelEqual2.Name = "LabelEqual2";
            this.LabelEqual2.Size = new System.Drawing.Size(26, 23);
            this.LabelEqual2.TabIndex = 119;
            this.LabelEqual2.Text = "=";
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Transparent;
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.Label4);
            this.Panel4.Controls.Add(this.QuantityNumeric);
            this.Panel4.Controls.Add(this.LabelEqual);
            this.Panel4.Location = new System.Drawing.Point(20, 214);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(265, 51);
            this.Panel4.TabIndex = 124;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(7, 14);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(91, 23);
            this.Label4.TabIndex = 114;
            this.Label4.Text = "Cantidad";
            // 
            // QuantityNumeric
            // 
            this.QuantityNumeric.Font = new System.Drawing.Font("Square721 BT", 14.25F);
            this.QuantityNumeric.Location = new System.Drawing.Point(128, 12);
            this.QuantityNumeric.Name = "QuantityNumeric";
            this.QuantityNumeric.Size = new System.Drawing.Size(130, 31);
            this.QuantityNumeric.TabIndex = 115;
            // 
            // LabelEqual
            // 
            this.LabelEqual.AutoSize = true;
            this.LabelEqual.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEqual.Location = new System.Drawing.Point(96, 14);
            this.LabelEqual.Name = "LabelEqual";
            this.LabelEqual.Size = new System.Drawing.Size(26, 23);
            this.LabelEqual.TabIndex = 116;
            this.LabelEqual.Text = "=";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.ComboBoxProduct);
            this.Panel2.Location = new System.Drawing.Point(20, 140);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(265, 51);
            this.Panel2.TabIndex = 122;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(8, 14);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 23);
            this.Label3.TabIndex = 112;
            this.Label3.Text = "Producto";
            // 
            // ComboBoxProduct
            // 
            this.ComboBoxProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxProduct.Font = new System.Drawing.Font("Square721 BT", 14.25F);
            this.ComboBoxProduct.FormattingEnabled = true;
            this.ComboBoxProduct.Location = new System.Drawing.Point(109, 11);
            this.ComboBoxProduct.Name = "ComboBoxProduct";
            this.ComboBoxProduct.Size = new System.Drawing.Size(149, 31);
            this.ComboBoxProduct.TabIndex = 113;
            // 
            // ComboBoxList
            // 
            this.ComboBoxList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxList.Font = new System.Drawing.Font("Square721 BT", 14.25F);
            this.ComboBoxList.FormattingEnabled = true;
            this.ComboBoxList.Location = new System.Drawing.Point(305, 20);
            this.ComboBoxList.Name = "ComboBoxList";
            this.ComboBoxList.Size = new System.Drawing.Size(635, 31);
            this.ComboBoxList.TabIndex = 121;
            // 
            // UntilTimePicker
            // 
            this.UntilTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UntilTimePicker.Font = new System.Drawing.Font("Square721 BT", 14.25F);
            this.UntilTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UntilTimePicker.Location = new System.Drawing.Point(94, 97);
            this.UntilTimePicker.Name = "UntilTimePicker";
            this.UntilTimePicker.Size = new System.Drawing.Size(109, 31);
            this.UntilTimePicker.TabIndex = 111;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(20, 103);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 23);
            this.Label2.TabIndex = 110;
            this.Label2.Text = "hasta";
            // 
            // SinceTimePicker
            // 
            this.SinceTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SinceTimePicker.Font = new System.Drawing.Font("Square721 BT", 14.25F);
            this.SinceTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SinceTimePicker.Location = new System.Drawing.Point(94, 57);
            this.SinceTimePicker.Name = "SinceTimePicker";
            this.SinceTimePicker.Size = new System.Drawing.Size(109, 31);
            this.SinceTimePicker.TabIndex = 109;
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
            this.LabelWarning.Location = new System.Drawing.Point(195, 8);
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
            // LabelSelection
            // 
            this.LabelSelection.AutoSize = true;
            this.LabelSelection.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSelection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelSelection.Location = new System.Drawing.Point(4, 8);
            this.LabelSelection.Name = "LabelSelection";
            this.LabelSelection.Size = new System.Drawing.Size(183, 15);
            this.LabelSelection.TabIndex = 0;
            this.LabelSelection.Text = "Listados: ... / Seleccionado: 1";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(20, 63);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 23);
            this.Label1.TabIndex = 80;
            this.Label1.Text = "Desde";
            // 
            // DataGridViewPurchasesInfo
            // 
            this.DataGridViewPurchasesInfo.AllowUserToAddRows = false;
            this.DataGridViewPurchasesInfo.AllowUserToDeleteRows = false;
            this.DataGridViewPurchasesInfo.AllowUserToResizeColumns = false;
            this.DataGridViewPurchasesInfo.AllowUserToResizeRows = false;
            this.DataGridViewPurchasesInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPurchasesInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewPurchasesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPurchasesInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewPurchasesInfo.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewPurchasesInfo.Location = new System.Drawing.Point(305, 63);
            this.DataGridViewPurchasesInfo.Name = "DataGridViewPurchasesInfo";
            this.DataGridViewPurchasesInfo.ReadOnly = true;
            this.DataGridViewPurchasesInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPurchasesInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewPurchasesInfo.RowHeadersVisible = false;
            this.DataGridViewPurchasesInfo.RowHeadersWidth = 20;
            this.DataGridViewPurchasesInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewPurchasesInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPurchasesInfo.Size = new System.Drawing.Size(635, 488);
            this.DataGridViewPurchasesInfo.TabIndex = 98;
            this.DataGridViewPurchasesInfo.TabStop = false;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
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
            // PurchasesInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Panel1);
            this.Name = "PurchasesInfoUC";
            this.Size = new System.Drawing.Size(960, 622);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumeric)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumeric)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPurchasesInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView DataGridViewPurchasesInfo;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelWarning;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label LabelSelection;
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
        private System.Windows.Forms.DateTimePicker UntilTimePicker;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DateTimePicker SinceTimePicker;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.ComboBox ComboBoxProduct;
        private System.Windows.Forms.NumericUpDown QuantityNumeric;
        private System.Windows.Forms.Label LabelEqual;
        private System.Windows.Forms.Label LabelEqual2;
        private System.Windows.Forms.NumericUpDown PriceNumeric;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.ComboBox ComboBoxList;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.ComboBox ComboBoxCustomer;
        private System.Windows.Forms.Button ButtonNew;
    }
}
