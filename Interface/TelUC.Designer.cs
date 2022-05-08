namespace Interface
{
    partial class TelUC
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
            this.LabelCustomer = new System.Windows.Forms.Label();
            this.TextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonSaveTel = new System.Windows.Forms.Button();
            this.ButtonCleanTel = new System.Windows.Forms.Button();
            this.TextBoxSearch2 = new System.Windows.Forms.TextBox();
            this.LabelNameCustomer = new System.Windows.Forms.Label();
            this.DataGridViewTel = new System.Windows.Forms.DataGridView();
            this.LabelIDTel = new System.Windows.Forms.Label();
            this.LabelWarning2 = new System.Windows.Forms.Label();
            this.LabelSelection2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ButtonDeleteTel = new System.Windows.Forms.Button();
            this.Label_cust_dist = new System.Windows.Forms.Label();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTel)).BeginInit();
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
            // LabelCustomer
            // 
            this.LabelCustomer.AutoSize = true;
            this.LabelCustomer.Enabled = false;
            this.LabelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelCustomer.Location = new System.Drawing.Point(117, 20);
            this.LabelCustomer.Name = "LabelCustomer";
            this.LabelCustomer.Size = new System.Drawing.Size(20, 24);
            this.LabelCustomer.TabIndex = 101;
            this.LabelCustomer.Text = "0";
            this.LabelCustomer.Visible = false;
            // 
            // TextBoxTel
            // 
            this.TextBoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TextBoxTel.Location = new System.Drawing.Point(20, 156);
            this.TextBoxTel.Mask = "(9999)00000000";
            this.TextBoxTel.Name = "TextBoxTel";
            this.TextBoxTel.Size = new System.Drawing.Size(260, 29);
            this.TextBoxTel.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 24);
            this.label6.TabIndex = 99;
            this.label6.Text = "Teléfono / Celular";
            // 
            // ButtonSaveTel
            // 
            this.ButtonSaveTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSaveTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveTel.Image = global::Interface.Properties.Resources.Button1;
            this.ButtonSaveTel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSaveTel.Location = new System.Drawing.Point(20, 563);
            this.ButtonSaveTel.Name = "ButtonSaveTel";
            this.ButtonSaveTel.Size = new System.Drawing.Size(125, 39);
            this.ButtonSaveTel.TabIndex = 94;
            this.ButtonSaveTel.Text = "Guardar";
            this.ButtonSaveTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSaveTel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSaveTel.UseVisualStyleBackColor = true;
            this.ButtonSaveTel.Click += new System.EventHandler(this.ButtonSaveTel_Click);
            // 
            // ButtonCleanTel
            // 
            this.ButtonCleanTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCleanTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCleanTel.Image = global::Interface.Properties.Resources.Button6;
            this.ButtonCleanTel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCleanTel.Location = new System.Drawing.Point(155, 563);
            this.ButtonCleanTel.Name = "ButtonCleanTel";
            this.ButtonCleanTel.Size = new System.Drawing.Size(125, 39);
            this.ButtonCleanTel.TabIndex = 95;
            this.ButtonCleanTel.Text = "Nuevo";
            this.ButtonCleanTel.UseVisualStyleBackColor = true;
            this.ButtonCleanTel.Click += new System.EventHandler(this.ButtonCleanTel_Click);
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
            // LabelNameCustomer
            // 
            this.LabelNameCustomer.AutoSize = true;
            this.LabelNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNameCustomer.Location = new System.Drawing.Point(20, 63);
            this.LabelNameCustomer.Name = "LabelNameCustomer";
            this.LabelNameCustomer.Size = new System.Drawing.Size(167, 24);
            this.LabelNameCustomer.TabIndex = 93;
            this.LabelNameCustomer.Text = "Nombre y Apellido";
            // 
            // DataGridViewTel
            // 
            this.DataGridViewTel.AllowUserToAddRows = false;
            this.DataGridViewTel.AllowUserToDeleteRows = false;
            this.DataGridViewTel.AllowUserToResizeColumns = false;
            this.DataGridViewTel.AllowUserToResizeRows = false;
            this.DataGridViewTel.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.DataGridViewTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewTel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.ID3,
            this.Info,
            this.Edit2,
            this.Delete2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTel.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewTel.Location = new System.Drawing.Point(305, 63);
            this.DataGridViewTel.Name = "DataGridViewTel";
            this.DataGridViewTel.ReadOnly = true;
            this.DataGridViewTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTel.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewTel.RowHeadersVisible = false;
            this.DataGridViewTel.RowHeadersWidth = 20;
            this.DataGridViewTel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewTel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTel.Size = new System.Drawing.Size(635, 503);
            this.DataGridViewTel.TabIndex = 97;
            this.DataGridViewTel.TabStop = false;
            this.DataGridViewTel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTel_CellContentClick);
            this.DataGridViewTel.CurrentCellChanged += new System.EventHandler(this.DataGridViewTel_CurrentCellChanged);
            this.DataGridViewTel.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewTel_DataBindingComplete);
            // 
            // LabelIDTel
            // 
            this.LabelIDTel.AutoSize = true;
            this.LabelIDTel.Enabled = false;
            this.LabelIDTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIDTel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelIDTel.Location = new System.Drawing.Point(88, 20);
            this.LabelIDTel.Name = "LabelIDTel";
            this.LabelIDTel.Size = new System.Drawing.Size(20, 24);
            this.LabelIDTel.TabIndex = 92;
            this.LabelIDTel.Text = "0";
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
            // Label_cust_dist
            // 
            this.Label_cust_dist.AutoSize = true;
            this.Label_cust_dist.Enabled = false;
            this.Label_cust_dist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_cust_dist.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label_cust_dist.Location = new System.Drawing.Point(146, 20);
            this.Label_cust_dist.Name = "Label_cust_dist";
            this.Label_cust_dist.Size = new System.Drawing.Size(20, 24);
            this.Label_cust_dist.TabIndex = 104;
            this.Label_cust_dist.Text = "0";
            this.Label_cust_dist.Visible = false;
            // 
            // ID2
            // 
            this.ID2.DataPropertyName = "ID_PERSON_INFO";
            this.ID2.Frozen = true;
            this.ID2.HeaderText = "ID";
            this.ID2.Name = "ID2";
            this.ID2.ReadOnly = true;
            this.ID2.Visible = false;
            // 
            // ID3
            // 
            this.ID3.DataPropertyName = "FK_ID_PERSON";
            this.ID3.Frozen = true;
            this.ID3.HeaderText = "ID_CUST_DIST";
            this.ID3.Name = "ID3";
            this.ID3.ReadOnly = true;
            this.ID3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID3.Visible = false;
            this.ID3.Width = 178;
            // 
            // Info
            // 
            this.Info.DataPropertyName = "info";
            this.Info.Frozen = true;
            this.Info.HeaderText = "";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Info.Width = 600;
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
            // TelUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_cust_dist);
            this.Controls.Add(this.PictureBoxBack);
            this.Controls.Add(this.PictureBoxLine);
            this.Controls.Add(this.LabelCustomer);
            this.Controls.Add(this.TextBoxTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonSaveTel);
            this.Controls.Add(this.ButtonCleanTel);
            this.Controls.Add(this.TextBoxSearch2);
            this.Controls.Add(this.LabelNameCustomer);
            this.Controls.Add(this.DataGridViewTel);
            this.Controls.Add(this.LabelIDTel);
            this.Controls.Add(this.panel4);
            this.Name = "TelUC";
            this.Size = new System.Drawing.Size(960, 622);
            this.Load += new System.EventHandler(this.TelUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTel)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxBack;
        private System.Windows.Forms.PictureBox PictureBoxLine;
        private System.Windows.Forms.Label LabelCustomer;
        private System.Windows.Forms.MaskedTextBox TextBoxTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonSaveTel;
        private System.Windows.Forms.Button ButtonCleanTel;
        private System.Windows.Forms.TextBox TextBoxSearch2;
        private System.Windows.Forms.Label LabelNameCustomer;
        private System.Windows.Forms.DataGridView DataGridViewTel;
        private System.Windows.Forms.Label LabelIDTel;
        private System.Windows.Forms.Label LabelWarning2;
        private System.Windows.Forms.Label LabelSelection2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ButtonDeleteTel;
        private System.Windows.Forms.Label Label_cust_dist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewButtonColumn Edit2;
        private System.Windows.Forms.DataGridViewButtonColumn Delete2;
    }
}
