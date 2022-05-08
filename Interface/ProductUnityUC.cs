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
    public partial class ProductUnityUC : UserControl
    {
        /*0: PRODUCT
          1: UNITY*/ 
        UnityProductControl newDualControl;
        UnityProduct newDual;

        //INICIO DEL UC
        public ProductUnityUC()
        {
            InitializeComponent();
        }

        public void establish_id(int id, String description, String uni_prod)
        {
            LabelIDUnityProduct.Text = Convert.ToString(id);
            LabelDescription.Text = description;
            LabelUnityProduct.Text = uni_prod;
            ToListDual();
            ToListUnityProduct("");
            switch(uni_prod)
            {
                case "0":
                    LabelChange.Text = "Unidad";
                    break;
                default:
                    LabelChange.Text = "Producto";
                    break;
            }
        }

        //DATAGRIDVIEW
        //Listar
        private void ToListDual()
        {
            try
            {
                string condition = "";
                switch(LabelUnityProduct.Text)
                {
                    case "0":
                        condition = "u.name FROM PRODUCT_UNITY up INNER JOIN UNITY u ON up.FK_ID_UNITY = u.ID_UNITY WHERE up.FK_ID_PRODUCT = " + LabelIDUnityProduct.Text;
                        break;
                    default:
                        condition = "p.description FROM PRODUCT_UNITY up INNER JOIN PRODUCT p ON up.FK_ID_PRODUCT = p.ID_PRODUCT WHERE up.FK_ID_UNITY = " + LabelIDUnityProduct.Text;
                        break;
                }
                newDualControl = new UnityProductControl();
                DataGridViewDual.DataSource = newDualControl.List(condition);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToListUnityProduct(string where)
        {
            try
            {
                string[] condition = { "", "" };
                switch (LabelUnityProduct.Text)
                {
                    case "0":
                        UnityControl UnityToList = new UnityControl();
                        ComboBoxUnityProduct.DataSource = UnityToList.List(where);
                        condition[0] = "name";
                        condition[1] = "ID_UNITY";
                        break;
                    default:
                        ProductControl ProductToList = new ProductControl();
                        ComboBoxUnityProduct.DataSource = ProductToList.List(where);
                        condition[0] = "description";
                        condition[1] = "ID_PRODUCT";
                        break;
                }
                ComboBoxUnityProduct.DisplayMember = condition[0];
                ComboBoxUnityProduct.ValueMember = condition[1];
                ComboBoxUnityProduct.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Aplicar estilo al cargar los datos del DataGridView
        private void DataGridViewDual_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleDual();
        }

        //Colorear filas
        private void StyleDual()
        {
            for (int i = 0; i < DataGridViewDual.Rows.Count; i++)
            {
                //Colorear las filas pares
                if ((i % 2) == 0)
                {
                    DataGridViewDual.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                    DataGridViewDual.Rows[i].Cells[2].Style.BackColor = Color.LightSteelBlue;
                    DataGridViewDual.Rows[i].Cells[3].Style.BackColor = Color.LightCoral;
                }
                if (LabelUnityProduct.Text == "0")
                {
                    DataGridViewDual.Rows[i].Cells["Description"].Value = DataGridViewDual.Rows[i].Cells["DescriptionUnity"].Value;
                }
                else
                {
                    DataGridViewDual.Rows[i].Cells["Description"].Value = DataGridViewDual.Rows[i].Cells["DescriptionProduct"].Value;
                }
            }
        }

        //Modificar o eliminar
        private void DataGridViewDual_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                newDual = new UnityProduct(Convert.ToInt32(DataGridViewDual.Rows[e.RowIndex].Cells["ID"].Value), Convert.ToInt32(DataGridViewDual.Rows[e.RowIndex].Cells["ID2"].Value),
                    Convert.ToInt32(DataGridViewDual.Rows[e.RowIndex].Cells["ID3"].Value));
                String cell = DataGridViewDual.Columns[e.ColumnIndex].Name;

                //Editar
                if (cell == "Edit2")
                {
                    int id;
                    LabelID.Text = newDual.Id.ToString();
                    switch(LabelUnityProduct.Text)
                    {
                        case "0":
                            id = newDual.IdUnity;
                            break;
                        default:
                            id = newDual.IdProduct;
                            break;
                    }
                    ComboBoxUnityProduct.SelectedValue = id;
                }//Eliminar
                else if (cell == "Delete2" && MessageBox.Show("Desea eliminar este vínculo?", "ELIMINAR REGISTROS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        newDualControl.Delete(newDual.Id);
                        MessageBox.Show("Vínculo eliminado con éxito!", "ELIMINAR REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ToListDual();
                        CleanDual();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Contador de filas seleccionadas
        private void DataGridViewDual_CurrentCellChanged(object sender, EventArgs e)
        {
            int c = DataGridViewDual.SelectedRows.Count;
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
            ButtonDeleteTel.Enabled = b;

            switch (b)
            {
                case false:
                    ButtonDeleteTel.BackColor = SystemColors.ControlDarkDark;
                    ButtonDeleteTel.ForeColor = SystemColors.ControlText;
                    break;
                default:
                    ButtonDeleteTel.BackColor = Color.IndianRed;
                    ButtonDeleteTel.ForeColor = Color.Maroon;
                    break;
            }
        }

        //BÚSQUEDA
        private void TextBoxSearch2_TextChanged(object sender, EventArgs e)
        {
            newDualControl = new UnityProductControl();
            string condition;
            switch (LabelUnityProduct.Text)
            {
                case "0":
                    condition = "u.name FROM PRODUCT_UNITY up INNER JOIN UNITY u ON up.FK_ID_UNITY = u.ID_UNITY WHERE up.FK_ID_PRODUCT = " + LabelIDUnityProduct.Text + " AND u.name LIKE '%" + TextBoxSearch2.Text + "%'";
                    break;
                default:
                    condition = "p.description FROM PRODUCT_UNITY up INNER JOIN PRODUCT p ON up.FK_ID_PRODUCT = p.ID_PRODUCT WHERE up.FK_ID_UNITY = " + LabelIDUnityProduct.Text + " AND p.description LIKE '%" + TextBoxSearch2.Text + "%'";
                    break;
            }
            DataGridViewDual.DataSource = newDualControl.List(condition);
            StyleDual();
            CleanDual();
        }

        //OTROS BOTONES
        //Guardar y Modificar
        private void ButtonSaveDual_Click(object sender, EventArgs e)
        {
            try
            {
                ValidityDual();
                int id1, id2;
                switch(LabelUnityProduct.Text)
                {
                    case "0":
                        id1 = Convert.ToInt32(LabelIDUnityProduct.Text);
                        id2 = Convert.ToInt32(ComboBoxUnityProduct.SelectedValue);
                        break;
                    default:
                        id1 = Convert.ToInt32(ComboBoxUnityProduct.SelectedValue);
                        id2 = Convert.ToInt32(LabelIDUnityProduct.Text);
                        break;
                }
                newDual = new UnityProduct(id1, id2);
                newDualControl = new UnityProductControl();
                String message;
                switch (LabelID.Text)
                {
                    case "0":
                        newDualControl.Save(newDual);
                        message = "Registrado con éxito!";
                        break;
                    default:
                        newDual.Id = Convert.ToInt32(LabelID.Text);
                        newDualControl.Modify(newDual);
                        message = "Registro modificado con éxito!";
                        break;
                }
                MessageBox.Show(message, "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToListDual();
                CleanDual();
                TextBoxSearch2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Limpiar todo
        private void ButtonCleanDual_Click(object sender, EventArgs e)
        {
            CleanDual();
        }

        //Eliminar varios registros a la vez
        private void ButtonDeleteTel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar estos registros?", "ELIMINAR REGISTROS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < DataGridViewDual.SelectedRows.Count; i++)
                    {
                        newDual = new UnityProduct();
                        newDualControl = new UnityProductControl();
                        newDualControl.Delete(Convert.ToInt32(DataGridViewDual.SelectedRows[i].Cells["ID"].Value));
                    }
                    MessageBox.Show("Vínculos eliminados con éxito!", "ELIMINAR REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ToListDual();
                    CleanDual();
                    TextBoxSearch2.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //OTROS MÉTODOS
        //Vaciar cajas de texto, comboboxes, etc.
        private void CleanDual()
        {
            LabelID.Text = "0";
            ComboBoxUnityProduct.SelectedIndex = -1;
        }

        //Validar nombre
        private void ValidityDual()
        {
            string[] message = { "", "", "" };
            switch (LabelUnityProduct.Text)
            {
                case "0":
                    message[0] = "La unidad no fue establecida!";
                    message[1] = "ID3";
                    message[2] = "Esta unidad ya fue asociada a este producto!";
                    break;
                default:
                    message[0] = "El producto no fue establecido!";
                    message[1] = "ID2";
                    message[2] = "Este producto ya fue asociado a esta unidad!";
                    break;
            }

            if (ComboBoxUnityProduct.SelectedIndex == -1)
            {
                throw new Exception(message[0]);
            }

            for(int i = 0; i < DataGridViewDual.RowCount; i++)
            {
                if (Convert.ToInt16(ComboBoxUnityProduct.SelectedValue) == Convert.ToInt16(DataGridViewDual.Rows[i].Cells[message[1]].Value))
                {
                    throw new Exception(message[2]);
                }
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
