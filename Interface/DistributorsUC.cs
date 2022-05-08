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

namespace Interface
{
    public partial class DistributorsUC : UserControl
    {
        DistributorControl newDistributorControl;
        Person newDistributors;
        private static DistributorsUC instance;
        LoadingForm newloading = new LoadingForm();

        //INICIO DEL UC
        public DistributorsUC()
        {
            InitializeComponent();
        }

        private void CustomersUC_Load(object sender, EventArgs e)
        {
            ToListDistributors(true);
        }

        public static DistributorsUC instantiate
        {
            get
            {
                if (instance == null)
                {
                    instance = new DistributorsUC();
                }
                return instance;
            }
        }

        //DATAGRIDVIEW
        //Listar
        private async void ToListDistributors(bool asinc)
        {
            switch (asinc)
            {
                case true:
                    Task<DataTable> newTask = new Task<DataTable>(getDistributors);
                    newTask.Start();
                    newloading.Show();
                    Clean(1);
                    TextBoxSearch.Clear();
                    DataGridViewDistributors.DataSource = await newTask;
                    newloading.Close();
                    break;
                default:
                    Clean(1);
                    TextBoxSearch.Clear();
                    DataGridViewDistributors.DataSource = getDistributors();
                    break;
            }
        }

        private DataTable getDistributors()
        {
            try
            {
                newDistributorControl = new DistributorControl();
                return newDistributorControl.List("AND type = 'Jurídica'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //Aplicar estilo al cargar los datos del DataGridView
        public void DataGridViewDistributors_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Style();
        }

        //Colorear filas
        private void Style()
        {
            for (int i = 0; i < DataGridViewDistributors.Rows.Count; i++)
            {
                //Colorear las filas pares
                if ((i % 2) == 0)
                {
                    DataGridViewDistributors.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                    DataGridViewDistributors.Rows[i].Cells[0].Style.BackColor = Color.PapayaWhip;
                    DataGridViewDistributors.Rows[i].Cells[1].Style.BackColor = Color.LightSteelBlue;
                    DataGridViewDistributors.Rows[i].Cells[2].Style.BackColor = Color.LightCoral;
                }
                else
                {
                    DataGridViewDistributors.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    DataGridViewDistributors.Rows[i].Cells[0].Style.BackColor = Color.Moccasin;
                    DataGridViewDistributors.Rows[i].Cells[1].Style.BackColor = Color.CornflowerBlue;
                    DataGridViewDistributors.Rows[i].Cells[2].Style.BackColor = Color.IndianRed;
                }
            }
        }

        //Habilitar DataGrid
        private void DistributorsEnabled(Boolean enable)
        {
            DataGridViewDistributors.Enabled = enable;
            switch (enable)
            {
                case false:
                    for (int i = 0; i < DataGridViewDistributors.Rows.Count; i++)
                    {
                        DataGridViewDistributors.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    break;
                default:
                    Style();
                    break;
            }
        }

        //Modificar o eliminar
        private void DataGridViewDistributors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                newDistributors = new Person(Convert.ToInt32(DataGridViewDistributors.Rows[e.RowIndex].Cells["ID"].Value), DataGridViewDistributors.Rows[e.RowIndex].Cells["NameDistributor"].Value.ToString(),
                    DataGridViewDistributors.Rows[e.RowIndex].Cells["Document"].Value.ToString(), DataGridViewDistributors.Rows[e.RowIndex].Cells["Type"].Value.ToString(),
                    DataGridViewDistributors.Rows[e.RowIndex].Cells["State"].Value.ToString());
                String cell = DataGridViewDistributors.Columns[e.ColumnIndex].Name;

                //Modificar
                if (cell == "Edit")
                {
                    LabelID.Text = newDistributors.Id.ToString();
                    TextBoxName.Text = newDistributors.Name;
                } //Eliminar
                else if (cell == "Delete" && MessageBox.Show("Desea eliminar a este distribuidor?", "ELIMINAR DISTRIBUIDORES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        newDistributorControl.Delete(newDistributors.Id);
                        MessageBox.Show("Distribuidos eliminado con éxito!", "ELIMINAR DISTRIBUIDORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ToListDistributors(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } //Agregar número de telefono
                else
                {
                    TelAdd(cell == "Tel", newDistributors.Id, newDistributors.Name);
                }
            }
        }

        //Contador de filas seleccionadas
        private void DataGridViewDistributors_CurrentCellChanged(object sender, EventArgs e)
        {
            int c = DataGridViewDistributors.SelectedRows.Count;
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

            switch (b)
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
            newDistributorControl = new DistributorControl();
            DataGridViewDistributors.DataSource = newDistributorControl.List("AND type = 'Jurídica' AND name LIKE '%" + TextBoxSearch.Text + "%'");
            Style();
        }

        //OTROS BOTONES
        //Guardar y Modificar
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (LabelID.Text != "-")
                    Validity();
                newDistributors = new Person(TextBoxName.Text, "", "Jurídica", "In Use");
                newDistributorControl = new DistributorControl();
                String message;
                switch (LabelID.Text)
                {
                    case "0": //Guardar
                        newDistributorControl.Save(newDistributors);
                        message = "Distribuidor registrado con éxito!";
                        break;
                    case "-": //Modificar varios a la vez
                        for (int i = 0; i < DataGridViewDistributors.SelectedRows.Count; i++)
                        {
                            newDistributors = new Person(Convert.ToInt16(DataGridViewDistributors.SelectedRows[i].Cells["ID"].Value), DataGridViewDistributors.SelectedRows[i].Cells["NameDistributor"].Value.ToString(),
                                DataGridViewDistributors.SelectedRows[i].Cells["Document"].Value.ToString(), DataGridViewDistributors.SelectedRows[i].Cells["Type"].Value.ToString(),
                                DataGridViewDistributors.SelectedRows[i].Cells["State"].Value.ToString());
                            newDistributorControl = new DistributorControl();
                            if (TextBoxName.Text != "")
                                newDistributors.Name = TextBoxName.Text;
                            newDistributorControl.Modify(newDistributors);
                        }
                        message = "Registros modificados con éxito!";
                        break;
                    default: //Modificar sólo uno
                        newDistributors.Id = Convert.ToInt32(LabelID.Text);
                        newDistributorControl.Modify(newDistributors);
                        message = "Registro modificado con éxito!";
                        break;
                }
                MessageBox.Show(message, "REGISTRO DE DISTRIBUIDORES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToListDistributors(false);
                for (int i = 0; i < DataGridViewDistributors.Rows.Count; i++)
                {
                    if (Convert.ToString(DataGridViewDistributors.Rows[i].Cells["NameDistributor"].Value) == newDistributors.Name)
                    {
                        TelAdd(message == "Distribuidor registrado con éxito!", Convert.ToInt32(DataGridViewDistributors.Rows[i].Cells["ID"].Value), newDistributors.Name);
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
            if (b == true)
            {
                if (MessageBox.Show("Desea agregar un número a este distribuidor?", "NÚMERO DE TELEFONO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TelUC newTelUC = new TelUC();
                    Panel1.Controls.Remove(this);
                    Panel1.Controls.Add(newTelUC);
                    newTelUC.Dock = DockStyle.Fill;
                    newTelUC.BringToFront();
                    newTelUC.establish_id(id, name, "1");
                }
            }
        }

        //Limpiar todo
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            int condition = 2;
            if (DataGridViewDistributors.Enabled == false)
            {
                condition = 1;
            }
            Clean(condition);
        }

        //Eliminar varios registros a la vez
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar a estos distribuidores?", "ELIMINAR DISTRIBUIDORES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < DataGridViewDistributors.SelectedRows.Count; i++)
                    {
                        newDistributorControl = new DistributorControl();
                        newDistributorControl.Delete(Convert.ToInt32(DataGridViewDistributors.SelectedRows[i].Cells["ID"].Value));
                    }
                    MessageBox.Show("Distribuidores eliminados con éxito!", "ELIMINAR DISTRIBUIDORES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ToListDistributors(false);
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
            String[] value_dg = { DataGridViewDistributors.SelectedRows[0].Cells["NameDistributor"].Value.ToString()};
            String[] name_dg = { "NameDistributor" };
            int[] conditional = { 0 };
            for (int i = 1; i < DataGridViewDistributors.SelectedRows.Count; i++)
            {
                for (int c = 0; c < 1; c++)
                {
                    if (DataGridViewDistributors.SelectedRows[i].Cells[name_dg[c]].Value.ToString() != value_dg[c])
                        conditional[c] = 1;
                    value_dg[c] = DataGridViewDistributors.SelectedRows[i].Cells[name_dg[c]].Value.ToString();
                }
            }
            if (conditional[0] == 0)
                TextBoxName.Text = value_dg[0];
            LabelID.Text = "-";
        }

        //OTROS MÉTODOS
        //Vaciar cajas de texto, comboboxes, etc.
        private void Clean(int condition = 2)
        {
            LabelID.Text = "0";
            TextBoxName.Clear();
            if (condition == 0)
            {
                DistributorsEnabled(false);
            }
            else if (condition == 1)
            {
                DistributorsEnabled(true);
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