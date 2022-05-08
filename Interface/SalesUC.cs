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
using System.Globalization;

namespace Interface
{
    public partial class SalesUC : UserControl
    {
        SaleControl newSaleControl;
        ProductControl newProductControl;
        Transaction newSales;
        TransactionInfo newSaleInfo;
        private static SalesUC instance;
        LoadingForm newloading = new LoadingForm();
        DataTable sales = new DataTable();

        //INICIO DEL UC
        public SalesUC()
        {
            InitializeComponent();
        }

        private void SalesUC_Load(object sender, EventArgs e)
        {
            InitiateComponents();
        }

        public static SalesUC instantiate
        {
            get
            {
                if (instance == null)
                {
                    instance = new SalesUC();
                }
                return instance;
            }
        }

        public void establish_id(int id, TransactionInfo salesInfo)
        {
            if(salesInfo != null)
            {
                LabelID.Text = id.ToString();
                LabelInfoID.Text = salesInfo.Id.ToString();
                ComboBoxClient.SelectedValue = salesInfo.IdPerson;
                DateTimePicker.Value = DateTime.ParseExact(salesInfo.Date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                ToListSales("INNER JOIN PRODUCT pro ON s.FK_ID_PRODUCT = pro.ID_PRODUCT WHERE s.FK_ID_SALE_INFO = " + salesInfo.Id.ToString());
                if (LabelID.Text != "0")
                {
                    int i = 0;
                    bool condition = true;
                    while (condition)
                    {
                        if (DataGridViewSales.Rows[i].Cells["ID"].Value.ToString() == LabelID.Text)
                        {
                            condition = false;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    newSales = new Transaction(Convert.ToInt32(DataGridViewSales.Rows[i].Cells["ID"].Value), Convert.ToInt32(DataGridViewSales.Rows[i].Cells["IDInfo"].Value),
                        Convert.ToInt32(DataGridViewSales.Rows[i].Cells["IDProduct"].Value), Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Price"].Value),
                        Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Quantity"].Value), Convert.ToByte(DataGridViewSales.Rows[i].Cells["Invoice"].Value));
                    LabelID.Text = newSales.Id.ToString();
                    ComboBoxProduct.SelectedValue = newSales.IdProduct;
                    NumericQuantity.Value = newSales.Quantity;
                    CheckBoxF.Checked = Convert.ToBoolean(newSales.Invoice);
                    ComboBoxPrice.Text = newSales.Price.ToString();
                    ComboBoxUnity.SelectedIndex = 0;
                    ChangesPanel(true, "Modificar");
                }
            }
        }

        //Listar componentes
        private async void InitiateComponents()
        {
            try
            {
                Task<List<DataTable>> newTask = new Task<List<DataTable>>(getLists);
                newTask.Start();
                newloading.Show();
                sales.Columns.Add("ID_SALE");
                sales.Columns.Add("FK_ID_SALE_INFO");
                sales.Columns.Add("FK_ID_PRODUCT");
                sales.Columns.Add("description");
                sales.Columns.Add("price");
                sales.Columns.Add("quantity");
                sales.Columns.Add("difference");
                sales.Columns.Add("invoice");
                List<DataTable> tables = await newTask;
                ComboBoxProduct.DataSource = tables[0];
                ComboBoxProduct.DisplayMember = "description";
                ComboBoxProduct.ValueMember = "ID_PRODUCT";
                ComboBoxProduct.SelectedIndex = -1;
                DataTable customers = new DataTable();
                customers.Merge(tables[1]);
                ComboBoxClient.DataSource = customers;
                ComboBoxClient.DisplayMember = "name";
                ComboBoxClient.ValueMember = "ID_PERSON";
                ComboBoxClient.SelectedIndex = 0;
                newloading.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<DataTable> getLists()
        {
            try
            {
                ProductControl ProductToList = new ProductControl();
                CustomerControl CustomerToList = new CustomerControl();
                List<DataTable> tables = new List<DataTable>();
                tables.Add(ProductToList.List(""));
                tables.Add(CustomerToList.List("AND type = 'Física'"));
                return tables;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //DATAGRIDVIEW
        //Listar
        private void ToListSales(string condition)
        {
            try
            {
                newSaleControl = new SaleControl();
                DataRow[] rows = newSaleControl.List(condition).Select();
                foreach(DataRow row in rows)
                {
                    DataRow newrow = sales.NewRow();
                    newrow["ID_SALE"] = row["ID_SALE"];
                    newrow["FK_ID_SALE_INFO"] = row["FK_ID_SALE_INFO"];
                    newrow["FK_ID_PRODUCT"] = row["FK_ID_PRODUCT"];
                    newrow["description"] = row["description"];
                    newrow["price"] = row["price"];
                    newrow["quantity"] = row["quantity"];
                    newrow["difference"] = 0;
                    newrow["invoice"] = row["invoice"];
                    sales.Rows.Add(newrow);
                }
                DataGridViewSales.DataSource = sales;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Aplicar estilo al cargar los datos del DataGridView
        private void DataGridViewSales_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Style();
        }

        //Colorear filas
        private void Style()
        {
            for (int i = 0; i < DataGridViewSales.Rows.Count; i++)
            {
                //Colorear las filas pares
                if ((i % 2) == 0)
                {
                    DataGridViewSales.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                    DataGridViewSales.Rows[i].Cells[3].Style.BackColor = Color.LightSteelBlue;
                    DataGridViewSales.Rows[i].Cells[4].Style.BackColor = Color.LightCoral;
                } else
                {
                    DataGridViewSales.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    DataGridViewSales.Rows[i].Cells[3].Style.BackColor = Color.CornflowerBlue;
                    DataGridViewSales.Rows[i].Cells[4].Style.BackColor = Color.IndianRed;
                }

                //Precio
                DataGridViewSales.Rows[i].Cells["Price2"].Value = DataGridViewSales.Rows[i].Cells["Price"].Value + " GS.";

                //Total
                int total = Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Price"].Value) * Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Quantity"].Value);
                DataGridViewSales.Rows[i].Cells["Total"].Value = total.ToString() + " GS.";
                DataGridViewSales.Rows[i].Cells["Total"].Style.BackColor = Color.LightBlue;

                //Factura
                byte invoice = Convert.ToByte(DataGridViewSales.Rows[i].Cells["Invoice"].Value);
                switch(invoice)
                {
                    case 1:
                        DataGridViewSales.Rows[i].Cells["F"].Value = "✓";
                        DataGridViewSales.Rows[i].Cells["F"].Style.ForeColor = Color.Green;
                        break;
                    default:
                        DataGridViewSales.Rows[i].Cells["F"].Value = "×";
                        DataGridViewSales.Rows[i].Cells["F"].Style.ForeColor = Color.Red;
                        break;
                }
            }
        }

        //Habilitar DataGrid
        private void SalesEnabled(Boolean enable)
        {
            DataGridViewSales.Enabled = enable;
            switch(enable)
            {
                case false:
                    for (int i = 0; i < DataGridViewSales.Rows.Count; i++)
                    {
                        DataGridViewSales.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
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
            if (e.RowIndex >= 0)
            {
                newSales = new Transaction(Convert.ToInt32(DataGridViewSales.Rows[e.RowIndex].Cells["ID"].Value), Convert.ToInt32(DataGridViewSales.Rows[e.RowIndex].Cells["IDInfo"].Value),
                    Convert.ToInt32(DataGridViewSales.Rows[e.RowIndex].Cells["IDProduct"].Value), Convert.ToInt32(DataGridViewSales.Rows[e.RowIndex].Cells["Price"].Value),
                    Convert.ToInt32(DataGridViewSales.Rows[e.RowIndex].Cells["Quantity"].Value), Convert.ToByte(DataGridViewSales.Rows[e.RowIndex].Cells["Invoice"].Value));
                String cell = DataGridViewSales.Columns[e.ColumnIndex].Name;
                if (cell == "Edit")//Modificar
                {
                    if(LabelInfoID.Text == "0")
                    {
                        sales.Rows[e.RowIndex].Delete();
                    }
                    LabelID.Text = newSales.Id.ToString();
                    ComboBoxProduct.SelectedValue = newSales.IdProduct;
                    NumericQuantity.Value = newSales.Quantity;
                    CheckBoxF.Checked = Convert.ToBoolean(newSales.Invoice);
                    ComboBoxPrice.Text = newSales.Price.ToString();
                    ComboBoxUnity.SelectedText = "Unidad";
                    ChangesPanel(true, "Modificar");
                } //Eliminar
                else if(cell == "Delete" && MessageBox.Show("Desea eliminar esta venta?", "ELIMINAR REGISTROS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if(LabelInfoID.Text != "0")
                        {
                            newSaleControl = new SaleControl();
                            newProductControl = new ProductControl();
                            newProductControl.ModifyQuantity(newSales.IdProduct, " + " + newSales.Quantity);
                            newSaleControl.Delete(sales.Rows[e.RowIndex].Field<int>(0));
                        }
                        sales.Rows[e.RowIndex].Delete();
                        MessageBox.Show("Venta eliminada con éxito!", "ELIMINAR REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                DataGridViewSales.DataSource = sales;
            }
        }

        //Contador de filas seleccionadas
        private void DataGridViewSales_CurrentCellChanged(object sender, EventArgs e)
        {
            int c = DataGridViewSales.SelectedRows.Count;
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
            try
            {
                int last_id;
                newSaleControl = new SaleControl();
                newProductControl = new ProductControl();
                newSaleInfo = new TransactionInfo(Convert.ToInt32(LabelInfoID.Text), Convert.ToInt32(ComboBoxClient.SelectedValue), DateTimePicker.Text);
                switch(LabelInfoID.Text)
                {
                    case "0":
                        newSaleControl.SaveInfo(newSaleInfo);
                        last_id = newSaleControl.GetLastId();
                        break;
                    default:
                        newSaleControl.ModifyInfo(newSaleInfo);
                        last_id = Convert.ToInt16(DataGridViewSales.Rows[1].Cells["IDInfo"].Value);
                        break;
                }
                for (int i = 0; i < DataGridViewSales.Rows.Count; i++)
                {
                    newSales = new Transaction(Convert.ToInt32(DataGridViewSales.Rows[i].Cells["ID"].Value), last_id,
                                    Convert.ToInt32(DataGridViewSales.Rows[i].Cells["IDProduct"].Value), Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Price"].Value),
                                    Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Quantity"].Value), Convert.ToByte(DataGridViewSales.Rows[i].Cells["Invoice"].Value));
                    newSaleControl = new SaleControl();
                    newProductControl = new ProductControl();
                    switch (newSales.Id)
                    {
                        case 0:
                            newProductControl.ModifyQuantity(newSales.IdProduct, "- " + newSales.Quantity);
                            newSaleControl.Save(newSales);
                            break;
                        default:
                            newProductControl.ModifyQuantity(newSales.IdProduct, "- " + DataGridViewSales.Rows[i].Cells["Difference"].Value.ToString());
                            newSaleControl.Modify(newSales);
                            break;
                    }
                }
                MessageBox.Show("Registros guardados con éxito!", "REGISTRO DE VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sales.Rows.Clear();
                DataGridViewSales.DataSource = sales;
                Clean();
                ComboBoxClient.SelectedIndex = 0;
                DateTimePicker.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Añadir compra
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(LabelID.Text == "0" || LabelID.Text != "-")
                    Validity();
                int quantity = Convert.ToInt32(NumericQuantity.Value) * Convert.ToInt32(ComboBoxUnity.SelectedValue);
                if (LabelID.Text == "0")
                {
                    bool condition = true;
                    int i = 0;
                    while(i < sales.Rows.Count && condition == true)
                    {
                        if (ComboBoxProduct.SelectedValue.ToString() == DataGridViewSales.Rows[i].Cells["IDProduct"].Value.ToString() && Convert.ToByte(CheckBoxF.Checked) == Convert.ToByte(DataGridViewSales.Rows[i].Cells["Invoice"].Value))
                        {
                            condition = false;
                        }
                        i++;
                    }
                    if(condition)
                    {
                        sales.Rows.Add(LabelID.Text, LabelInfoID.Text, ComboBoxProduct.SelectedValue, ComboBoxProduct.Text, ComboBoxPrice.Text,
                            quantity, 0, Convert.ToByte(CheckBoxF.Checked));
                    } else
                    {
                        DataRow row = sales.Select("id_product = " + DataGridViewSales.Rows[i-1].Cells["IDProduct"].Value.ToString()).FirstOrDefault();
                        string gridtotal = DataGridViewSales.Rows[i-1].Cells["Total"].Value.ToString().Replace(" GS.", "");
                        if (Convert.ToInt32(gridtotal) + (quantity * Convert.ToInt32(ComboBoxPrice.Text)) < 100000000)
                        {
                            row["price"] = Convert.ToInt32(row["price"]) + Convert.ToInt32(ComboBoxPrice.Text);
                            row["quantity"] = Convert.ToInt32(row["quantity"]) + quantity;
                        } else
                        {
                            throw new Exception("El total no debe superar los 100.000.000 GS!");
                        }
                    }
                } ////////////////////////////////////////////////
                else if (LabelID.Text != "-")
                {
                    DataRow row = sales.Select("ID_SALE = " + LabelID.Text).FirstOrDefault();
                    row["FK_ID_PRODUCT"] = ComboBoxProduct.SelectedValue;
                    row["description"] = ComboBoxProduct.SelectedText;
                    row["price"] = ComboBoxPrice.Text;
                    row["difference"] = Convert.ToInt32(row["quantity"]) - quantity;
                    row["quantity"] = quantity;
                    row["invoice"] = Convert.ToByte(CheckBoxF.Checked);
                }
                else ////////////////////////////////////////////////
                {
                    DataRow[] rows = sales.Select();
                    for (int i = 0; i < DataGridViewSales.Rows.Count; i++)
                    {
                        if (DataGridViewSales.Rows[i].Selected)
                        {
                            if (ComboBoxPrice.Text != "")
                                rows[i]["price"] = ComboBoxPrice.Text;
                            if (NumericQuantity.Value > 0)
                            {
                                rows[i]["difference"] = Convert.ToInt32(rows[i]["quantity"]) - quantity;
                                rows[i]["quantity"] = Convert.ToInt32(NumericQuantity.Value);
                            }
                        }
                    }
                }
                DataGridViewSales.DataSource = sales;
                Clean(1);
                Style();
                ChangesPanel(true, "Añadir");
                CleanButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Limpiar formulario
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            int condition = 2;
            if(DataGridViewSales.Enabled == false)
            {
                condition = 1;
            }
            Clean(condition);
        }

        //Limpiar DataGrid
        private void CleanButton_Click(object sender, EventArgs e)
        {
            sales.Clear();
            DataGridViewSales.DataSource = sales;
            CleanButton.Enabled = false;
        }

        //Eliminar varios registros a la vez
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar estos registros?", "ELIMINAR REGISTROS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    List<DataRow> rowsToDelete = new List<DataRow>();
                    for (int i = 0; i < DataGridViewSales.SelectedRows.Count; i++)
                    {
                        rowsToDelete.Add(sales.Select("FK_ID_PRODUCT = " + DataGridViewSales.SelectedRows[i].Cells["IDProduct"].Value.ToString()).FirstOrDefault());
                        int id = Convert.ToInt32(DataGridViewSales.SelectedRows[i].Cells["ID"].Value);
                        if (id != 0)
                        {
                            newSaleControl = new SaleControl();
                            newProductControl = new ProductControl();
                            newProductControl.ModifyQuantity(Convert.ToInt32(DataGridViewSales.SelectedRows[i].Cells["IDProduct"].Value), " + " + Convert.ToInt32(DataGridViewSales.SelectedRows[i].Cells["Quantity"].Value));
                            newSaleControl.Delete(id);
                        }
                    }
                    foreach (DataRow row in rowsToDelete)
                    {
                        sales.Rows.Remove(row);
                    }
                    MessageBox.Show("Registros eliminados con éxito!", "ELIMINAR REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            String[] value_dg = { DataGridViewSales.SelectedRows[0].Cells["Quantity"].Value.ToString(), DataGridViewSales.SelectedRows[0].Cells["Price"].Value.ToString()};
            String[] name_dg = { "Quantity", "Price" };
            int[] conditional = { 0, 0 };
            for(int i = 1; i < DataGridViewSales.SelectedRows.Count; i++)
            {
                for(int c = 0; c < 2; c++)
                {
                    if (DataGridViewSales.SelectedRows[i].Cells[name_dg[c]].Value.ToString() != value_dg[c])
                        conditional[c] = 1;
                    value_dg[c] = DataGridViewSales.SelectedRows[i].Cells[name_dg[c]].Value.ToString();
                }
            }
            if (conditional[0] == 0)
            {
                NumericQuantity.Value = Convert.ToInt32(value_dg[0]);
            }
            if (conditional[1] == 0)
                ComboBoxPrice.SelectedText = value_dg[1];
            LabelID.Text = "-";
            ChangesPanel(false, "Modificar");
        }

        //Cambiar disponibilidades y también el texto del botón de añadir
        private void ChangesPanel(bool enabled, String text)
        {
            ComboBoxProduct.Enabled = enabled;
            CheckBoxF.Enabled = enabled;
            ComboBoxUnity.Enabled = enabled;
            ButtonAdd.Text = text;
        }

        //OTROS MÉTODOS
        //Vaciar cajas de texto, comboboxes, etc.
        private void Clean(int condition = 2)
        {
            LabelID.Text = "0";
            LabelInfoID.Text = "0";
            LabelValue.Text = "0";
            LabelQuantity.Text = "0";
            ComboBoxProduct.SelectedIndex = -1;
            ComboBoxPrice.DataSource = null;
            ComboBoxPrice.Text = "";
            ComboBoxUnity.DataSource = null;
            ComboBoxUnity.Text = "";
            NumericQuantity.Value = 0;
            CheckBoxF.Checked = false;
            TextBoxBarcode.Clear();
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

            if (NumericQuantity.Value == 0)
            {
                throw new Exception("La cantidad no fue establecida!");
            }

            if (ComboBoxUnity.Text.Trim().Length == 0)
            {
                throw new Exception("La unidad no fue establecida!");
            }

            if (ComboBoxPrice.Text.Trim().Length == 0)
            {
                throw new Exception("El precio no fue establecido!");
            }

            int quantity = Convert.ToInt32(NumericQuantity.Value) * Convert.ToInt32(ComboBoxUnity.SelectedValue);
            if (sales.Select("FK_ID_PRODUCT = " + ComboBoxProduct.SelectedValue).LastOrDefault() != null)
            {
                DataRow row = sales.Select("FK_ID_PRODUCT = " + ComboBoxProduct.SelectedValue).LastOrDefault();
                quantity += Convert.ToInt32(row.Field<String>("quantity"));
            }
            int total = Convert.ToInt32(ComboBoxPrice.Text) * quantity;
            newProductControl = new ProductControl();

            if (quantity > Convert.ToInt64(newProductControl.SearchQuantity("WHERE ID_PRODUCT = " + ComboBoxProduct.SelectedValue)))
            {
                MessageBox.Show("La cantidad especificada supera la cantidad en stock.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (total > 100000000)
            {
                throw new Exception("El total no puede superar a los 100.000.000 GS!");
            }
        }

        //Colocar el precio correspondiente a la cantidad
        private void NumericQuantity_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxProduct.SelectedIndex != -1)
                {
                    int quantity = 0;
                    if (Convert.ToInt32(ComboBoxUnity.SelectedValue) == 1)
                    {
                        LabelQuantity.Text = NumericQuantity.Value.ToString();
                        LabelValue.Text = "0";
                        quantity = Convert.ToInt32(LabelQuantity.Text);
                    }
                    else
                    {
                        if (NumericQuantity.Value > 0)
                        {
                            LabelValue.Text = Convert.ToString(Convert.ToInt32(NumericQuantity.Value) * Convert.ToInt32(ComboBoxUnity.SelectedValue));
                            quantity = Convert.ToInt32(LabelValue.Text);
                        }
                    }
                    PriceControl PriceToList = new PriceControl();
                    String idPrice = PriceToList.SearchId("WHERE quantity <= " + quantity + " AND FK_ID_PRODUCT = " + ComboBoxProduct.SelectedValue.ToString());
                    if(idPrice != "")
                    {
                        ComboBoxPrice.SelectedValue = idPrice;
                    } else
                    {
                        ComboBoxPrice.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Listar los precios correspondiente al producto
        private void ComboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxProduct.SelectedIndex != -1 && ComboBoxProduct.ValueMember == "ID_PRODUCT")
            {
                PriceControl PriceToList = new PriceControl();
                ComboBoxPrice.DataSource = PriceToList.List("WHERE FK_ID_PRODUCT = " + ComboBoxProduct.SelectedValue);
                ComboBoxPrice.DisplayMember = "price";
                ComboBoxPrice.ValueMember = "ID_PRICE";
                ComboBoxPrice.SelectedIndex = -1;
                UnityProductControl UnityToList = new UnityProductControl();
                DataTable units = new DataTable();
                units = UnityToList.List("u.name, u.quantity FROM PRODUCT_UNITY up INNER JOIN UNITY u ON up.FK_ID_UNITY = u.ID_UNITY WHERE up.FK_ID_PRODUCT = " + ComboBoxProduct.SelectedValue);
                DataRow row = units.NewRow();
                row["ID_PRODUCT_UNITY"] = 0;
                row["FK_ID_PRODUCT"] = ComboBoxProduct.SelectedValue;
                row["FK_ID_UNITY"] = 0;
                row["name"] = "Unidad";
                row["quantity"] = 1;
                units.Rows.Add(row);
                DataTable UnityData = units;
                ComboBoxUnity.DataSource = UnityData;
                ComboBoxUnity.DisplayMember = "name";
                ComboBoxUnity.ValueMember = "quantity";
                if(UnityData.Rows.Count == 0)
                {
                    ComboBoxUnity.SelectedIndex = -1;
                    ComboBoxUnity.Text = "";
                } else
                {
                    ComboBoxUnity.SelectedValue = 1;
                }
                LabelQuantity.Text = "0";
            }
        }

        //Modificar cantidad al cambiar la unidad
        private void ComboBoxUnity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxUnity.SelectedIndex != -1 && ComboBoxUnity.ValueMember == "quantity")
                {
                    if (Convert.ToInt32(ComboBoxUnity.SelectedValue) == 1)
                    {
                        NumericQuantity.Value = Convert.ToInt32(LabelValue.Text);
                    }
                    else
                    {
                        NumericQuantity.Value = Convert.ToInt32(LabelQuantity.Text) / Convert.ToInt32(ComboBoxUnity.SelectedValue);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("La cantidad no debe superar el millón de unidades!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Agregar registro al presionar ENTER
        private void NumericQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ButtonAdd_Click(sender, e);
            }
        }

        private void ComboBoxPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonAdd_Click(sender, e);
            }
        }

        private void CheckBoxF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckBoxF.Checked = !CheckBoxF.Checked;
            }
        }

        //Ir a Registro
        private void ButtonRedirect_Click(object sender, EventArgs e)
        {
            if (LabelInfoID.Text == "0" && DataGridViewSales.Rows.Count > 0)
            {
                if(MessageBox.Show("Desea salir sin guardar?", "REGISTROS NO GUARDADOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SalesInfoUC newSalesInfo = new SalesInfoUC();
                    Panel1.Controls.Remove(this);
                    Panel1.Controls.Add(newSalesInfo);
                    newSalesInfo.Dock = DockStyle.Fill;
                    newSalesInfo.BringToFront();
                }
            } else
            {
                SalesInfoUC newSalesInfo = new SalesInfoUC();
                Panel1.Controls.Remove(this);
                Panel1.Controls.Add(newSalesInfo);
                newSalesInfo.Dock = DockStyle.Fill;
                newSalesInfo.BringToFront();
            }
        }

        ///Buscar por Código de Barras
        private void TextBoxBarcode_TextChanged(object sender, EventArgs e)
        {
            if(TextBoxBarcode.Text != "")
            {
                ProductControl ProductToList = new ProductControl();
                DataTable products = new DataTable();
                products = ProductToList.List("AND barcode LIKE '%" + TextBoxBarcode.Text + "%'");
                if (products.Rows.Count > 0)
                {
                    DataRow row = products.Rows[0];
                    ComboBoxProduct.SelectedValue = Convert.ToInt32(row[0]);
                }
                else
                {
                    ComboBoxProduct.SelectedIndex = -1;
                }
            }
        }
    }
}