namespace Interface
{
    partial class ProductUnityUC
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
            this.LabelUnityProduct = new System.Windows.Forms.Label();
            this.LabelChange = new System.Windows.Forms.Label();
            this.ButtonSaveDual = new System.Windows.Forms.Button();
            this.ButtonCleanDual = new System.Windows.Forms.Button();
            this.TextBoxSearch2 = new System.Windows.Forms.TextBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.DataGridViewDual = new System.Windows.Forms.DataGridView();
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelWarning2 = new System.Windows.Forms.Label();
            this.LabelSelection2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ButtonDeleteTel = new System.Windows.Forms.Button();
            this.ComboBoxUnityProduct = new System.Windows.Forms.ComboBox();
            this.LabelIDUnityProduct = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionUnity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDual)).BeginInit();
            this.panel4.SuspendLayout();
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
            // LabelUnityProduct
            // 
            this.LabelUnityProduct.AutoSize = true;
            this.LabelUnityProduct.Enabled = false;
            this.LabelUnityProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUnityProduct.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelUnityProduct.Location = new System.Drawing.Point(114, 20);
            this.LabelUnityProduct.Name = "LabelUnityProduct";
            this.LabelUnityProduct.Size = new System.Drawing.Size(20, 24);
            this.LabelUnityProduct.TabIndex = 101;
            this.LabelUnityProduct.Text = "0";
            this.LabelUnityProduct.Visible = false;
            // 
            // LabelChange
            // 
            this.LabelChange.AutoSize = true;
            this.LabelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChange.Location = new System.Drawing.Point(20, 130);
            this.LabelChange.Name = "LabelChange";
            this.LabelChange.Size = new System.Drawing.Size(161, 24);
            this.LabelChange.TabIndex = 99;
            this.LabelChange.Text = "Unidad / Producto";
            // 
            // ButtonSaveDual
            // 
            this.ButtonSaveDual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSaveDual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveDual.Image = global::Interface.Properties.Resources.Button1;
            this.ButtonSaveDual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSaveDual.Location = new System.Drawing.Point(20, 563);
            this.ButtonSaveDual.Name = "ButtonSaveDual";
            this.ButtonSaveDual.Size = new System.Drawing.Size(125, 39);
            this.ButtonSaveDual.TabIndex = 94;
            this.ButtonSaveDual.Text = "Guardar";
            this.ButtonSaveDual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSaveDual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSaveDual.UseVisualStyleBackColor = true;
            this.ButtonSaveDual.Click += new System.EventHandler(this.ButtonSaveDual_Click);
            // 
            // ButtonCleanDual
            // 
            this.ButtonCleanDual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCleanDual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCleanDual.Image = global::Interface.Properties.Resources.Button6;
            this.ButtonCleanDual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCleanDual.Location = new System.Drawing.Point(155, 563);
            this.ButtonCleanDual.Name = "ButtonCleanDual";
            this.ButtonCleanDual.Size = new System.Drawing.Size(125, 39);
            this.ButtonCleanDual.TabIndex = 95;
            this.ButtonCleanDual.Text = "Nuevo";
            this.ButtonCleanDual.UseVisualStyleBackColor = true;
            this.ButtonCleanDual.Click += new System.EventHandler(this.ButtonCleanDual_Click);
            // 
            // TextBoxSearch2
            // 
            this.TextBoxSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch2.Location = new System.Drawing.Point(305, 20);
            this.TextBoxSearch2.Name = "TextBoxSearch2";
            this.TextBoxSearch2.Size = new System.Drawing.Size(635, 29);
            this.TextBoxSearch2.TabIndex = 96;
            this.TextBoxSearch2.TextChanged += new System.EventHandler(this.TextBoxSearch2_TextChanged);
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescription.Location = new System.Drawing.Point(20, 63);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(110, 24);
            this.LabelDescription.TabIndex = 93;
            this.LabelDescription.Text = "Descripción";
            // 
            // DataGridViewDual
            // 
            this.DataGridViewDual.AllowUserToAddRows = false;
            this.DataGridViewDual.AllowUserToDeleteRows = false;
            this.DataGridViewDual.AllowUserToResizeColumns = false;
            this.DataGridViewDual.AllowUserToResizeRows = false;
            this.DataGridViewDual.BackgroundColor = System.Drawing.Color.Lavender;
            this.DataGridViewDual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewDual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID2,
            this.ID3,
            this.Description,
            this.DescriptionProduct,
            this.DescriptionUnity,
            this.Edit2,
            this.Delete2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewDual.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewDual.Location = new System.Drawing.Point(305, 63);
            this.DataGridViewDual.Name = "DataGridViewDual";
            this.DataGridViewDual.ReadOnly = true;
            this.DataGridViewDual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDual.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewDual.RowHeadersVisible = false;
            this.DataGridViewDual.RowHeadersWidth = 20;
            this.DataGridViewDual.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewDual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDual.Size = new System.Drawing.Size(635, 503);
            this.DataGridViewDual.TabIndex = 97;
            this.DataGridViewDual.TabStop = false;
            this.DataGridViewDual.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDual_CellContentClick);
            this.DataGridViewDual.CurrentCellChanged += new System.EventHandler(this.DataGridViewDual_CurrentCellChanged);
            this.DataGridViewDual.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewDual_DataBindingComplete);
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Enabled = false;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelID.Location = new System.Drawing.Point(85, 20);
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
            this.panel4.Controls.Add(this.ButtonDeleteTel);
            this.panel4.Controls.Add(this.LabelSelection2);
            this.panel4.Location = new System.Drawing.Point(305, 572);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 30);
            this.panel4.TabIndex = 98;
            // 
            // ButtonDeleteTel
            // 
            this.ButtonDeleteTel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonDeleteTel.Enabled = false;
            this.ButtonDeleteTel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDeleteTel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteTel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonDeleteTel.Location = new System.Drawing.Point(565, 0);
            this.ButtonDeleteTel.Name = "ButtonDeleteTel";
            this.ButtonDeleteTel.Size = new System.Drawing.Size(70, 30);
            this.ButtonDeleteTel.TabIndex = 15;
            this.ButtonDeleteTel.Text = "x";
            this.ButtonDeleteTel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonDeleteTel.UseVisualStyleBackColor = false;
            this.ButtonDeleteTel.Click += new System.EventHandler(this.ButtonDeleteTel_Click);
            // 
            // ComboBoxUnityProduct
            // 
            this.ComboBoxUnityProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxUnityProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxUnityProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ComboBoxUnityProduct.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ComboBoxUnityProduct.FormattingEnabled = true;
            this.ComboBoxUnityProduct.Location = new System.Drawing.Point(20, 156);
            this.ComboBoxUnityProduct.Name = "ComboBoxUnityProduct";
            this.ComboBoxUnityProduct.Size = new System.Drawing.Size(260, 32);
            this.ComboBoxUnityProduct.TabIndex = 105;
            // 
            // LabelIDUnityProduct
            // 
            this.LabelIDUnityProduct.AutoSize = true;
            this.LabelIDUnityProduct.Enabled = false;
            this.LabelIDUnityProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIDUnityProduct.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelIDUnityProduct.Location = new System.Drawing.Point(143, 20);
            this.LabelIDUnityProduct.Name = "LabelIDUnityProduct";
            this.LabelIDUnityProduct.Size = new System.Drawing.Size(20, 24);
            this.LabelIDUnityProduct.TabIndex = 106;
            this.LabelIDUnityProduct.Text = "0";
            this.LabelIDUnityProduct.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID_PRODUCT_UNITY";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ID2
            // 
            this.ID2.DataPropertyName = "FK_ID_PRODUCT";
            this.ID2.Frozen = true;
            this.ID2.HeaderText = "ID_Product";
            this.ID2.Name = "ID2";
            this.ID2.ReadOnly = true;
            this.ID2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID2.Visible = false;
            this.ID2.Width = 178;
            // 
            // ID3
            // 
            this.ID3.DataPropertyName = "FK_ID_UNITY";
            this.ID3.Frozen = true;
            this.ID3.HeaderText = "ID_Unity";
            this.ID3.Name = "ID3";
            this.ID3.ReadOnly = true;
            this.ID3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID3.Visible = false;
            // 
            // Description
            // 
            this.Description.Frozen = true;
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Description.Width = 600;
            // 
            // DescriptionProduct
            // 
            this.DescriptionProduct.DataPropertyName = "description";
            this.DescriptionProduct.Frozen = true;
            this.DescriptionProduct.HeaderText = "DescriptionProduct";
            this.DescriptionProduct.Name = "DescriptionProduct";
            this.DescriptionProduct.ReadOnly = true;
            this.DescriptionProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DescriptionProduct.Visible = false;
            // 
            // DescriptionUnity
            // 
            this.DescriptionUnity.DataPropertyName = "name";
            this.DescriptionUnity.Frozen = true;
            this.DescriptionUnity.HeaderText = "DescriptionUnity";
            this.DescriptionUnity.Name = "DescriptionUnity";
            this.DescriptionUnity.ReadOnly = true;
            this.DescriptionUnity.Visible = false;
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
            // ProductUnityUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelIDUnityProduct);
            this.Controls.Add(this.ComboBoxUnityProduct);
            this.Controls.Add(this.PictureBoxBack);
            this.Controls.Add(this.PictureBoxLine);
            this.Controls.Add(this.LabelUnityProduct);
            this.Controls.Add(this.LabelChange);
            this.Controls.Add(this.ButtonSaveDual);
            this.Controls.Add(this.ButtonCleanDual);
            this.Controls.Add(this.TextBoxSearch2);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.DataGridViewDual);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.panel4);
            this.Name = "ProductUnityUC";
            this.Size = new System.Drawing.Size(960, 622);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDual)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxBack;
        private System.Windows.Forms.PictureBox PictureBoxLine;
        private System.Windows.Forms.Label LabelUnityProduct;
        private System.Windows.Forms.Label LabelChange;
        private System.Windows.Forms.Button ButtonSaveDual;
        private System.Windows.Forms.Button ButtonCleanDual;
        private System.Windows.Forms.TextBox TextBoxSearch2;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.DataGridView DataGridViewDual;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelWarning2;
        private System.Windows.Forms.Label LabelSelection2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ButtonDeleteTel;
        private System.Windows.Forms.ComboBox ComboBoxUnityProduct;
        private System.Windows.Forms.Label LabelIDUnityProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionUnity;
        private System.Windows.Forms.DataGridViewButtonColumn Edit2;
        private System.Windows.Forms.DataGridViewButtonColumn Delete2;
    }
}
