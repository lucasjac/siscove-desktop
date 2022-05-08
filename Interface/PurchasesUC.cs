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
    public partial class PurchasesUC : UserControl
    {
        //CustomerControl newCustomerControl;
        Transaction newSales;
        private static PurchasesUC instance;
        LoadingForm newloading = new LoadingForm();

        //INICIO DEL UC
        public PurchasesUC()
        {
            InitializeComponent();
        }

        public static PurchasesUC instantiate
        {
            get
            {
                if (instance == null)
                {
                    instance = new PurchasesUC();
                }
                return instance;
            }
        }

        //DATAGRIDVIEW
        //Aplicar estilo al cargar los datos del DataGridView
        public void DataGridViewSales_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Style();
        }

        //Colorear filas
        private void Style()
        {
            for (int i = 0; i < DataGridViewPurchases.Rows.Count; i++)
            {
                //Colorear las filas pares
                if ((i % 2) == 0)
                {
                    DataGridViewPurchases.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                    DataGridViewPurchases.Rows[i].Cells[0].Style.BackColor = Color.LightSteelBlue;
                    DataGridViewPurchases.Rows[i].Cells[1].Style.BackColor = Color.LightCoral;
                } else
                {
                    DataGridViewPurchases.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    DataGridViewPurchases.Rows[i].Cells[0].Style.BackColor = Color.CornflowerBlue;
                    DataGridViewPurchases.Rows[i].Cells[1].Style.BackColor = Color.IndianRed;
                }

                //Total
                int total = Convert.ToInt16(DataGridViewPurchases.Rows[i].Cells["Price"].Value) * Convert.ToInt16(DataGridViewPurchases.Rows[i].Cells["Quantity"].Value);
                DataGridViewPurchases.Rows[i].Cells["Total"].Value = total.ToString();

                //Factura
                bool invoice = Convert.ToBoolean(DataGridViewPurchases.Rows[i].Cells["Invoice"].Value);
                switch(invoice)
                {
                    case true:
                        DataGridViewPurchases.Rows[i].Cells["F"].Value = "×";
                        //DataGridViewSales.Rows[i].Cells["F"].Style = ;
                        break;
                    default:
                        DataGridViewPurchases.Rows[i].Cells["F"].Value = "✓";
                        //DataGridViewSales.Rows[i].Cells["F"].Style = ;
                        break;
                }
            }
        }

        //Habilitar DataGrid
        private void SalesEnabled(Boolean enable)
        {
            DataGridViewPurchases.Enabled = enable;
            switch(enable)
            {
                case false:
                    for (int i = 0; i < DataGridViewPurchases.Rows.Count; i++)
                    {
                        DataGridViewPurchases.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    break;
                default:
                    Style();
                    break;
            }
        }

        //Modificar o eliminar
        private void DataGridViewSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                newSales = new Sale(Convert.ToInt32(DataGridViewPurchases.Rows[e.RowIndex].Cells["ID"].Value), Convert.ToInt32(DataGridViewPurchases.Rows[e.RowIndex].Cells["IDInfo"].Value),
                    Convert.ToInt32(DataGridViewPurchases.Rows[e.RowIndex].Cells["IDProduct"].Value), Convert.ToInt32(DataGridViewPurchases.Rows[e.RowIndex].Cells["Price"].Value),
                    Convert.ToInt32(DataGridViewPurchases.Rows[e.RowIndex].Cells["Quantity"].Value), Convert.ToByte(DataGridViewPurchases.Rows[e.RowIndex].Cells["Invoice"].Value));
                String cell = DataGridViewPurchases.Columns[e.ColumnIndex].Name;
                if (cell == "Edit")//Modificar
                {
                    LabelID.Text = newSales.Id.ToString();
                    LabelInfoID.Text = newSales.Id_info.ToString();
                    ComboBoxProduct.ValueMember = newSales.Id_product.ToString();
                    NumericQuantity.Value = newSales.Quantity;
                    CheckBoxF.Checked = Convert.ToBoolean(newSales.Invoice);
                    ComboBoxPrice.Text = newSales.Price.ToString();
                } //Eliminar
                else if(cell == "Delete" && MessageBox.Show("Desea eliminar esta venta?", "ELIMINAR REGISTROS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Venta eliminada con éxito!", "ELIMINAR REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }*/
        }

        //Contador de filas seleccionadas
        private void DataGridViewSales_CurrentCellChanged(object sender, EventArgs e)
        {
            int c = DataGridViewPurchases.SelectedRows.Count;
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

        //OTROS BOTONES
        //Guardar y Modificar
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (LabelID.Text != "-")
                    Validity();
                newSales = new Sales(TextBoxName.Text, TextBoxAddress.Text, TextBoxCI.Text, ruc, TextBoxInfo.Text);
                newCustomerControl = new CustomerControl();
                String message;
                switch(LabelID.Text)
                {
                    case "0": //Guardar
                        newCustomerControl.Save(newCustomers);
                        message = "Cliente registrado con éxito!";
                        break;
                    case "-": //Modificar varios a la vez
                        for (int i = 0; i < DataGridViewSales.SelectedRows.Count; i++)
                        {
                                newCustomers = new Customers(Convert.ToInt16(DataGridViewSales.SelectedRows[i].Cells["ID"].Value), DataGridViewSales.SelectedRows[i].Cells["NameCustomer"].Value.ToString(),
                                    DataGridViewSales.SelectedRows[i].Cells["Address"].Value.ToString(), DataGridViewSales.SelectedRows[i].Cells["CI"].Value.ToString(),
                                    DataGridViewSales.SelectedRows[i].Cells["RUC"].Value.ToString(), DataGridViewSales.SelectedRows[i].Cells["Info"].Value.ToString());
                                newCustomerControl = new CustomerControl();
                                if (TextBoxName.Text != "")
                                    newCustomers.Name = TextBoxName.Text;
                                if (TextBoxAddress.Text != "")
                                    newCustomers.Address = TextBoxAddress.Text;
                                if (TextBoxCI.Text != " ,   ,")
                                    newCustomers.Ci = TextBoxCI.Text;
                                if (TextBoxRUC.Text != "")
                                    newCustomers.Ruc = TextBoxRUC.Text;
                                if (TextBoxInfo.Text != "")
                                    newCustomers.Info = TextBoxInfo.Text;
                                newCustomerControl.Modify(newCustomers);
                        }
                        message = "Registros modificados con éxito!";
                        break;
                    default: //Modificar sólo uno
                        newCustomers.Id = Convert.ToInt16(LabelID.Text);
                        newCustomerControl.Modify(newCustomers);
                        message = "Registro modificado con éxito!";
                        break;
                }
                MessageBox.Show(message, "REGISTRO DE CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToListCustomers(false);
                for (int i = 0; i < DataGridViewSales.Rows.Count; i++)
                {
                    if (Convert.ToString(DataGridViewSales.Rows[i].Cells["NameCustomer"].Value) == newCustomers.Name)
                    {
                        TelAdd(message == "Cliente registrado con éxito!", Convert.ToInt16(DataGridViewSales.Rows[i].Cells["ID"].Value), newCustomers.Name);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        //Añadir compra
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Validate();
            this.DataGridViewPurchases.Rows.Add("0", "0", ComboBoxProduct.ValueMember.ToString(), ComboBoxProduct.Text, ComboBoxPrice.Text, 
                NumericQuantity.Value.ToString(), "", CheckBoxF.Checked, "");
            Clean(1);
            Style();
        }

        //Limpiar todo
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            int condition = 2;
            if(DataGridViewPurchases.Enabled == false)
            {
                condition = 1;
            }
            Clean(condition);
        }

        //Eliminar varios registros a la vez
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("Desea eliminar estos registros?", "ELIMINAR REGISTROS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < DataGridViewSales.SelectedRows.Count; i++)
                    {
                        newSales = new Sales();
                        newSaleControl = new SaleControl();
                        newSaleControl.Delete(Convert.ToInt32(DataGridViewSales.SelectedRows[i].Cells["ID"].Value));
                    }
                    MessageBox.Show("Registros eliminados con éxito!", "ELIMINAR REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }

        //Editar varios registros a la vez
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            /*Clean(0);
            String[] value_dg = { DataGridViewSales.SelectedRows[0].Cells["NameCustomer"].Value.ToString(), DataGridViewSales.SelectedRows[0].Cells["Address"].Value.ToString(),
                DataGridViewSales.SelectedRows[0].Cells["CI"].Value.ToString(), DataGridViewSales.SelectedRows[0].Cells["RUC"].Value.ToString(),
                DataGridViewSales.SelectedRows[0].Cells["Info"].Value.ToString()};
            String[] name_dg = { "NameCustomer", "Address", "CI", "RUC", "Info" };
            int[] conditional = { 0, 0, 0, 0, 0 };
            for(int i = 1; i < DataGridViewSales.SelectedRows.Count; i++)
            {
                for(int c = 0; c < 5; c++)
                {
                    if (DataGridViewSales.SelectedRows[i].Cells[name_dg[c]].Value.ToString() != value_dg[c])
                        conditional[c] = 1;
                    value_dg[c] = DataGridViewSales.SelectedRows[i].Cells[name_dg[c]].Value.ToString();
                }
            }
            if (conditional[0] == 0)
                TextBoxName.Text = value_dg[0];
            if (conditional[1] == 0)
                TextBoxAddress.Text = value_dg[1];
            if (conditional[2] == 0)
                TextBoxCI.Text = value_dg[2];
            if (conditional[3] == 0)
                CheckBoxRUCVerify(value_dg[3]);
            if (conditional[4] == 0)
                TextBoxInfo.Text = value_dg[4];
            LabelID.Text = "-";*/
        }

        //OTROS MÉTODOS
        //Vaciar cajas de texto, comboboxes, etc.
        private void Clean(int condition = 2)
        {
            LabelID.Text = "0";
            LabelInfoID.Text = "0";
            ComboBoxProduct.SelectedIndex = -1;
            ComboBoxPrice.SelectedIndex = -1;
            NumericQuantity.Value = 0;
            CheckBoxF.Checked = false;
            if (condition == 0)
            {
                SalesEnabled(false);
            } else if(condition == 1)
            {
                SalesEnabled(true);
            }
        }

        //Validar nombre
        private void Validity()
        {
            if (ComboBoxProduct.Text.Trim().Length == 0)
            {
                throw new Exception("El producto no fue establecido!");
            }

            if (ComboBoxPrice.Text.Trim().Length == 0)
            {
                throw new Exception("El precio no fue establecido!");
            }

            if (NumericQuantity.Value == 0)
            {
                throw new Exception("La cantidad no fue establecida!");
            }
        }
    }
}