namespace Interface
{
    partial class DistributorsUC
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
            this.Panel3 = new System.Windows.Forms.Panel();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.LabelSelection = new System.Windows.Forms.Label();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.DataGridViewDistributors = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDistributor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDistributors)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.ButtonNew);
            this.Panel1.Controls.Add(this.ButtonSave);
            this.Panel1.Controls.Add(this.LabelName);
            this.Panel1.Controls.Add(this.TextBoxName);
            this.Panel1.Controls.Add(this.LabelID);
            this.Panel1.Controls.Add(this.TextBoxSearch);
            this.Panel1.Controls.Add(this.DataGridViewDistributors);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(960, 622);
            this.Panel1.TabIndex = 16;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Panel3.Controls.Add(this.LabelWarning);
            this.Panel3.Controls.Add(this.ButtonDelete);
            this.Panel3.Controls.Add(this.ButtonEdit);
            this.Panel3.Controls.Add(this.LabelSelection);
            this.Panel3.Location = new System.Drawing.Point(305, 572);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(635, 30);
            this.Panel3.TabIndex = 25;
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
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(20, 63);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(79, 24);
            this.LabelName.TabIndex = 17;
            this.LabelName.Text = "Nombre";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(20, 89);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(260, 29);
            this.TextBoxName.TabIndex = 19;
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
            this.LabelID.TabIndex = 18;
            this.LabelID.Text = "0";
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
            // DataGridViewDistributors
            // 
            this.DataGridViewDistributors.AllowUserToAddRows = false;
            this.DataGridViewDistributors.AllowUserToDeleteRows = false;
            this.DataGridViewDistributors.AllowUserToResizeColumns = false;
            this.DataGridViewDistributors.AllowUserToResizeRows = false;
            this.DataGridViewDistributors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDistributors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewDistributors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDistributors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameDistributor,
            this.Document,
            this.Type,
            this.State,
            this.Tel,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewDistributors.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewDistributors.Location = new System.Drawing.Point(305, 63);
            this.DataGridViewDistributors.Name = "DataGridViewDistributors";
            this.DataGridViewDistributors.ReadOnly = true;
            this.DataGridViewDistributors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDistributors.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewDistributors.RowHeadersVisible = false;
            this.DataGridViewDistributors.RowHeadersWidth = 20;
            this.DataGridViewDistributors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewDistributors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDistributors.Size = new System.Drawing.Size(635, 503);
            this.DataGridViewDistributors.TabIndex = 24;
            this.DataGridViewDistributors.TabStop = false;
            this.DataGridViewDistributors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDistributors_CellContentClick);
            this.DataGridViewDistributors.CurrentCellChanged += new System.EventHandler(this.DataGridViewDistributors_CurrentCellChanged);
            this.DataGridViewDistributors.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewDistributors_DataBindingComplete);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID_PERSON";
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NameDistributor
            // 
            this.NameDistributor.DataPropertyName = "name";
            this.NameDistributor.Frozen = true;
            this.NameDistributor.HeaderText = "Nombre";
            this.NameDistributor.Name = "NameDistributor";
            this.NameDistributor.ReadOnly = true;
            this.NameDistributor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameDistributor.Width = 530;
            // 
            // Document
            // 
            this.Document.DataPropertyName = "document";
            this.Document.Frozen = true;
            this.Document.HeaderText = "CI";
            this.Document.Name = "Document";
            this.Document.ReadOnly = true;
            this.Document.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Document.Visible = false;
            this.Document.Width = 178;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "type";
            this.Type.Frozen = true;
            this.Type.HeaderText = "Tipo";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Visible = false;
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
            // Tel
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            this.Tel.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tel.Frozen = true;
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Text = "📞";
            this.Tel.UseColumnTextForButtonValue = true;
            this.Tel.Width = 70;
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
            // DistributorsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Panel1);
            this.Name = "DistributorsUC";
            this.Size = new System.Drawing.Size(960, 622);
            this.Load += new System.EventHandler(this.CustomersUC_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDistributors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Label LabelWarning;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Label LabelSelection;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.DataGridView DataGridViewDistributors;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDistributor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Document;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewButtonColumn Tel;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
