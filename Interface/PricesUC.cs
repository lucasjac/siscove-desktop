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

namespace Interface
{
    public partial class PricesUC : UserControl
    {
        PriceControl newPriceControl;
        Price newPrice;

        //INICIO DEL UC
        public PricesUC()
        {
            InitializeComponent();
        }

        public void establish_id(int id, String name)
        {
            LabelProduct.Text = Convert.ToString(id);
            LabelNameProduct.Text = name;
            ToListPrice(id);
        }

        //DATAGRIDVIEW
        //Listar
        private void ToListPrice(int id)
        {
            try
            {
                newPriceControl = new PriceControl();
                DataGridViewPrice.DataSource = newPriceControl.List("WHERE FK_ID_PRODUCT = " + id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Aplicar estilo al cargar los datos del DataGridView
        private void DataGridViewPrice_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StylePrice();
        }

        //Colorear filas
        private void StylePrice()
        {
            for (int i = 0; i < DataGridViewPrice.Rows.Count; i++)
            {
                //Colorear las filas pares
                if ((i % 2) == 0)
                {
                    DataGridViewPrice.Rows[i].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DataGridViewPrice.Rows[i].Cells[0].Style.BackColor = Color.LightSteelBlue;
                    DataGridViewPrice.Rows[i].Cells[1].Style.BackColor = Color.LightCoral;
                }
            }
        }

        //Modificar o eliminar
        private void DataGridViewPrice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                newPrice = new Price(Convert.ToInt32(DataGridViewPrice.Rows[e.RowIndex].Cells["ID2"].Value), Convert.ToInt32(DataGridViewPrice.Rows[e.RowIndex].Cells["ID3"].Value),
                    Convert.ToDecimal(DataGridViewPrice.Rows[e.RowIndex].Cells["Price"].Value), Convert.ToInt32(DataGridViewPrice.Rows[e.RowIndex].Cells["Quantity"].Value));
                String cell = DataGridViewPrice.Columns[e.ColumnIndex].Name;

                //Editar
                if (cell == "Edit2")
                {
                    LabelID.Text = newPrice.Id.ToString();
                    TextBoxPrice.Text = newPrice.PriceValue.ToString();
                    NumericQuantity.Value = newPrice.Quantity;
                }//Eliminar
                else if (cell == "Delete2" && MessageBox.Show("Desea eliminar este precio?", "ELIMINAR PRECIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        newPriceControl = new PriceControl();
                        newPriceControl.Delete(newPrice.Id);
                        MessageBox.Show("Precio eliminado con éxito!", "ELIMINAR PRECIO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ToListPrice(Convert.ToInt32(LabelProduct.Text));
                        CleanPrice();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Contador de filas seleccionadas
        private void DataGridViewPrice_CurrentCellChanged(object sender, EventArgs e)
        {
            int c = DataGridViewPrice.SelectedRows.Count;
            bool condition = (c > 1) && (c < 51);
            switch (c)
            {
                case 1:
                    LabelSelection2.Text = "Seleccionado: 1";
                    break;
                default:
                    LabelSelection2.Text = "Seleccionados: " + Convert.ToString(c) + ".";
                    break;
            }
            ButtonsEnabled2(condition);
            if (c > 51)
                LabelWarning2.Visible = true;
        }

        private void ButtonsEnabled2(bool b)
        {
            ButtonDeletePrice.Enabled = b;

            switch (b)
            {
                case false:
                    ButtonDeletePrice.BackColor = SystemColors.ControlDarkDark;
                    ButtonDeletePrice.ForeColor = SystemColors.ControlText;
                    break;
                default:
                    ButtonDeletePrice.BackColor = Color.IndianRed;
                    ButtonDeletePrice.ForeColor = Color.Maroon;
                    break;
            }
        }

        //OTROS BOTONES
        //Guardar y Modificar
        private void ButtonSavePrice_Click(object sender, EventArgs e)
        {
            try
            {
                ValidityPrice();
                newPrice = new Price(Convert.ToInt32(LabelID.Text), Convert.ToInt32(LabelProduct.Text), Convert.ToDecimal(TextBoxPrice.Text), Convert.ToInt32(NumericQuantity.Value));
                newPriceControl = new PriceControl();
                String message;
                switch (LabelID.Text)
                {
                    case "0":
                        newPriceControl.Save(newPrice);
                        message = "Precio registrado con éxito!";
                        break;
                    default:
                        newPrice.Id = Convert.ToInt32(LabelID.Text);
                        newPriceControl.Modify(newPrice);
                        message = "Registro modificado con éxito!";
                        break;
                }
                MessageBox.Show(message, "REGISTRO DE PRECIOS DE PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToListPrice(newPrice.IdProduct);
                CleanPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Limpiar todo
        private void ButtonCleanPrice_Click(object sender, EventArgs e)
        {
            CleanPrice();
        }

        //Eliminar varios registros a la vez
        private void ButtonDeletePrice_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar estos precios?", "ELIMINAR PRECIOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < DataGridViewPrice.SelectedRows.Count; i++)
                    {
                        newPrice = new Price();
                        newPriceControl = new PriceControl();
                        newPriceControl.Delete(Convert.ToInt32(DataGridViewPrice.SelectedRows[i].Cells["ID2"].Value));
                    }
                    MessageBox.Show("Precios eliminados con éxito!", "ELIMINAR NÚMEROS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ToListPrice(Convert.ToInt32(LabelProduct.Text));
                    CleanPrice();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //OTROS MÉTODOS
        //Vaciar cajas de texto, comboboxes, etc.
        private void CleanPrice()
        {
            LabelID.Text = "0";
            TextBoxPrice.Clear();
            NumericQuantity.Value = 1;
        }

        //Validar nombre
        private void ValidityPrice()
        {
            if (TextBoxPrice.Text.Trim().Length == 0)
            {
                throw new Exception("El precio no fue establecido!");
            }
        }

        //Botón volver
        private void PictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PictureBoxBack_MouseHover(object sender, EventArgs e)
        {
            PictureBoxBack.BackgroundImage = Properties.Resources.Back3;
        }

        private void PictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxBack.BackgroundImage = Properties.Resources.Back1;
        }

        private void PictureBoxBack_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBoxBack.BackgroundImage = Properties.Resources.Back2;
        }

        private void PictureBoxBack_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBoxBack.BackgroundImage = Properties.Resources.Back3;
        }
    }
}
