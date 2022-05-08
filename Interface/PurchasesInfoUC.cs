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
    public partial class PurchasesInfoUC : UserControl
    {
        //CustomerControl newCustomerControl;
        Transaction newSales;
        private static PurchasesInfoUC instance;
        LoadingForm newloading = new LoadingForm();

        //INICIO DEL UC
        public PurchasesInfoUC()
        {
            InitializeComponent();
        }

        public static PurchasesInfoUC instantiate
        {
            get
            {
                if (instance == null)
                {
                    instance = new PurchasesInfoUC();
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
            for (int i = 0; i < DataGridViewPurchasesInfo.Rows.Count; i++)
            {
                //Colorear las filas pares
                if ((i % 2) == 0)
                {
                    DataGridViewPurchasesInfo.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                    DataGridViewPurchasesInfo.Rows[i].Cells[0].Style.BackColor = Color.LightSteelBlue;
                    DataGridViewPurchasesInfo.Rows[i].Cells[1].Style.BackColor = Color.LightCoral;
                } else
                {
                    DataGridViewPurchasesInfo.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    DataGridViewPurchasesInfo.Rows[i].Cells[0].Style.BackColor = Color.CornflowerBlue;
                    DataGridViewPurchasesInfo.Rows[i].Cells[1].Style.BackColor = Color.IndianRed;
                }

                //Total
                int total = Convert.ToInt16(DataGridViewPurchasesInfo.Rows[i].Cells["Price"].Value) * Convert.ToInt16(DataGridViewPurchasesInfo.Rows[i].Cells["Quantity"].Value);
                DataGridViewPurchasesInfo.Rows[i].Cells["Total"].Value = total.ToString();

                //Factura
                bool invoice = Convert.ToBoolean(DataGridViewPurchasesInfo.Rows[i].Cells["Invoice"].Value);
                switch(invoice)
                {
                    case true:
                        DataGridViewPurchasesInfo.Rows[i].Cells["F"].Value = "×";
                        //DataGridViewSales.Rows[i].Cells["F"].Style = ;
                        break;
                    default:
                        DataGridViewPurchasesInfo.Rows[i].Cells["F"].Value = "✓";
                        //DataGridViewSales.Rows[i].Cells["F"].Style = ;
                        break;
                }
            }
        }

        //Habilitar DataGrid
        private void SalesEnabled(Boolean enable)
        {
            DataGridViewPurchasesInfo.Enabled = enable;
            switch(enable)
            {
                case false:
                    for (int i = 0; i < DataGridViewPurchasesInfo.Rows.Count; i++)
                    {
                        DataGridViewPurchasesInfo.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
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

        }

        //Contador de filas seleccionadas
        private void DataGridViewSales_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void ButtonsEnabled1(bool b)
        {
            /*ButtonEdit.Enabled = ButtonDelete.Enabled = b;
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
            }*/
        }

        //Añadir compra
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            /*Validate();
            this.DataGridViewSalesInfo.Rows.Add("0", "0", ComboBoxProduct.ValueMember.ToString(), ComboBoxProduct.Text, ComboBoxPrice.Text, 
                NumericQuantity.Value.ToString(), "", CheckBoxF.Checked, "");
            Clean(1);
            Style();*/
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
            /*LabelID.Text = "0";
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
            }*/
        }

        //Validar nombre
        private void Validity()
        {
            /*if (ComboBoxProduct.Text.Trim().Length == 0)
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
            }*/
        }

        //Cambiar estado de venta
        private void LabelSold_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}