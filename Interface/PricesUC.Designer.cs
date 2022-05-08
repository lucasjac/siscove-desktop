namespace Interface
{
    partial class PricesUC
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
            this.PictureBoxBack = new System.Windows.Forms.PictureBox();
            this.PictureBoxLine = new System.Windows.Forms.PictureBox();
            this.LabelProduct = new System.Windows.Forms.Label();
            this.TextBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonSavePrice = new System.Windows.Forms.Button();
            this.ButtonCleanPrice = new System.Windows.Forms.Button();
            this.LabelNameProduct = new System.Windows.Forms.Label();
            this.DataGridViewPrice = new System.Windows.Forms.DataGridView();
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelWarning2 = new System.Windows.Forms.Label();
            this.LabelSelection2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ButtonDeletePrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPrice)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxBack
            // 
            this.PictureBoxBack.BackgroundImage = global::Interface.Properties.Resources.Back1;
            this.PictureBoxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxBack.Location = new System.Drawing.Point(20, 20);
            this.PictureBoxBack.Name = "PictureBoxBack";
            this.PictureBoxBack.Size = new System.Drawing.Size(62, 31);
            this.PictureBoxBack.TabIndex = 103;
            this.PictureBoxBack.TabStop = false;
            this.PictureBoxBack.Click += new System.EventHandler(this.PictureBoxBack_Click);
            this.PictureBoxBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxBack_MouseDown);
            this.PictureBoxBack.MouseLeave += new System.EventHandler(this.PictureBoxBack_MouseLeave);
            this.PictureBoxBack.MouseHover += new System.EventHandler(this.PictureBoxBack_MouseHover);
            this.PictureBoxBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxBack_MouseUp);
            // 
            // PictureBoxLine
            // 
            this.PictureBoxLine.Image = global::Interface.Properties.Resources.Line;
            this.PictureBoxLine.Location = new System.Drawing.Point(20, 106);
            this.PictureBoxLine.Name = "PictureBoxLine";
            this.PictureBoxLine.Size = new System.Drawing.Size(279, 16);
            this.PictureBoxLine.TabIndex = 102;
            this.PictureBoxLine.TabStop = false;
            // 
            // LabelProduct
            // 
            this.LabelProduct.AutoSize = true;
            this.LabelProduct.Enabled = false;
            this.LabelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProduct.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelProduct.Location = new System.Drawing.Point(117, 20);
            this.LabelProduct.Name = "LabelProduct";
            this.LabelProduct.Size = new System.Drawing.Size(20, 24);
            this.LabelProduct.TabIndex = 101;
            this.LabelProduct.Text = "0";
            this.LabelProduct.Visible = false;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TextBoxPrice.Location = new System.Drawing.Point(20, 156);
            this.TextBoxPrice.Mask = "9999999999";
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(260, 29);
            this.TextBoxPrice.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 99;
            this.label6.Text = "Precio";
            // 
            // ButtonSavePrice
            // 
            this.ButtonSavePrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSavePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSavePrice.Image = global::Interface.Properties.Resources.Button1;
            this.ButtonSavePrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSavePrice.Location = new System.Drawing.Point(20, 563);
            this.ButtonSavePrice.Name = "ButtonSavePrice";
            this.ButtonSavePrice.Size = new System.Drawing.Size(125, 39);
            this.ButtonSavePrice.TabIndex = 94;
            this.ButtonSavePrice.Text = "Guardar";
            this.ButtonSavePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSavePrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSavePrice.UseVisualStyleBackColor = true;
            this.ButtonSavePrice.Click += new System.EventHandler(this.ButtonSavePrice_Click);
            // 
            // ButtonCleanPrice
            // 
            this.ButtonCleanPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCleanPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCleanPrice.Image = global::Interface.Properties.Resources.Button6;
            this.ButtonCleanPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCleanPrice.Location = new System.Drawing.Point(155, 563);
            this.ButtonCleanPrice.Name = "ButtonCleanPrice";
            this.ButtonCleanPrice.Size = new System.Drawing.Size(125, 39);
            this.ButtonCleanPrice.TabIndex = 95;
            this.ButtonCleanPrice.Text = "Nuevo";
            this.ButtonCleanPrice.UseVisualStyleBackColor = true;
            this.ButtonCleanPrice.Click += new System.EventHandler(this.ButtonCleanPrice_Click);
            // 
            // LabelNameProduct
            // 
            this.LabelNameProduct.AutoSize = true;
            this.LabelNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNameProduct.Location = new System.Drawing.Point(20, 63);
            this.LabelNameProduct.Name = "LabelNameProduct";
            this.LabelNameProduct.Size = new System.Drawing.Size(104, 24);
            this.LabelNameProduct.TabIndex = 93;
            this.LabelNameProduct.Text = "Description";
            // 
            // DataGridViewPrice
            // 
            this.DataGridViewPrice.AllowUserToAddRows = false;
            this.DataGridViewPrice.AllowUserToDeleteRows = false;
            this.DataGridViewPrice.AllowUserToResizeColumns = false;
            this.DataGridViewPrice.AllowUserToResizeRows = false;
            this.DataGridViewPrice.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.DataGridViewPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPrice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.ID3,
            this.Price,
            this.Quantity,
            this.Edit2,
            this.Delete2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewPrice.Location = new System.Drawing.Point(305, 20);
            this.DataGridViewPrice.Name = "DataGridViewPrice";
            this.DataGridViewPrice.ReadOnly = true;
            this.DataGridViewPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPrice.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewPrice.RowHeadersVisible = false;
            this.DataGridViewPrice.RowHeadersWidth = 20;
            this.DataGridViewPrice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPrice.Size = new System.Drawing.Size(635, 546);
            this.DataGridViewPrice.TabIndex = 97;
            this.DataGridViewPrice.TabStop = false;
            this.DataGridViewPrice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPrice_CellContentClick);
            this.DataGridViewPrice.CurrentCellChanged += new System.EventHandler(this.DataGridViewPrice_CurrentCellChanged);
            this.DataGridViewPrice.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewPrice_DataBindingComplete);
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Enabled = false;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelID.Location = new System.Drawing.Point(88, 20);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(20, 24);
            this.LabelID.TabIndex = 92;
            this.LabelID.Text = "0";
            // 
            // LabelWarning2
            // 
            this.LabelWarning2.AutoSize = true;
            this.LabelWarning2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWarning2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelWarning2.Location = new System.Drawing.Point(104, 8);
            this.LabelWarning2.Name = "LabelWarning2";
            this.LabelWarning2.Size = new System.Drawing.Size(237, 15);
            this.LabelWarning2.TabIndex = 0;
            this.LabelWarning2.Text = "(No se pueden editar más de 50 registros)";
            this.LabelWarning2.Visible = false;
            // 
            // LabelSelection2
            // 
            this.LabelSelection2.AutoSize = true;
            this.LabelSelection2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSelection2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelSelection2.Location = new System.Drawing.Point(4, 8);
            this.LabelSelection2.Name = "LabelSelection2";
            this.LabelSelection2.Size = new System.Drawing.Size(95, 15);
            this.LabelSelection2.TabIndex = 0;
            this.LabelSelection2.Text = "Seleccionado: 1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.LabelWarning2);
            this.panel4.Controls.Add(this.ButtonDeletePrice);
            this.panel4.Controls.Add(this.LabelSelection2);
            this.panel4.Location = new System.Drawing.Point(305, 572);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 30);
            this.panel4.TabIndex = 98;
            // 
            // ButtonDeletePrice
            // 
            this.ButtonDeletePrice.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonDeletePrice.Enabled = false;
            this.ButtonDeletePrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDeletePrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeletePrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonDeletePrice.Location = new System.Drawing.Point(565, 0);
            this.ButtonDeletePrice.Name = "ButtonDeletePrice";
            this.ButtonDeletePrice.Size = new System.Drawing.Size(70, 30);
            this.ButtonDeletePrice.TabIndex = 15;
            this.ButtonDeletePrice.Text = "x";
            this.ButtonDeletePrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonDeletePrice.UseVisualStyleBackColor = false;
            this.ButtonDeletePrice.Click += new System.EventHandler(this.ButtonDeletePrice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 105;
            this.label1.Text = "a partir de";
            // 
            // NumericQuantity
            // 
            this.NumericQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NumericQuantity.Location = new System.Drawing.Point(132, 204);
            this.NumericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericQuantity.Name = "NumericQuantity";
            this.NumericQuantity.Size = new System.Drawing.Size(53, 29);
            this.NumericQuantity.TabIndex = 106;
            this.NumericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 107;
            this.label2.Text = "unidades";
            // 
            // ID2
            // 
            this.ID2.DataPropertyName = "ID_PRICE";
            this.ID2.Frozen = true;
            this.ID2.HeaderText = "ID";
            this.ID2.Name = "ID2";
            this.ID2.ReadOnly = true;
            this.ID2.Visible = false;
            // 
            // ID3
            // 
            this.ID3.DataPropertyName = "FK_ID_PRODUCT";
            this.ID3.Frozen = true;
            this.ID3.HeaderText = "ID_PRODUCT";
            this.ID3.Name = "ID3";
            this.ID3.ReadOnly = true;
            this.ID3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID3.Visible = false;
            this.ID3.Width = 178;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.Frozen = true;
            this.Price.HeaderText = "Precio";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.Width = 300;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.Frozen = true;
            this.Quantity.HeaderText = "a partir de:";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.Width = 300;
            // 
            // Edit2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Edit2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Edit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit2.Frozen = true;
            this.Edit2.HeaderText = "Editar";
            this.Edit2.Name = "Edit2";
            this.Edit2.ReadOnly = true;
            this.Edit2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit2.Text = "+";
            this.Edit2.UseColumnTextForButtonValue = true;
            this.Edit2.Width = 70;
            // 
            // Delete2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Delete2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delete2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete2.Frozen = true;
            this.Delete2.HeaderText = "Eliminar";
            this.Delete2.Name = "Delete2";
            this.Delete2.ReadOnly = true;
            this.Delete2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete2.Text = "x";
            this.Delete2.UseColumnTextForButtonValue = true;
            this.Delete2.Width = 70;
            // 
            // PricesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumericQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBoxBack);
            this.Controls.Add(this.PictureBoxLine);
            this.Controls.Add(this.LabelProduct);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonSavePrice);
            this.Controls.Add(this.ButtonCleanPrice);
            this.Controls.Add(this.LabelNameProduct);
            this.Controls.Add(this.DataGridViewPrice);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.panel4);
            this.Name = "PricesUC";
            this.Size = new System.Drawing.Size(960, 622);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPrice)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxBack;
        private System.Windows.Forms.PictureBox PictureBoxLine;
        private System.Windows.Forms.Label LabelProduct;
        private System.Windows.Forms.MaskedTextBox TextBoxPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonSavePrice;
        private System.Windows.Forms.Button ButtonCleanPrice;
        private System.Windows.Forms.Label LabelNameProduct;
        private System.Windows.Forms.DataGridView DataGridViewPrice;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelWarning2;
        private System.Windows.Forms.Label LabelSelection2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ButtonDeletePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewButtonColumn Edit2;
        private System.Windows.Forms.DataGridViewButtonColumn Delete2;
    }
}
