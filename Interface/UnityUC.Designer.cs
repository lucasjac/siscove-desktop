namespace Interface
{
    partial class UnityUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.NumericQuantity = new System.Windows.Forms.NumericUpDown();
            this.PanelWarning = new System.Windows.Forms.Panel();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.LabelSelection = new System.Windows.Forms.Label();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.DataGridViewUnity = new System.Windows.Forms.DataGridView();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUnity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).BeginInit();
            this.PanelWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUnity)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.NumericQuantity);
            this.Panel1.Controls.Add(this.PanelWarning);
            this.Panel1.Controls.Add(this.ButtonNew);
            this.Panel1.Controls.Add(this.ButtonSave);
            this.Panel1.Controls.Add(this.TextBoxSearch);
            this.Panel1.Controls.Add(this.DataGridViewUnity);
            this.Panel1.Controls.Add(this.LabelAddress);
            this.Panel1.Controls.Add(this.LabelName);
            this.Panel1.Controls.Add(this.TextBoxName);
            this.Panel1.Controls.Add(this.LabelID);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(960, 622);
            this.Panel1.TabIndex = 17;
            // 
            // NumericQuantity
            // 
            this.NumericQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NumericQuantity.Location = new System.Drawing.Point(20, 167);
            this.NumericQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericQuantity.Name = "NumericQuantity";
            this.NumericQuantity.Size = new System.Drawing.Size(120, 29);
            this.NumericQuantity.TabIndex = 26;
            // 
            // PanelWarning
            // 
            this.PanelWarning.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelWarning.Controls.Add(this.LabelWarning);
            this.PanelWarning.Controls.Add(this.ButtonDelete);
            this.PanelWarning.Controls.Add(this.ButtonEdit);
            this.PanelWarning.Controls.Add(this.LabelSelection);
            this.PanelWarning.Location = new System.Drawing.Point(305, 572);
            this.PanelWarning.Name = "PanelWarning";
            this.PanelWarning.Size = new System.Drawing.Size(635, 30);
            this.PanelWarning.TabIndex = 25;
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
            // ButtonNew
            // 
            this.ButtonNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNew.Image = global::Interface.Properties.Resources.Button6;
            this.ButtonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonNew.Location = new System.Drawing.Point(155, 563);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(125, 39);
            this.ButtonNew.TabIndex = 22;
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
            this.ButtonSave.Location = new System.Drawing.Point(20, 563);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(125, 39);
            this.ButtonSave.TabIndex = 21;
            this.ButtonSave.Text = "Guardar";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(305, 20);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(635, 29);
            this.TextBoxSearch.TabIndex = 23;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // DataGridViewUnity
            // 
            this.DataGridViewUnity.AllowUserToAddRows = false;
            this.DataGridViewUnity.AllowUserToDeleteRows = false;
            this.DataGridViewUnity.AllowUserToResizeColumns = false;
            this.DataGridViewUnity.AllowUserToResizeRows = false;
            this.DataGridViewUnity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewUnity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewUnity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUnity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameUnity,
            this.Quantity,
            this.State,
            this.Product,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewUnity.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewUnity.Location = new System.Drawing.Point(305, 63);
            this.DataGridViewUnity.Name = "DataGridViewUnity";
            this.DataGridViewUnity.ReadOnly = true;
            this.DataGridViewUnity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewUnity.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewUnity.RowHeadersVisible = false;
            this.DataGridViewUnity.RowHeadersWidth = 20;
            this.DataGridViewUnity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewUnity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUnity.Size = new System.Drawing.Size(635, 503);
            this.DataGridViewUnity.TabIndex = 24;
            this.DataGridViewUnity.TabStop = false;
            this.DataGridViewUnity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUnity_CellContentClick);
            this.DataGridViewUnity.CurrentCellChanged += new System.EventHandler(this.DataGridViewUnity_CurrentCellChanged);
            this.DataGridViewUnity.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewUnity_DataBindingComplete);
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.Location = new System.Drawing.Point(20, 140);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(84, 24);
            this.LabelAddress.TabIndex = 17;
            this.LabelAddress.Text = "Cantidad";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(20, 63);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(133, 24);
            this.LabelName.TabIndex = 18;
            this.LabelName.Text = "Denominación";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(20, 89);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(260, 29);
            this.TextBoxName.TabIndex = 20;
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
            this.LabelID.TabIndex = 19;
            this.LabelID.Text = "0";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID_UNITY";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NameUnity
            // 
            this.NameUnity.DataPropertyName = "name";
            this.NameUnity.Frozen = true;
            this.NameUnity.HeaderText = "Nombre";
            this.NameUnity.Name = "NameUnity";
            this.NameUnity.ReadOnly = true;
            this.NameUnity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameUnity.Width = 270;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.Frozen = true;
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.Width = 260;
            // 
            // State
            // 
            this.State.DataPropertyName = "state";
            this.State.Frozen = true;
            this.State.HeaderText = "Estado";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Visible = false;
            // 
            // Product
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            this.Product.DefaultCellStyle = dataGridViewCellStyle2;
            this.Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Product.Frozen = true;
            this.Product.HeaderText = "Productos";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Product.Text = "◕";
            this.Product.UseColumnTextForButtonValue = true;
            this.Product.Width = 70;
            // 
            // Edit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle4;
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
            // UnityUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Panel1);
            this.Name = "UnityUC";
            this.Size = new System.Drawing.Size(960, 622);
            this.Load += new System.EventHandler(this.UnityUC_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).EndInit();
            this.PanelWarning.ResumeLayout(false);
            this.PanelWarning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUnity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.NumericUpDown NumericQuantity;
        private System.Windows.Forms.Panel PanelWarning;
        private System.Windows.Forms.Label LabelWarning;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Label LabelSelection;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.DataGridView DataGridViewUnity;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUnity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewButtonColumn Product;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
