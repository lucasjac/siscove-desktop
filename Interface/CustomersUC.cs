using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Models;
using DataAccess;
using System.Threading;

namespace Interface
{
    public partial class CustomersUC : UserControl
    {
        CustomerControl newCustomerControl;
        Person newCustomers;
        private static CustomersUC instance;
        LoadingForm newloading = new LoadingForm();

        //INICIO DEL UC
        public CustomersUC()
        {
            InitializeComponent();
        }

        private void CustomersUC_Load(object sender, EventArgs e)
        {
            ToListCustomers(true);
        }

        public static CustomersUC instantiate
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomersUC();
                }
                return instance;
            }
        }

        //DATAGRIDVIEW
        //Listar
        private async void ToListCustomers(bool asinc)
        {
            switch(asinc)
            {
                case true:
                    Task<DataTable> newTask = new Task<DataTable>(getCustomers);
                    newTask.Start();
                    newloading.Show();
                    Clean(1);
                    TextBoxSearch.Clear();
                    DataGridViewCustomers.DataSource = await newTask;
                    newloading.Close();
                    break;
                default:
                    Clean(1);
                    TextBoxSearch.Clear();
                    DataGridViewCustomers.DataSource = getCustomers();
                    break;
            }
        }

        private DataTable getCustomers()
        {
            try
            {
                newCustomerControl = new CustomerControl();
                return newCustomerControl.List("AND type = 'Física'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //Aplicar estilo al cargar los datos del DataGridView
        public void DataGridViewCustomers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Style();
        }

        //Colorear filas
        private void Style()
        {
            for (int i = 0; i < DataGridViewCustomers.Rows.Count; i++)
            {
                //Colorear las filas pares
                if ((i % 2) == 0)
                {
                    DataGridViewCustomers.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                    DataGridViewCustomers.Rows[i].Cells[0].Style.BackColor = Color.PapayaWhip;
                    DataGridViewCustomers.Rows[i].Cells[1].Style.BackColor = Color.LightSteelBlue;
                    DataGridViewCustomers.Rows[i].Cells[2].Style.BackColor = Color.LightCoral;
                } else
                {
                    DataGridViewCustomers.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    DataGridViewCustomers.Rows[i].Cells[0].Style.BackColor = Color.Moccasin;
                    DataGridViewCustomers.Rows[i].Cells[1].Style.BackColor = Color.CornflowerBlue;
                    DataGridViewCustomers.Rows[i].Cells[2].Style.BackColor = Color.IndianRed;
                }
            }
        }

        //Habilitar DataGrid
        private void CustomersEnabled(Boolean enable)
        {
            DataGridViewCustomers.Enabled = enable;
            switch(enable)
            {
                case false:
                    for (int i = 0; i < DataGridViewCustomers.Rows.Count; i++)
                    {
                        DataGridViewCustomers.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    break;
                default:
                    Style();
                    break;
            }
        }

        //Modificar o eliminar
        private void DataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                newCustomers = new Person(Convert.ToInt32(DataGridViewCustomers.Rows[e.RowIndex].Cells["ID"].Value), DataGridViewCustomers.Rows[e.RowIndex].Cells["NameCustomer"].Value.ToString(),
                    DataGridViewCustomers.Rows[e.RowIndex].Cells["CI"].Value.ToString(), DataGridViewCustomers.Rows[e.RowIndex].Cells["Type"].Value.ToString(),
                    DataGridViewCustomers.Rows[e.RowIndex].Cells["State"].Value.ToString());
                String cell = DataGridViewCustomers.Columns[e.ColumnIndex].Name;

                //Modificar
                if (cell == "Edit")
                {
                    LabelID.Text = newCustomers.Id.ToString();
                    TextBoxName.Text = newCustomers.Name;
                    TextBoxCI.Text = newCustomers.Document;
                } //Eliminar
                else if(cell == "Delete" && MessageBox.Show("Desea eliminar a este cliente?", "ELIMINAR CLIENTES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        newCustomerControl.Delete(newCustomers.Id);
                        MessageBox.Show("Cliente eliminado con éxito!", "ELIMINAR CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ToListCustomers(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } //Agregar número de telefono
                else
                {
                    TelAdd(cell == "Tel", newCustomers.Id, newCustomers.Name);
                }
            }
        }

        //Contador de filas seleccionadas
        private void DataGridViewCustomers_CurrentCellChanged(object sender, EventArgs e)
        {
            int c = DataGridViewCustomers.SelectedRows.Count;
            bool condition = (c > 1) && (c < 51);
            switch (c)
            {
                case 1:
                    LabelSelection.Text = "Seleccionado: 1";
                    break;
                default:
                    LabelSelection.Text = "Seleccionados: " + Convert.ToString(c) + ".";
                    break;
            }
            ButtonsEnabled1(condition);
            if (c > 50)
            {
                LabelWarning.Visible = true;
            }
            else
            {
                LabelWarning.Visible = false;
            }
        }

        private void ButtonsEnabled1(bool b)
        {
            ButtonEdit.Enabled = ButtonDelete.Enabled = b;

            switch(b)
            {
                case false:
                    ButtonEdit.BackColor = SystemColors.ControlDarkDark;
                    ButtonEdit.ForeColor = SystemColors.ControlText;
                    ButtonDelete.BackColor = SystemColors.ControlDarkDark;
                    ButtonDelete.ForeColor = SystemColors.ControlText;
                    break;
                default:
                    ButtonEdit.BackColor = Color.CornflowerBlue;
                    ButtonEdit.ForeColor = Color.MidnightBlue;
                    ButtonDelete.BackColor = Color.IndianRed;
                    ButtonDelete.ForeColor = Color.Maroon;
                    break;
            }
        }

        //BÚSQUEDA
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            newCustomerControl = new CustomerControl();
            String ci_name;
            switch(CheckBoxName.Checked)
            {
                case true:
                    ci_name = "name";
                    break;
                default:
                    ci_name = "document";
                    break;
            }
            DataGridViewCustomers.DataSource = newCustomerControl.List("AND type = 'Física' AND " + ci_name + " LIKE '%" + TextBoxSearch.Text + "%'");
            Style();
        }

        //CHECKBOXES
        //Nombre
        private void CheckBoxName_CheckedChanged(object sender, EventArgs e)
        {
            switch(CheckBoxName.Checked)
            {
                case true:
                    CheckBoxCI.Checked = false;
                    break;
                default:
                    CheckBoxCI.Checked = true;
                    break;
            }
            TextBoxSearch_TextChanged(sender, e);
        }

        //Ci
        private void CheckBoxCI_CheckedChanged(object sender, EventArgs e)
        {
            switch(CheckBoxCI.Checked)
            {
                case true:
                    CheckBoxName.Checked = false;
                    break;
                default:
                    CheckBoxName.Checked = true;
                    break;
            }
            TextBoxSearch_TextChanged(sender, e);
        }

        //OTROS BOTONES
        //Guardar y Modificar
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (LabelID.Text != "-")
                    Validity();
                //Identificar si el ci viene con ruc
                string ci = TextBoxCI.Text;
                if (ci.Length <= 8)
                {
                    ci = ci.Remove(7, 1);
                }
                newCustomers = new Person(TextBoxName.Text, ci, "Física", "In Use");
                newCustomerControl = new CustomerControl();
                String message;
                switch(LabelID.Text)
                {
                    case "0": //Guardar
                        newCustomerControl.Save(newCustomers);
                        message = "Cliente registrado con éxito!";
                        break;
                    case "-": //Modificar varios a la vez
                        for (int i = 0; i < DataGridViewCustomers.SelectedRows.Count; i++)
                        {
                                newCustomers = new Person(Convert.ToInt16(DataGridViewCustomers.SelectedRows[i].Cells["ID"].Value), DataGridViewCustomers.SelectedRows[i].Cells["NameCustomer"].Value.ToString(),
                                    DataGridViewCustomers.SelectedRows[i].Cells["Document"].Value.ToString(), DataGridViewCustomers.SelectedRows[i].Cells["Type"].Value.ToString(),
                                    DataGridViewCustomers.SelectedRows[i].Cells["State"].Value.ToString());
                                newCustomerControl = new CustomerControl();
                                if (TextBoxName.Text != "")
                                    newCustomers.Name = TextBoxName.Text;
                                if (TextBoxCI.Text != " ,   ,")
                                    newCustomers.Document = TextBoxCI.Text;
                                newCustomerControl.Modify(newCustomers);
                        }
                        message = "Registros modificados con éxito!";
                        break;
                    default: //Modificar sólo uno
                        newCustomers.Id = Convert.ToInt32(LabelID.Text);
                        newCustomerControl.Modify(newCustomers);
                        message = "Registro modificado con éxito!";
                        break;
                }
                MessageBox.Show(message, "REGISTRO DE CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToListCustomers(false);
                for (int i = 0; i < DataGridViewCustomers.Rows.Count; i++)
                {
                    if (Convert.ToString(DataGridViewCustomers.Rows[i].Cells["NameCustomer"].Value) == newCustomers.Name)
                    {
                        TelAdd(message == "Cliente registrado con éxito!", Convert.ToInt32(DataGridViewCustomers.Rows[i].Cells["ID"].Value), newCustomers.Name);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Agregar número de teléfono
        private void TelAdd(Boolean b, int id, String name)
        {
            if(b == true)
            {
                if (MessageBox.Show("Desea agregar un número a este cliente?", "NÚMERO DE TELEFONO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TelUC newTelUC = new TelUC();
                    Panel1.Controls.Remove(this);
                    Panel1.Controls.Add(newTelUC);
                    newTelUC.Dock = DockStyle.Fill;
                    newTelUC.BringToFront();
                    newTelUC.establish_id(id, name, "0");
                }
            }
        }

        //Limpiar todo
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            int condition = 2;
            if(DataGridViewCustomers.Enabled == false)
            {
                condition = 1;
            }
            Clean(condition);
        }

        //Eliminar varios registros a la vez
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar a estos clientes?", "ELIMINAR CLIENTES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < DataGridViewCustomers.SelectedRows.Count; i++)
                    {
                        newCustomerControl = new CustomerControl();
                        newCustomerControl.Delete(Convert.ToInt32(DataGridViewCustomers.SelectedRows[i].Cells["ID"].Value));
                    }
                    MessageBox.Show("Clientes eliminados con éxito!", "ELIMINAR CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ToListCustomers(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Editar varios registros a la vez
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            Clean(0);
            String[] value_dg = { DataGridViewCustomers.SelectedRows[0].Cells["NameCustomer"].Value.ToString(), DataGridViewCustomers.SelectedRows[0].Cells["Document"].Value.ToString()};
            String[] name_dg = { "NameCustomer", "Document" };
            int[] conditional = { 0, 0 };
            for(int i = 1; i < DataGridViewCustomers.SelectedRows.Count; i++)
            {
                for(int c = 0; c < 2; c++)
                {
                    if (DataGridViewCustomers.SelectedRows[i].Cells[name_dg[c]].Value.ToString() != value_dg[c])
                        conditional[c] = 1;
                    value_dg[c] = DataGridViewCustomers.SelectedRows[i].Cells[name_dg[c]].Value.ToString();
                }
            }
            if (conditional[0] == 0)
                TextBoxName.Text = value_dg[0];
            if (conditional[1] == 0)
                TextBoxCI.Text = value_dg[1];
            LabelID.Text = "-";
        }

        //OTROS MÉTODOS
        //Vaciar cajas de texto, comboboxes, etc.
        private void Clean(int condition = 2)
        {
            LabelID.Text = "0";
            TextBoxName.Clear();
            TextBoxCI.Clear();
            if (condition == 0)
            {
                CustomersEnabled(false);
            } else if(condition == 1)
            {
                CustomersEnabled(true);
            }
        }

        //Validar nombre
        private void Validity()
        {
            if (TextBoxName.Text.Trim().Length == 0)
            {
                throw new Exception("El nombre no fue establecido!");
            }
        }
    }
}