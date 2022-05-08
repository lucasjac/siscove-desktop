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
    public partial class StockUC : UserControl
    {
        ProductControl newProductControl;
        Product newProduct;
        private static StockUC instance;
        LoadingForm newloading = new LoadingForm();

        //INICIO DEL UC
        public StockUC()
        {
            InitializeComponent();
        }

        private void StockUC_Load(object sender, EventArgs e)
        {
            ToListStock(true);
            VerifyCheckBoxes();
        }

        public static StockUC instantiate
        {
            get
            {
                if (instance == null)
                {
                    instance = new StockUC();
                }
                return instance;
            }
        }

        //DATAGRIDVIEW
        //Listar
        private async void ToListStock(bool asinc)
        {
            switch (asinc)
            {
                case true:
                    Task<DataTable> newTask = new Task<DataTable>(getStock);
                    newTask.Start();
                    newloading.Show();
                    Clean(1);
                    TextBoxSearch.Clear();
                    DataGridViewStock.DataSource = await newTask;
                    newloading.Close();
                    break;
                default:
                    Clean(1);
                    TextBoxSearch.Clear();
                    DataGridViewStock.DataSource = getStock();
                    break;
            }
        }

        private DataTable getStock()
        {
            try
            {
                newProductControl = new ProductControl();
                return newProductControl.List("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //Aplicar estilo al cargar los datos del DataGridView
        public void DataGridViewStock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Style();
        }

        //Colorear filas
        private void Style()
        {
            for (int i = 0; i < DataGridViewStock.Rows.Count; i++)
            {
                if ((i % 2) == 0)
                {
                    DataGridViewStock.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                    DataGridViewStock.Rows[i].Cells[0].Style.BackColor = Color.LightCyan;
                    DataGridViewStock.Rows[i].Cells[1].Style.BackColor = Color.PapayaWhip;
                    DataGridViewStock.Rows[i].Cells[2].Style.BackColor = Color.LightSteelBlue;
                    DataGridViewStock.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                }
                else
                {
                    DataGridViewStock.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    DataGridViewStock.Rows[i].Cells[0].Style.BackColor = Color.PaleTurquoise;
                    DataGridViewStock.Rows[i].Cells[1].Style.BackColor = Color.Moccasin;
                    DataGridViewStock.Rows[i].Cells[2].Style.BackColor = Color.CornflowerBlue;
                    DataGridViewStock.Rows[i].Cells[3].Style.BackColor = Color.IndianRed;
                }
            }
        }

        //Habilitar DataGrid
        private void StockEnabled(Boolean enable)
        {
            DataGridViewStock.Enabled = enable;
            switch (enable)
            {
                case false:
                    for (int i = 0; i < DataGridViewStock.Rows.Count; i++)
                    {
                        DataGridViewStock.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
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
                newProduct = new Product(Convert.ToInt32(DataGridViewStock.Rows[e.RowIndex].Cells["ID"].Value), DataGridViewStock.Rows[e.RowIndex].Cells["Description"].Value.ToString(),
                    DataGridViewStock.Rows[e.RowIndex].Cells["Barcode"].Value.ToString(), Convert.ToInt32(DataGridViewStock.Rows[e.RowIndex].Cells["Quantity"].Value),
                    DataGridViewStock.Rows[e.RowIndex].Cells["State"].Value.ToString());
                String cell = DataGridViewStock.Columns[e.ColumnIndex].Name;

                //Modificar
                if (cell == "Edit")
                {
                    LabelID.Text = newProduct.Id.ToString();
                    TextBoxBarcode.Text = newProduct.Barcode;
                    TextBoxDescription.Text = newProduct.Description;
                    NumericQuantity.Value = newProduct.Quantity;
                } //Eliminar
                else if (cell == "Delete" && MessageBox.Show("Desea eliminar este producto?", "ELIMINAR PRODUCTOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        newProductControl.Delete(newProduct.Id);
                        MessageBox.Show("Producto eliminado con éxito!", "ELIMINAR PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ToListStock(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } //Agregar unidades
                else if (cell == "Unity")
                {
                    UnityAdd(cell == "Unity", newProduct.Id, newProduct.Description);
                } //Agregar precios
                else
                {
                    PriceAdd(cell == "Prices", newProduct.Id, newProduct.Description);
                }
            }
        }

        //Contador de filas seleccionadas
        private void DataGridViewStock_CurrentCellChanged(object sender, EventArgs e)
        {
            int c = DataGridViewStock.SelectedRows.Count;
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
            SearchProduct(VerifyCheckBoxes());
        }

        private void NumericSearch_ValueChanged(object sender, EventArgs e)
        {
            SearchProduct(VerifyCheckBoxes());
        }

        private void TextBoxSearch2_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(VerifyCheckBoxes());
        }

        private void SearchProduct(string where)
        {
            newProductControl = new ProductControl();
            DataGridViewStock.DataSource = newProductControl.List(where);
            Style();
        }

        //ETIQUETA DE COMPARACIÓN
        private void LabelComparison_Click(object sender, EventArgs e)
        {
            switch (LabelComparison.Text)
            {
                case ">":
                    LabelComparison.Text = "≥";
                    break;
                case "≥":
                    LabelComparison.Text = "=";
                    break;
                case "=":
                    LabelComparison.Text = "≤";
                    break;
                case "≤":
                    LabelComparison.Text = "<";
                    break;
                case "<":
                    LabelComparison.Text = ">";
                    break;
            }
            SearchProduct(VerifyCheckBoxes());
        }

        private void LabelComparison_MouseDown(object sender, MouseEventArgs e)
        {
            LabelComparison.ForeColor = SystemColors.ControlDark;
        }

        private void LabelComparison_MouseHover(object sender, EventArgs e)
        {
            LabelComparison.ForeColor = SystemColors.ControlDarkDark;
        }

        private void LabelComparison_MouseLeave(object sender, EventArgs e)
        {
            LabelComparison.ForeColor = SystemColors.ControlText;
        }

        private void LabelComparison_MouseUp(object sender, MouseEventArgs e)
        {
            LabelComparison.ForeColor = SystemColors.ControlDarkDark;
        }

        //CHECKBOXES
        private void CheckBoxDescription_CheckedChanged(object sender, EventArgs e)
        {
            SearchProduct(VerifyCheckBoxes());
        }

        private void CheckBoxQuantity_CheckedChanged(object sender, EventArgs e)
        {
            SearchProduct(VerifyCheckBoxes());
        }

        private void CheckBoxBarcode_CheckedChanged(object sender, EventArgs e)
        {
            SearchProduct(VerifyCheckBoxes());
        }

        //Verifica el estado de los checkboxes de búsqueda
        private string VerifyCheckBoxes()
        {
            string comparison, search = "AND ";
            switch(LabelComparison.Text)
            {
                case "≥":
                    comparison = ">=";
                    break;
                case "≤":
                    comparison = "<=";
                    break;
                default:
                    comparison = LabelComparison.Text;
                    break;
            }
            CheckBox[] CheckBoxes = { CheckBoxDescription, CheckBoxQuantity, CheckBoxBarcode };
            Panel[] Panels = { PanelText, PanelNumeric, PanelBarcode };
            Label[] Labels = { LabelDescription, LabelQuantity, LabelBarcode };
            String[] Strings = { "description LIKE '%" + TextBoxSearch.Text + "%'", "quantity " + comparison + " " + NumericSearch.Value, "barcode LIKE '%" + TextBoxBarcode.Text + "%'" };
            Boolean[] Components = { true, true, true };
            for(int i = 0; i <= 2; i++)
            {
                switch(CheckBoxes[i].Checked)
                {
                    case true:
                        Panels[i].BackColor = Color.Transparent;
                        Labels[i].ForeColor = SystemColors.ControlText;
                        if ((i == 1 || i == 2) && search != "AND ")
                            search = search + " AND ";
                        search = search + Strings[i];
                        Components[i] = true;
                        break;
                    default:
                        Panels[i].BackColor = Color.Gainsboro;
                        Labels[i].ForeColor = SystemColors.Control;
                        Components[i] = false;
                        switch(i)
                        {
                            case 0:
                                TextBoxSearch.Clear();
                                break;
                            case 1:
                                NumericSearch.Value = 0;
                                break;
                            case 2:
                                TextBoxSearch2.Clear();
                                break;
                        }
                        break;
                }
            }
            TextBoxSearch.Enabled = Components[0];
            NumericSearch.Enabled = LabelComparison.Enabled = Components[1];
            TextBoxSearch2.Enabled = Components[2];
            if (search == "AND ")
                search = "";
            return search;
        }

        //OTROS BOTONES
        //Guardar y Modificar
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (LabelID.Text != "-")
                    Validity();
                newProduct = new Product(TextBoxDescription.Text, TextBoxBarcode.Text, Convert.ToInt16(NumericQuantity.Value), "In Use");
                newProductControl = new ProductControl();
                String message;
                switch (LabelID.Text)
                {
                    case "0": //Guardar
                        newProductControl.Save(newProduct);
                        message = "Producto registrado con éxito!";
                        break;
                    case "-": //Modificar varios a la vez
                        for (int i = 0; i < DataGridViewStock.SelectedRows.Count; i++)
                        {
                            newProduct = new Product(Convert.ToInt32(DataGridViewStock.SelectedRows[i].Cells["ID"].Value), DataGridViewStock.SelectedRows[i].Cells["Description"].Value.ToString(),
                                DataGridViewStock.SelectedRows[i].Cells["Barcode"].Value.ToString(), Convert.ToInt32(DataGridViewStock.SelectedRows[i].Cells["Quantity"].Value),
                                DataGridViewStock.SelectedRows[i].Cells["State"].Value.ToString());
                            newProductControl = new ProductControl();
                            if (TextBoxDescription.Text != "")
                                newProduct.Description = TextBoxDescription.Text;
                            if (TextBoxBarcode.Text != "")
                                newProduct.Barcode = TextBoxBarcode.Text;
                            if (NumericQuantity.Value != -1)
                                newProduct.Quantity = Convert.ToInt16(NumericQuantity.Value);
                            newProductControl.Modify(newProduct);
                        }
                        message = "Registros modificados con éxito!";
                        break;
                    default: //Modificar sólo uno
                        newProduct.Id = Convert.ToInt16(LabelID.Text);
                        newProductControl.Modify(newProduct);
                        message = "Registro modificado con éxito!";
                        break;
                }
                MessageBox.Show(message, "REGISTRO DE PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToListStock(false);
                for (int i = 0; i < DataGridViewStock.Rows.Count; i++)
                {
                    if (Convert.ToString(DataGridViewStock.Rows[i].Cells["Description"].Value) == newProduct.Description)
                    {
                        PriceAdd(message == "Cliente registrado con éxito!", Convert.ToInt16(DataGridViewStock.Rows[i].Cells["ID"].Value), newProduct.Description);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Agregar unidad
        private void UnityAdd(Boolean b, int id, String name)
        {
            if(b == true)
            {
                if (MessageBox.Show("Desea agregar unidades a este producto?", "UNIDADES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProductUnityUC newProductUnityUC = new ProductUnityUC();
                    Panel1.Controls.Remove(this);
                    Panel1.Controls.Add(newProductUnityUC);
                    newProductUnityUC.Dock = DockStyle.Fill;
                    newProductUnityUC.BringToFront();
                    newProductUnityUC.establish_id(id, name, "0");
                }
            }
        }

        //Agregar precio
        private void PriceAdd(Boolean b, int id, String name)
        {
            if (b == true)
            {
                if (MessageBox.Show("Desea agregar precios a este producto?", "PRECIOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PricesUC newPricesUC = new PricesUC();
                    Panel1.Controls.Remove(this);
                    Panel1.Controls.Add(newPricesUC);
                    newPricesUC.Dock = DockStyle.Fill;
                    newPricesUC.BringToFront();
                    newPricesUC.establish_id(id, name);
                }
            }
        }

        //Limpiar todo
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            int condition = 2;
            if (DataGridViewStock.Enabled == false)
            {
                condition = 1;
            }
            Clean(condition);
        }

        //Eliminar varios registros a la vez
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar a estos productos?", "ELIMINAR PRODUCTOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < DataGridViewStock.SelectedRows.Count; i++)
                    {
                        newProduct = new Product();
                        newProductControl = new ProductControl();
                        newProductControl.Delete(Convert.ToInt32(DataGridViewStock.SelectedRows[i].Cells["ID"].Value));
                    }
                    MessageBox.Show("Productos eliminados con éxito!", "ELIMINAR PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ToListStock(false);
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
                String[] value_dg = { DataGridViewStock.SelectedRows[0].Cells["Description"].Value.ToString(), DataGridViewStock.SelectedRows[0].Cells["Barcode"].Value.ToString(),
                DataGridViewStock.SelectedRows[0].Cells["Quantity"].Value.ToString()};
                String[] name_dg = { "Description", "Barcode", "Quantity" };
                int[] conditional = { 0, 0, 0 };
                for (int i = 1; i < DataGridViewStock.SelectedRows.Count; i++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (DataGridViewStock.SelectedRows[i].Cells[name_dg[c]].Value.ToString() != value_dg[c])
                            conditional[c] = 1;
                        value_dg[c] = DataGridViewStock.SelectedRows[i].Cells[name_dg[c]].Value.ToString();
                    }
                }
                if (conditional[0] == 0)
                    TextBoxDescription.Text = value_dg[0];
                if (conditional[1] == 0)
                    TextBoxBarcode.Text = value_dg[1];
                if (conditional[2] == 0)
                    NumericQuantity.Value = Convert.ToInt16(value_dg[2]);
                LabelID.Text = "-";
        }

        //OTROS MÉTODOS
        //Vaciar cajas de texto, comboboxes, etc.
        private void Clean(int condition = 2)
        {
            LabelID.Text = "0";
            TextBoxDescription.Clear();
            NumericQuantity.Value = 0;
            TextBoxBarcode.Clear();
            if (condition == 0)
            {
                StockEnabled(false);
            }
            else if (condition == 1)
            {
                StockEnabled(true);
            }
        }

        private void Validity()
        {
            if (TextBoxDescription.Text.Trim().Length == 0)
            {
                throw new Exception("La descripción del producto no fue establecido!");
            }
            if (NumericQuantity.Value == -1)
            {
                throw new Exception("La cantidad no puede ser negativa!");
            }
        }
    }
}