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
    public partial class UnityUC : UserControl
    {
        UnityControl newUnityControl;
        Unity newUnity;
        private static UnityUC instance;
        LoadingForm newloading = new LoadingForm();

        //INICIO DEL UC
        public UnityUC()
        {
            InitializeComponent();
        }

        private void UnityUC_Load(object sender, EventArgs e)
        {
            ToListUnity(true);
        }

        public static UnityUC instantiate
        {
            get
            {
                if (instance == null)
                {
                    instance = new UnityUC();
                }
                return instance;
            }
        }

        //DATAGRIDVIEW
        //Listar
        private async void ToListUnity(bool asinc)
        {
            switch (asinc)
            {
                case true:
                    Task<DataTable> newTask = new Task<DataTable>(getUnity);
                    newTask.Start();
                    newloading.Show();
                    Clean(1);
                    TextBoxSearch.Clear();
                    DataGridViewUnity.DataSource = await newTask;
                    newloading.Close();
                    break;
                default:
                    Clean(1);
                    TextBoxSearch.Clear();
                    DataGridViewUnity.DataSource = getUnity();
                    break;
            }
        }

        private DataTable getUnity()
        {
            try
            {
                newUnityControl = new UnityControl();
                return newUnityControl.List("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //Aplicar estilo al cargar los datos del DataGridView
        public void DataGridViewUnity_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Style();
        }

        //Colorear filas
        private void Style()
        {
            for (int i = 0; i < DataGridViewUnity.Rows.Count; i++)
            {
                //Colorear las filas pares
                if ((i % 2) == 0)
                {
                    DataGridViewUnity.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                    DataGridViewUnity.Rows[i].Cells[0].Style.BackColor = Color.LightCyan;
                    DataGridViewUnity.Rows[i].Cells[1].Style.BackColor = Color.LightSteelBlue;
                    DataGridViewUnity.Rows[i].Cells[2].Style.BackColor = Color.LightCoral;
                }
                else
                {
                    DataGridViewUnity.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    DataGridViewUnity.Rows[i].Cells[0].Style.BackColor = Color.LightCyan;
                    DataGridViewUnity.Rows[i].Cells[1].Style.BackColor = Color.CornflowerBlue;
                    DataGridViewUnity.Rows[i].Cells[2].Style.BackColor = Color.IndianRed;
                }
            }
        }

        //Habilitar DataGrid
        private void UnityEnabled(Boolean enable)
        {
            DataGridViewUnity.Enabled = enable;
            switch (enable)
            {
                case false:
                    for (int i = 0; i < DataGridViewUnity.Rows.Count; i++)
                    {
                        DataGridViewUnity.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    break;
                default:
                    Style();
                    break;
            }
        }

        //Modificar o eliminar
        private void DataGridViewUnity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                newUnity = new Unity(Convert.ToInt32(DataGridViewUnity.Rows[e.RowIndex].Cells["ID"].Value), DataGridViewUnity.Rows[e.RowIndex].Cells["NameUnity"].Value.ToString(),
                    Convert.ToInt32(DataGridViewUnity.Rows[e.RowIndex].Cells["Quantity"].Value), DataGridViewUnity.Rows[e.RowIndex].Cells["State"].Value.ToString());
                String cell = DataGridViewUnity.Columns[e.ColumnIndex].Name;

                //Modificar
                if (cell == "Edit")
                {
                    LabelID.Text = newUnity.Id.ToString();
                    TextBoxName.Text = newUnity.Name;
                    NumericQuantity.Value = newUnity.Quantity;
                } //Eliminar
                else if (cell == "Delete" && MessageBox.Show("Desea eliminar a esta unidad?", "ELIMINAR UNIDADES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        newUnityControl.Delete(newUnity.Id);
                        MessageBox.Show("Unidad eliminada con éxito!", "ELIMINAR UNIDADES", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ToListUnity(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } //Agregar unidades
                else
                {
                    ProductAdd(cell == "Product", newUnity.Id, newUnity.Name);
                }
            }
        }

        //Contador de filas seleccionadas
        private void DataGridViewUnity_CurrentCellChanged(object sender, EventArgs e)
        {
            int c = DataGridViewUnity.SelectedRows.Count;
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
            newUnityControl = new UnityControl();
            DataGridViewUnity.DataSource = newUnityControl.List("AND name LIKE '%" + TextBoxSearch.Text + "%'");
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
                newUnity = new Unity(TextBoxName.Text, Convert.ToInt32(NumericQuantity.Value), "In Use");
                newUnityControl = new UnityControl();
                String message;
                switch (LabelID.Text)
                {
                    case "0": //Guardar
                        newUnityControl.Save(newUnity);
                        message = "Unidad registrada con éxito!";
                        break;
                    case "-": //Modificar varios a la vez
                        for (int i = 0; i < DataGridViewUnity.SelectedRows.Count; i++)
                        {
                            newUnity = new Unity(Convert.ToInt16(DataGridViewUnity.SelectedRows[i].Cells["ID"].Value), DataGridViewUnity.SelectedRows[i].Cells["NameUnity"].Value.ToString(),
                                Convert.ToInt16(DataGridViewUnity.SelectedRows[i].Cells["Quantity"].Value), DataGridViewUnity.SelectedRows[i].Cells["State"].Value.ToString());
                            newUnityControl = new UnityControl();
                            if (TextBoxName.Text != "")
                                newUnity.Name = TextBoxName.Text;
                            if (NumericQuantity.Value != 0)
                                newUnity.Quantity = Convert.ToInt16(NumericQuantity.Value);
                            newUnityControl.Modify(newUnity);
                        }
                        message = "Registros modificados con éxito!";
                        break;
                    default: //Modificar sólo uno
                        newUnity.Id = Convert.ToInt16(LabelID.Text);
                        newUnityControl.Modify(newUnity);
                        message = "Registro modificado con éxito!";
                        break;
                }
                MessageBox.Show(message, "REGISTRO DE UNIDADES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToListUnity(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Agregar producto
        private void ProductAdd(Boolean b, int id, String name)
        {
            if (b == true)
            {
                if (MessageBox.Show("Desea asociar productos a esta unidad?", "PRODUCTOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProductUnityUC newProductUnityUC = new ProductUnityUC();
                    Panel1.Controls.Remove(this);
                    Panel1.Controls.Add(newProductUnityUC);
                    newProductUnityUC.Dock = DockStyle.Fill;
                    newProductUnityUC.BringToFront();
                    newProductUnityUC.establish_id(id, name, "1");
                }
            }
        }

        //Limpiar todo
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            int condition = 2;
            if (DataGridViewUnity.Enabled == false)
            {
                condition = 1;
            }
            Clean(condition);
        }

        //Eliminar varios registros a la vez
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar a estas unidades?", "ELIMINAR UNIDADES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < DataGridViewUnity.SelectedRows.Count; i++)
                    {
                        newUnity = new Unity();
                        newUnityControl = new UnityControl();
                        newUnityControl.Delete(Convert.ToInt32(DataGridViewUnity.SelectedRows[i].Cells["ID"].Value));
                    }
                    MessageBox.Show("Unidades eliminadas con éxito!", "ELIMINAR UNIDADES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ToListUnity(false);
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
            String[] value_dg = { DataGridViewUnity.SelectedRows[0].Cells["NameUnity"].Value.ToString(), DataGridViewUnity.SelectedRows[0].Cells["Quantity"].Value.ToString()};
            String[] name_dg = { "NameUnity", "Quantity" };
            int[] conditional = { 0, 0 };
            for (int i = 1; i < DataGridViewUnity.SelectedRows.Count; i++)
            {
                for (int c = 0; c < 2; c++)
                {
                    if (DataGridViewUnity.SelectedRows[i].Cells[name_dg[c]].Value.ToString() != value_dg[c])
                        conditional[c] = 1;
                    value_dg[c] = DataGridViewUnity.SelectedRows[i].Cells[name_dg[c]].Value.ToString();
                }
            }
            if (conditional[0] == 0)
                TextBoxName.Text = value_dg[0];
            if (conditional[1] == 0)
                NumericQuantity.Value = Convert.ToInt16(value_dg[1]);
            LabelID.Text = "-";
        }

        //OTROS MÉTODOS
        //Vaciar cajas de texto, comboboxes, etc.
        private void Clean(int condition = 2)
        {
            LabelID.Text = "0";
            TextBoxName.Clear();
            NumericQuantity.Value = 0;
            if (condition == 0)
            {
                UnityEnabled(false);
            }
            else if (condition == 1)
            {
                UnityEnabled(true);
            }
        }

        //Validar nombre
        private void Validity()
        {
            if (TextBoxName.Text.Trim().Length == 0)
            {
                throw new Exception("El nombre no fue establecido!");
            }
            if (NumericQuantity.Value == 0)
            {
                throw new Exception("La cantidad no puede ser nula!");
            }
        }
    }
}