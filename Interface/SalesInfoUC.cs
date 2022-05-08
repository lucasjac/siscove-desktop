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
    public partial class SalesInfoUC : UserControl
    {
        //CustomerControl newCustomerControl;
        SaleControl newSaleControl;
        private static SalesInfoUC instance;
        LoadingForm newloading = new LoadingForm();

        //INICIO DEL UC
        public SalesInfoUC()
        {
            InitializeComponent();
        }

        public static SalesInfoUC instantiate
        {
            get
            {
                if (instance == null)
                {
                    instance = new SalesInfoUC();
                }
                return instance;
            }
        }

        private void SalesInfoUC_Load(object sender, EventArgs e)
        {
            InitiateComponents();
        }

        //Listar componentes
        private async void InitiateComponents()
        {
            try
            {
                Task<List<DataTable>> newTask = new Task<List<DataTable>>(getLists);
                newTask.Start();
                newloading.Show();
                DateTime today = DateTime.Today;
                SinceTimePicker.Text = today.AddMonths(-1).ToString();
                ComboBoxList.SelectedIndex = 1;
                List<DataTable> tables = await newTask;
                ComboBoxProduct.DataSource = tables[0];
                ComboBoxProduct.DisplayMember = "description";
                ComboBoxProduct.ValueMember = "ID_PRODUCT";
                ComboBoxProduct.SelectedIndex = -1;
                ComboBoxCustomer.DataSource = tables[1];
                ComboBoxCustomer.DisplayMember = "name";
                ComboBoxCustomer.ValueMember = "ID_PERSON";
                ComboBoxCustomer.SelectedIndex = -1;
                DataGridViewSales.DataSource = tables[2];
                LabelList.Text = "Listados: " + DataGridViewSales.Rows.Count;
                Style();
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
                newSaleControl = new SaleControl();
                List<DataTable> tables = new List<DataTable>();
                tables.Add(ProductToList.List(""));
                tables.Add(CustomerToList.List("AND type = 'Física'"));
                tables.Add(newSaleControl.List("INNER JOIN SALE_INFO si ON si.ID_SALE_INFO = s.FK_ID_SALE_INFO " +
                            "INNER JOIN PRODUCT pro ON s.FK_ID_PRODUCT = pro.ID_PRODUCT WHERE s.invoice = 0 OR s.invoice = 1"));
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
        private String[] PrepareStrings()
        {
            String[] conditions = new String[2];
            conditions[0] = "INNER JOIN SALE_INFO si ON si.ID_SALE_INFO = s.FK_ID_SALE_INFO " +
                            "INNER JOIN PRODUCT pro ON s.FK_ID_PRODUCT = pro.ID_PRODUCT WHERE ";
            conditions[1] = "INNER JOIN PERSON pe ON si.FK_ID_PERSON = pe.ID_PERSON " +
                            "WHERE CONVERT(datetime, si.date, 103) BETWEEN CONVERT(datetime, '" + SinceTimePicker.Text + "', 103) " +
                            "AND CONVERT(datetime, '" + UntilTimePicker.Text + "', 103)";
            if (LabelInvoice.Text == "S/F")
            {
                conditions[0] = conditions[0] + "s.invoice = 0";
            }
            else if (LabelInvoice.Text == "C/F")
            {
                conditions[0] = conditions[0] + "s.invoice = 1";
            }
            else
            {
                conditions[0] = conditions[0] + "(s.invoice = 0 OR s.invoice = 1)";
            }
            if (ComboBoxProduct.SelectedIndex != -1)
                conditions[0] = conditions[0] + " AND s.FK_ID_PRODUCT = " + ComboBoxProduct.SelectedValue;
            if (QuantityNumeric.Value > 0)
                conditions[0] = conditions[0] + " AND s.quantity " + LabelEqual.Text + " " + QuantityNumeric.Value;
            if (PriceNumeric.Value > 0)
                conditions[0] = conditions[0] + " AND s.price " + LabelEqual2.Text + " " + PriceNumeric.Value;
            if (ComboBoxCustomer.SelectedIndex != -1)
            {
                conditions[1] = conditions[1] + " AND si.FK_ID_PERSON = " + ComboBoxCustomer.SelectedValue;
                conditions[0] = conditions[0] + " AND si.FK_ID_PERSON = " + ComboBoxCustomer.SelectedValue;
            }
            return conditions;
        }

        private void ToListSalesInfo()
        {
            try
            {
                String[] conditions = PrepareStrings();
                newSaleControl = new SaleControl();
                if (ComboBoxList.SelectedIndex == 0)
                {
                    DataGridViewSalesInfo.DataSource = newSaleControl.ListInfo(conditions[1]);
                    LabelList.Text = "Listados: " + DataGridViewSalesInfo.Rows.Count;
                } else
                {
                    DataGridViewSales.DataSource = newSaleControl.List(conditions[0]);
                    LabelList.Text = "Listados: " + DataGridViewSales.Rows.Count;
                }
                DataGridViewSalesInfo.Visible = (ComboBoxList.SelectedIndex == 0);
                DataGridViewSales.Visible = (ComboBoxList.SelectedIndex == 1);
                Style();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Aplicar estilo al cargar los datos del DataGridView
        public void DataGridViewSalesInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Style();
        }

        //Colorear filas
        private void Style()
        {
            int c;
            switch (ComboBoxList.SelectedIndex)
            {
                case 0:
                    c = DataGridViewSalesInfo.Rows.Count;
                    break;
                default:
                    c = DataGridViewSales.Rows.Count;
                    break;
            }
            int total1 = 0;
            int total2 = 0;
            int total3 = 0;
            for (int i = 0; i < c; i++)
            {
                if (ComboBoxList.SelectedIndex == 0)
                {
                    if ((i % 2) == 0)
                    {
                        DataGridViewSalesInfo.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                        DataGridViewSalesInfo.Rows[i].Cells[0].Style.BackColor = Color.LightSteelBlue;
                        DataGridViewSalesInfo.Rows[i].Cells[1].Style.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        DataGridViewSalesInfo.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        DataGridViewSalesInfo.Rows[i].Cells[0].Style.BackColor = Color.CornflowerBlue;
                        DataGridViewSalesInfo.Rows[i].Cells[1].Style.BackColor = Color.IndianRed;
                    }
                }
                else
                {
                    //Colorear las filas pares
                    if ((i % 2) == 0)
                    {
                        DataGridViewSales.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                        DataGridViewSales.Rows[i].Cells[5].Style.BackColor = Color.LightSteelBlue;
                        DataGridViewSales.Rows[i].Cells[6].Style.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        DataGridViewSales.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        DataGridViewSales.Rows[i].Cells[5].Style.BackColor = Color.CornflowerBlue;
                        DataGridViewSales.Rows[i].Cells[6].Style.BackColor = Color.IndianRed;
                    }
                    //Precio
                    DataGridViewSales.Rows[i].Cells["Price2"].Value = DataGridViewSales.Rows[i].Cells["Price"].Value + " GS.";
                    //Total
                    int total = Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Price"].Value) * Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Quantity"].Value);
                    DataGridViewSales.Rows[i].Cells["Total"].Value = total.ToString() + " GS.";
                    DataGridViewSales.Rows[i].Cells["Total"].Style.BackColor = Color.LightBlue;
                    //Costo del Producto
                    PurchaseControl newPurchaseControl = new PurchaseControl();
                    DataGridViewSales.Rows[i].Cells["PricePurchase"].Value = newPurchaseControl.GetPrice(Convert.ToInt32(DataGridViewSales.Rows[i].Cells["IDProduct"].Value));
                    int totalPurchase = Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Quantity"].Value) * Convert.ToInt32(DataGridViewSales.Rows[i].Cells["PricePurchase"].Value);
                    DataGridViewSales.Rows[i].Cells["TotalPurchase"].Value = totalPurchase.ToString() + " GS.";
                    DataGridViewSales.Rows[i].Cells["TotalPurchase"].Style.BackColor = Color.LightCoral;
                    //Factura
                    byte invoice = Convert.ToByte(DataGridViewSales.Rows[i].Cells["Invoice"].Value);
                    switch (invoice)
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
                    total1 = total1 + Convert.ToInt32(DataGridViewSales.Rows[i].Cells["Quantity"].Value);
                    total2 = total2 + total;
                    total3 = total3 + (total - totalPurchase);
                }
            }
            LabelTotal1.Text = "TOTAL(Cantidad): " + total1.ToString() + " unidades.";
            LabelTotal2.Text = "TOTAL (Precio x Cantidad): " + total2.ToString() + " GS.";
            LabelTotal3.Text = "GANANCIAS: " + total3.ToString() + " GS.";
        }

        //Modificar o eliminar
        private void DataGridViewSalesInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String cell = "";
                switch(ComboBoxList.SelectedIndex)
                {
                    case 0:
                        cell = DataGridViewSalesInfo.Columns[e.ColumnIndex].Name;
                        break;
                    default:
                        cell = DataGridViewSales.Columns[e.ColumnIndex].Name;
                        break;
                }
                if ((cell == "Delete" || cell == "Delete2") && MessageBox.Show("Desea eliminar este registro?", "ELIMINAR REGISTROS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        newSaleControl = new SaleControl();
                        ProductControl newProductControl = new ProductControl();
                        if (ComboBoxList.SelectedIndex == 0)
                        {
                            DataTable sales = newSaleControl.List("INNER JOIN SALE_INFO si ON si.ID_SALE_INFO = s.FK_ID_SALE_INFO " +
                            "INNER JOIN PRODUCT pro ON s.FK_ID_PRODUCT = pro.ID_PRODUCT WHERE si.ID_SALE_INFO = " + DataGridViewSalesInfo.Rows[e.RowIndex].Cells["InfoID"].Value.ToString());
                            foreach (DataRow row in sales.Rows)
                            {
                                newProductControl = new ProductControl();
                                newProductControl.ModifyQuantity(row.Field<int>(2), " + " + row.Field<int>(5));
                            }
                            newSaleControl = new SaleControl();
                            newSaleControl.DeleteInfo(Convert.ToInt32(DataGridViewSalesInfo.Rows[e.RowIndex].Cells["InfoID"].Value));
                        }
                        else
                        {
                            newProductControl.ModifyQuantity(Convert.ToInt32(DataGridViewSales.Rows[e.RowIndex].Cells["IDProduct"].Value), " + " + Convert.ToInt32(DataGridViewSales.Rows[e.RowIndex].Cells["Quantity"].Value));
                            newSaleControl.Delete(Convert.ToInt32(DataGridViewSales.Rows[e.RowIndex].Cells["ID"].Value));
                        }
                        MessageBox.Show("Registro eliminado con éxito!", "ELIMINAR REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else if ((cell == "Edit" || cell == "Edit2") && MessageBox.Show("Desea modificar este registro?", "MODIFICAR REGISTROS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int id = 0;
                        int id_info = 0;
                        if (ComboBoxList.SelectedIndex == 0)
                        {
                            id_info = Convert.ToInt32(DataGridViewSalesInfo.Rows[e.RowIndex].Cells["InfoID"].Value);
                        }
                        else
                        {
                            id = Convert.ToInt32(DataGridViewSales.Rows[e.RowIndex].Cells["ID"].Value);
                            id_info = Convert.ToInt32(DataGridViewSales.Rows[e.RowIndex].Cells["IDInfo"].Value);
                        }
                        newSaleControl = new SaleControl();
                        DataRow s = newSaleControl.ListInfo("INNER JOIN PERSON pe ON si.FK_ID_PERSON = pe.ID_PERSON WHERE si.ID_SALE_INFO = " + id_info).Rows[0];
                        TransactionInfo newSalesInfo = new TransactionInfo(s.Field<int>("ID_SALE_INFO"), s.Field<int>("FK_ID_PERSON"), 
                            s.Field<String>("date"));
                        GoToSales(id, newSalesInfo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if(cell == "Edit" || cell == "Edit2" || cell == "Delete" || cell == "Delete2")
                    ToListSalesInfo();
            }
        }

        //Contador de filas seleccionadas
        private void DataGridViewSalesInfo_CurrentCellChanged(object sender, EventArgs e)
        {
            int c = 0;
            switch (ComboBoxList.SelectedIndex)
            {
                case 0:
                    c = DataGridViewSalesInfo.SelectedRows.Count;
                    break;
                default:
                    c = DataGridViewSales.SelectedRows.Count;
                    break;
            }
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
            ButtonsEnabled(condition);
            if (c > 50)
            {
                LabelWarning.Visible = true;
            }
            else
            {
                LabelWarning.Visible = false;
            }
        }

        private void ButtonsEnabled(bool b)
        {
            ButtonDelete.Enabled = b;
            switch (b)
            {
                case false:
                    ButtonDelete.BackColor = SystemColors.ControlDarkDark;
                    ButtonDelete.ForeColor = SystemColors.ControlText;
                    break;
                default:
                    ButtonDelete.BackColor = Color.IndianRed;
                    ButtonDelete.ForeColor = Color.Maroon;
                    break;
            }
        }

        //Eliminar varios registros a la vez
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar estos registros?", "ELIMINAR REGISTROS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ProductControl newProductControl;
                    if (ComboBoxList.SelectedIndex == 0)
                    {
                        for (int i = 0; i < DataGridViewSalesInfo.SelectedRows.Count; i++)
                        {
                            newSaleControl = new SaleControl();
                            DataTable sales = newSaleControl.List("INNER JOIN SALE_INFO si ON si.ID_SALE_INFO = s.FK_ID_SALE_INFO " +
                                "INNER JOIN PRODUCT pro ON s.FK_ID_PRODUCT = pro.ID_PRODUCT WHERE si.ID_SALE_INFO = " + DataGridViewSalesInfo.SelectedRows[i].Cells["InfoID"].Value.ToString());
                            foreach (DataRow row in sales.Rows)
                            {
                                newProductControl = new ProductControl();
                                newProductControl.ModifyQuantity(row.Field<int>(2), " + " + row.Field<int>(5));
                            }
                            newSaleControl = new SaleControl();
                            newSaleControl.DeleteInfo(Convert.ToInt32(DataGridViewSalesInfo.SelectedRows[i].Cells["InfoID"].Value));
                        }
                    }
                    else
                    {
                        for (int i = 0; i < DataGridViewSales.SelectedRows.Count; i++)
                        {
                            newSaleControl = new SaleControl();
                            newProductControl = new ProductControl();
                            newProductControl.ModifyQuantity(Convert.ToInt32(DataGridViewSales.SelectedRows[i].Cells["IDProduct"].Value), " + " + Convert.ToInt32(DataGridViewSales.SelectedRows[i].Cells["Quantity"].Value));
                            newSaleControl.Delete(Convert.ToInt32(DataGridViewSales.SelectedRows[i].Cells["ID"].Value));
                        }
                    }
                    MessageBox.Show("Registros eliminados con éxito!", "ELIMINAR REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ToListSalesInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //OTROS MÉTODOS
        //Cambio de los componentes
        //Etiquetas
        //Etiqueta para facturas
        private void LabelInvoice_Click(object sender, EventArgs e)
        {
            switch(LabelInvoice.Text)
            {
                case "S/F":
                    LabelInvoice.Text = "C/F";
                    break;
                case "C/F":
                    LabelInvoice.Text = " F";
                    break;
                default:
                    LabelInvoice.Text = "S/F";
                    break;
            }
            ButtonInvoice.Enabled = (LabelInvoice.Text == "S/F" && ComboBoxList.SelectedIndex == 1);
            ToListSalesInfo();
        }

        private void LabelInvoice_MouseHover(object sender, EventArgs e)
        {
            LabelInvoice.ForeColor = Color.Silver;
        }

        private void LabelInvoice_MouseLeave(object sender, EventArgs e)
        {
            LabelInvoice.ForeColor = SystemColors.ControlText;
        }

        private void LabelInvoice_MouseDown(object sender, MouseEventArgs e)
        {
            LabelInvoice.ForeColor = Color.LightGray;
        }

        private void LabelInvoice_MouseUp(object sender, MouseEventArgs e)
        {
            LabelInvoice.ForeColor = Color.DarkGray;
        }

        //Etiquetas para comparación
        private void LabelEqual_Click(object sender, EventArgs e)
        {
            switch (LabelEqual.Text)
            {
                case "=":
                    LabelEqual.Text = ">";
                    break;
                case ">":
                    LabelEqual.Text = "<";
                    break;
                default:
                    LabelEqual.Text = "=";
                    break;
            }
            ToListSalesInfo();
        }

        private void LabelEqual_MouseHover(object sender, EventArgs e)
        {
            LabelEqual.ForeColor = Color.Silver;
        }

        private void LabelEqual_MouseLeave(object sender, EventArgs e)
        {
            LabelEqual.ForeColor = SystemColors.ControlText;
        }

        private void LabelEqual_MouseDown(object sender, MouseEventArgs e)
        {
            LabelEqual.ForeColor = Color.LightGray;
        }

        private void LabelEqual_MouseUp(object sender, MouseEventArgs e)
        {
            LabelEqual.ForeColor = Color.DarkGray;
        }

        private void LabelEqual2_Click(object sender, EventArgs e)
        {
            switch (LabelEqual2.Text)
            {
                case "=":
                    LabelEqual2.Text = ">";
                    break;
                case ">":
                    LabelEqual2.Text = "<";
                    break;
                default:
                    LabelEqual2.Text = "=";
                    break;
            }
            ToListSalesInfo();
        }

        private void LabelEqual2_MouseHover(object sender, EventArgs e)
        {
            LabelEqual2.ForeColor = Color.Silver;
        }

        private void LabelEqual2_MouseLeave(object sender, EventArgs e)
        {
            LabelEqual2.ForeColor = SystemColors.ControlText;
        }

        private void LabelEqual2_MouseDown(object sender, MouseEventArgs e)
        {
            LabelEqual2.ForeColor = Color.LightGray;
        }

        private void LabelEqual2_MouseUp(object sender, MouseEventArgs e)
        {
            LabelEqual2.ForeColor = Color.DarkGray;
        }

        //Establecer tipo de listado y filtros
        private void ComboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToListSalesInfo();
            ComboBoxProduct.Enabled = QuantityNumeric.Enabled = PriceNumeric.Enabled = TextBoxBarcode.Enabled = (ComboBoxList.SelectedIndex == 1);
            LabelTotal1.Visible = LabelTotal2.Visible = LabelTotal3.Visible = (ComboBoxList.SelectedIndex == 1);
            LabelInvoice.Enabled = LabelEqual.Enabled = LabelEqual2.Enabled = (ComboBoxList.SelectedIndex == 1);
            Label3.Enabled = Label4.Enabled = Label5.Enabled = Label7.Enabled = (ComboBoxList.SelectedIndex == 1);
        }

        private void SinceTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ToListSalesInfo();
        }

        private void UntilTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ToListSalesInfo();
        }

        private void ComboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxProduct.Text != "" && ComboBoxProduct.ValueMember == "ID_PRODUCT")
                ToListSalesInfo();
            if (TextBoxBarcode.Text != "")
                TextBoxBarcode.Clear();
        }

        private void TextBoxBarcode_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxBarcode.Text != "")
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

        private void QuantityNumeric_ValueChanged(object sender, EventArgs e)
        {
            if(QuantityNumeric.Value > 0)
                ToListSalesInfo();
        }

        private void PriceNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (PriceNumeric.Value > 0)
                ToListSalesInfo();
        }

        private void ComboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCustomer.Text != "" && ComboBoxCustomer.ValueMember == "ID_PERSON")
                ToListSalesInfo();
        }

        //Facturar o Cambiar los estados de ventas
        private void ButtonInvoice_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGridViewSales.SelectedRows.Count; i++)
            {
                Transaction newSales = new Transaction(Convert.ToInt32(DataGridViewSales.SelectedRows[i].Cells["ID"].Value), Convert.ToInt32(DataGridViewSales.SelectedRows[i].Cells["IDInfo"].Value),
                                    Convert.ToInt32(DataGridViewSales.SelectedRows[i].Cells["IDProduct"].Value), Convert.ToInt32(DataGridViewSales.SelectedRows[i].Cells["Price"].Value),
                                    Convert.ToInt32(DataGridViewSales.SelectedRows[i].Cells["Quantity"].Value), 1);
                newSaleControl = new SaleControl();
                newSaleControl.Modify(newSales);
            }
            MessageBox.Show("Registros modificados con éxito!", "REGISTRO DE VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clean();
        }

        //Ir a Listar
        private void ButtonRedirect_Click(object sender, EventArgs e)
        {
            GoToSales(0, null);
        }

        //Enviar registro a modificar
        private void GoToSales(int id, TransactionInfo salesInfo)
        {
            SalesUC newSales = new SalesUC();
            Panel1.Controls.Remove(this);
            Panel1.Controls.Add(newSales);
            newSales.Dock = DockStyle.Fill;
            newSales.BringToFront();
            newSales.establish_id(id, salesInfo);
        }

        //Limpiar todo
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            LabelInvoice.Text = " F";
            ComboBoxProduct.SelectedIndex = -1;
            TextBoxBarcode.Clear();
            ComboBoxCustomer.SelectedIndex = -1;
            QuantityNumeric.Value = PriceNumeric.Value = 0;
            LabelEqual.Text = LabelEqual2.Text = "=";
            ButtonInvoice.Enabled = false;
            ComboBoxList.SelectedIndex = 1;
            DateTime today = DateTime.Today;
            SinceTimePicker.Text = today.AddMonths(-1).ToString();
            UntilTimePicker.Value = today;
            ToListSalesInfo();
        }
    }
}