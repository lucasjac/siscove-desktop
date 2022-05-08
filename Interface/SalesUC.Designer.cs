namespace Interface
{
    partial class SalesUC
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
            this.ButtonRedirect = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TextBoxBarcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelValue = new System.Windows.Forms.Label();
            this.LabelQuantity = new System.Windows.Forms.Label();
            this.ComboBoxUnity = new System.Windows.Forms.ComboBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.CheckBoxF = new System.Windows.Forms.CheckBox();
            this.ComboBoxPrice = new System.Windows.Forms.ComboBox();
            this.ButtonNew = new System.Windows.Forms.Button();
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
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxClient = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.DataGridViewSales = new System.Windows.Forms.DataGridView();
            this.LabelID = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.ButtonRedirect);
            this.Panel1.Controls.Add(this.CleanButton);
            this.Panel1.Controls.Add(this.panel4);
            this.Panel1.Controls.Add(this.LabelInfoID);
            this.Panel1.Controls.Add(this.panel3);
            this.Panel1.Controls.Add(this.panel2);
            this.Panel1.Controls.Add(this.ButtonSave);
            this.Panel1.Controls.Add(this.DataGridViewSales);
            this.Panel1.Controls.Add(this.LabelID);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(960, 622);
            this.Panel1.TabIndex = 0;
            // 
            // ButtonRedirect
            // 
            this.ButtonRedirect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.ButtonRedirect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonRedirect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.ButtonRedirect.FlatAppearance.BorderSize = 2;
            this.ButtonRedirect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRedirect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRedirect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonRedirect.Location = new System.Drawing.Point(159, 27);
            this.ButtonRedirect.Name = "ButtonRedirect";
            this.ButtonRedirect.Size = new System.Drawing.Size(125, 39);
            this.ButtonRedirect.TabIndex = 109;
            this.ButtonRedirect.Text = "Ir a Lista";
            this.ButtonRedirect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonRedirect.UseVisualStyleBackColor = false;
            this.ButtonRedirect.Click += new System.EventHandler(this.ButtonRedirect_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CleanButton.Enabled = false;
            this.CleanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanButton.Image = global::Interface.Properties.Resources.Button9;
            this.CleanButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CleanButton.Location = new System.Drawing.Point(159, 563);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(125, 39);
            this.CleanButton.TabIndex = 12;
            this.CleanButton.Text = "Limpiar";
            this.CleanButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CleanButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.TextBoxBarcode);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.LabelValue);
            this.panel4.Controls.Add(this.LabelQuantity);
            this.panel4.Controls.Add(this.ComboBoxUnity);
            this.panel4.Controls.Add(this.ButtonAdd);
            this.panel4.Controls.Add(this.CheckBoxF);
            this.panel4.Controls.Add(this.ComboBoxPrice);
            this.panel4.Controls.Add(this.ButtonNew);
            this.panel4.Controls.Add(this.NumericQuantity);
            this.panel4.Controls.Add(this.ComboBoxProduct);
            this.panel4.Controls.Add(this.Label1);
            this.panel4.Controls.Add(this.Label3);
            this.panel4.Controls.Add(this.Label2);
            this.panel4.Location = new System.Drawing.Point(24, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 379);
            this.panel4.TabIndex = 0;
            // 
            // TextBoxBarcode
            // 
            this.TextBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TextBoxBarcode.Location = new System.Drawing.Point(14, 40);
            this.TextBoxBarcode.Name = "TextBoxBarcode";
            this.TextBoxBarcode.Size = new System.Drawing.Size(235, 29);
            this.TextBoxBarcode.TabIndex = 0;
            this.TextBoxBarcode.TextChanged += new System.EventHandler(this.TextBoxBarcode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 24);
            this.label6.TabIndex = 120;
            this.label6.Text = "Buscar por Código";
            // 
            // LabelValue
            // 
            this.LabelValue.AutoSize = true;
            this.LabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValue.Location = new System.Drawing.Point(181, 227);
            this.LabelValue.Name = "LabelValue";
            this.LabelValue.Size = new System.Drawing.Size(20, 24);
            this.LabelValue.TabIndex = 118;
            this.LabelValue.Text = "0";
            this.LabelValue.Visible = false;
            // 
            // LabelQuantity
            // 
            this.LabelQuantity.AutoSize = true;
            this.LabelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuantity.Location = new System.Drawing.Point(97, 226);
            this.LabelQuantity.Name = "LabelQuantity";
            this.LabelQuantity.Size = new System.Drawing.Size(20, 24);
            this.LabelQuantity.TabIndex = 117;
            this.LabelQuantity.Text = "0";
            this.LabelQuantity.Visible = false;
            // 
            // ComboBoxUnity
            // 
            this.ComboBoxUnity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxUnity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxUnity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ComboBoxUnity.FormattingEnabled = true;
            this.ComboBoxUnity.Location = new System.Drawing.Point(93, 192);
            this.ComboBoxUnity.Name = "ComboBoxUnity";
            this.ComboBoxUnity.Size = new System.Drawing.Size(111, 32);
            this.ComboBoxUnity.TabIndex = 2;
            this.ComboBoxUnity.SelectedIndexChanged += new System.EventHandler(this.ComboBoxUnity_SelectedIndexChanged);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Image = global::Interface.Properties.Resources.Button6;
            this.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new System.Drawing.Point(124, 319);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(125, 39);
            this.ButtonAdd.TabIndex = 5;
            this.ButtonAdd.Text = "Añadir";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // CheckBoxF
            // 
            this.CheckBoxF.AutoSize = true;
            this.CheckBoxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CheckBoxF.Location = new System.Drawing.Point(210, 192);
            this.CheckBoxF.Name = "CheckBoxF";
            this.CheckBoxF.Size = new System.Drawing.Size(41, 28);
            this.CheckBoxF.TabIndex = 4;
            this.CheckBoxF.Text = "F";
            this.CheckBoxF.UseVisualStyleBackColor = true;
            this.CheckBoxF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckBoxF_KeyDown);
            // 
            // ComboBoxPrice
            // 
            this.ComboBoxPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ComboBoxPrice.Location = new System.Drawing.Point(14, 269);
            this.ComboBoxPrice.Name = "ComboBoxPrice";
            this.ComboBoxPrice.Size = new System.Drawing.Size(235, 32);
            this.ComboBoxPrice.TabIndex = 3;
            this.ComboBoxPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxPrice_KeyDown);
            // 
            // ButtonNew
            // 
            this.ButtonNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonNew.Location = new System.Drawing.Point(14, 319);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(80, 39);
            this.ButtonNew.TabIndex = 6;
            this.ButtonNew.Text = "Nuevo";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // NumericQuantity
            // 
            this.NumericQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumericQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NumericQuantity.Location = new System.Drawing.Point(14, 192);
            this.NumericQuantity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumericQuantity.Name = "NumericQuantity";
            this.NumericQuantity.Size = new System.Drawing.Size(73, 25);
            this.NumericQuantity.TabIndex = 1;
            this.NumericQuantity.ValueChanged += new System.EventHandler(this.NumericQuantity_ValueChanged);
            this.NumericQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumericQuantity_KeyDown);
            // 
            // ComboBoxProduct
            // 
            this.ComboBoxProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxProduct.DropDownHeight = 200;
            this.ComboBoxProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ComboBoxProduct.FormattingEnabled = true;
            this.ComboBoxProduct.IntegralHeight = false;
            this.ComboBoxProduct.Location = new System.Drawing.Point(14, 115);
            this.ComboBoxProduct.Name = "ComboBoxProduct";
            this.ComboBoxProduct.Size = new System.Drawing.Size(235, 32);
            this.ComboBoxProduct.TabIndex = 0;
            this.ComboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProduct_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(10, 89);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(86, 24);
            this.Label1.TabIndex = 108;
            this.Label1.Text = "Producto";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(10, 243);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 24);
            this.Label3.TabIndex = 110;
            this.Label3.Text = "Precio";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(10, 166);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 24);
            this.Label2.TabIndex = 109;
            this.Label2.Text = "Cantidad";
            // 
            // LabelInfoID
            // 
            this.LabelInfoID.AutoSize = true;
            this.LabelInfoID.Enabled = false;
            this.LabelInfoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfoID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelInfoID.Location = new System.Drawing.Point(49, 20);
            this.LabelInfoID.Name = "LabelInfoID";
            this.LabelInfoID.Size = new System.Drawing.Size(20, 24);
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
            this.LabelWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWarning.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelWarning.Location = new System.Drawing.Point(104, 8);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(237, 15);
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
            this.ButtonEdit.TabIndex = 14;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.DateTimePicker);
            this.panel2.Controls.Add(this.ComboBoxClient);
            this.panel2.Controls.Add(this.Label5);
            this.panel2.Controls.Add(this.Label4);
            this.panel2.Location = new System.Drawing.Point(305, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 49);
            this.panel2.TabIndex = 7;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(470, 10);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(151, 29);
            this.DateTimePicker.TabIndex = 8;
            // 
            // ComboBoxClient
            // 
            this.ComboBoxClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ComboBoxClient.FormattingEnabled = true;
            this.ComboBoxClient.Items.AddRange(new object[] {
            "No definido"});
            this.ComboBoxClient.Location = new System.Drawing.Point(85, 10);
            this.ComboBoxClient.Name = "ComboBoxClient";
            this.ComboBoxClient.Size = new System.Drawing.Size(308, 32);
            this.ComboBoxClient.TabIndex = 7;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(399, 14);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 24);
            this.Label5.TabIndex = 107;
            this.Label5.Text = "Fecha";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(10, 14);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(68, 24);
            this.Label4.TabIndex = 106;
            this.Label4.Text = "Cliente";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Image = global::Interface.Properties.Resources.Button1;
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new System.Drawing.Point(24, 563);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(125, 39);
            this.ButtonSave.TabIndex = 10;
            this.ButtonSave.Text = "Guardar";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // DataGridViewSales
            // 
            this.DataGridViewSales.AllowUserToAddRows = false;
            this.DataGridViewSales.AllowUserToDeleteRows = false;
            this.DataGridViewSales.AllowUserToResizeColumns = false;
            this.DataGridViewSales.AllowUserToResizeRows = false;
            this.DataGridViewSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDInfo,
            this.IDProduct,
            this.Description,
            this.Price,
            this.Price2,
            this.Quantity,
            this.Difference,
            this.Total,
            this.Invoice,
            this.F,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewSales.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewSales.Location = new System.Drawing.Point(305, 89);
            this.DataGridViewSales.Name = "DataGridViewSales";
            this.DataGridViewSales.ReadOnly = true;
            this.DataGridViewSales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewSales.RowHeadersVisible = false;
            this.DataGridViewSales.RowHeadersWidth = 20;
            this.DataGridViewSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewSales.Size = new System.Drawing.Size(635, 462);
            this.DataGridViewSales.TabIndex = 98;
            this.DataGridViewSales.TabStop = false;
            this.DataGridViewSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSales_CellContentClick);
            this.DataGridViewSales.CurrentCellChanged += new System.EventHandler(this.DataGridViewSales_CurrentCellChanged);
            this.DataGridViewSales.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewSales_DataBindingComplete);
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Enabled = false;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelID.Location = new System.Drawing.Point(20, 20);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(20, 24);
            this.LabelID.TabIndex = 79;
            this.LabelID.Text = "0";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID_SALE";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // IDInfo
            // 
            this.IDInfo.DataPropertyName = "FK_ID_SALE_INFO";
            this.IDInfo.Frozen = true;
            this.IDInfo.HeaderText = "ID_Info";
            this.IDInfo.Name = "IDInfo";
            this.IDInfo.ReadOnly = true;
            this.IDInfo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDInfo.Visible = false;
            // 
            // IDProduct
            // 
            this.IDProduct.DataPropertyName = "FK_ID_PRODUCT";
            this.IDProduct.Frozen = true;
            this.IDProduct.HeaderText = "ID_Product";
            this.IDProduct.Name = "IDProduct";
            this.IDProduct.ReadOnly = true;
            this.IDProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDProduct.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "description";
            this.Description.Frozen = true;
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Description.Width = 159;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.Frozen = true;
            this.Price.HeaderText = "Precio";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.Visible = false;
            this.Price.Width = 177;
            // 
            // Price2
            // 
            this.Price2.Frozen = true;
            this.Price2.HeaderText = "Precio c/u";
            this.Price2.Name = "Price2";
            this.Price2.ReadOnly = true;
            this.Price2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price2.Width = 177;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.Frozen = true;
            this.Quantity.HeaderText = "Cantidad p/u";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.Width = 123;
            // 
            // Difference
            // 
            this.Difference.DataPropertyName = "difference";
            this.Difference.Frozen = true;
            this.Difference.HeaderText = "Diferencia";
            this.Difference.Name = "Difference";
            this.Difference.ReadOnly = true;
            this.Difference.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Difference.Visible = false;
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
            this.Invoice.DataPropertyName = "invoice";
            this.Invoice.Frozen = true;
            this.Invoice.HeaderText = "Factura";
            this.Invoice.Name = "Invoice";
            this.Invoice.ReadOnly = true;
            this.Invoice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Invoice.Visible = false;
            this.Invoice.Width = 10;
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
            // SalesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Panel1);
            this.Name = "SalesUC";
            this.Size = new System.Drawing.Size(960, 622);
            this.Load += new System.EventHandler(this.SalesUC_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.DataGridView DataGridViewSales;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelWarning;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Label LabelSelection;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.ComboBox ComboBoxClient;
        private System.Windows.Forms.Label LabelInfoID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.CheckBox CheckBoxF;
        private System.Windows.Forms.ComboBox ComboBoxPrice;
        private System.Windows.Forms.NumericUpDown NumericQuantity;
        private System.Windows.Forms.ComboBox ComboBoxProduct;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ComboBox ComboBoxUnity;
        private System.Windows.Forms.Label LabelQuantity;
        private System.Windows.Forms.Label LabelValue;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button ButtonRedirect;
        private System.Windows.Forms.TextBox TextBoxBarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
