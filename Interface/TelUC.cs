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
    public partial class TelUC : UserControl
    {
        TelControl newTelControl;
        Contact newTels;

        //INICIO DEL UC
        public TelUC()
        {
            InitializeComponent();
        }

        private void TelUC_Load(object sender, EventArgs e)
        {
            //ToListTel();
        }

        public void establish_id(int id, String name, String cust_dist)
        {
            LabelCustomer.Text = Convert.ToString(id);
            LabelNameCustomer.Text = name;
            Label_cust_dist.Text = cust_dist;
            ToListTel(id);
        }

        //DATAGRIDVIEW
        //Listar
        private void ToListTel(int id)
        {
            try
            {
                newTelControl = new TelControl();
                DataGridViewTel.DataSource = newTelControl.List("WHERE FK_ID_PERSON = " + id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Aplicar estilo al cargar los datos del DataGridView
        private void DataGridViewTel_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleTel();
        }

        //Colorear filas
        private void StyleTel()
        {
            for (int i = 0; i < DataGridViewTel.Rows.Count; i++)
            {
                //Colorear las filas pares
                if ((i % 2) == 0)
                {
                    DataGridViewTel.Rows[i].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    DataGridViewTel.Rows[i].Cells[0].Style.BackColor = Color.LightSteelBlue;
                    DataGridViewTel.Rows[i].Cells[1].Style.BackColor = Color.LightCoral;
                }
            }
        }

        //Modificar o eliminar
        private void DataGridViewTel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                newTels = new Contact(Convert.ToInt32(DataGridViewTel.Rows[e.RowIndex].Cells["ID2"].Value), Convert.ToInt32(DataGridViewTel.Rows[e.RowIndex].Cells["ID3"].Value),
                    DataGridViewTel.Rows[e.RowIndex].Cells["Info"].Value.ToString());
                String cell = DataGridViewTel.Columns[e.ColumnIndex].Name;

                //Editar
                if (cell == "Edit2")
                {
                    LabelIDTel.Text = newTels.Id.ToString();
                    TextBoxTel.Text = newTels.Description;
                }//Eliminar
                else if (cell == "Delete2" && MessageBox.Show("Desea eliminar este número?", "ELIMINAR NÚMEROS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        newTelControl.Delete(newTels.Id);
                        MessageBox.Show("Número eliminado con éxito!", "ELIMINAR NÚMEROS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ToListTel(Convert.ToInt32(LabelCustomer.Text));
                        CleanTel();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Contador de filas seleccionadas
        private void DataGridViewTel_CurrentCellChanged(object sender, EventArgs e)
        {
            int c = DataGridViewTel.SelectedRows.Count;
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
            newTelControl = new TelControl();
            DataGridViewTel.DataSource = newTelControl.List("WHERE FK_ID_PERSON = " + LabelCustomer.Text + " AND info LIKE '%" + TextBoxSearch2.Text + "%'");
            StyleTel();
            CleanTel();
        }

        //OTROS BOTONES
        //Guardar y Modificar
        private void ButtonSaveTel_Click(object sender, EventArgs e)
        {
            try
            {
                ValidityTel();
                newTels = new Contact(Convert.ToInt32(LabelCustomer.Text), TextBoxTel.Text);
                newTelControl = new TelControl();
                String message;
                switch (LabelIDTel.Text)
                {
                    case "0":
                        newTelControl.Save(newTels);
                        message = "Número registrado con éxito!";
                        break;
                    default:
                        newTels.Id = Convert.ToInt16(LabelIDTel.Text);
                        newTelControl.Modify(newTels);
                        message = "Registro modificado con éxito!";
                        break;
                }
                MessageBox.Show(message, "REGISTRO DE TELÉFONOS DE CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToListTel(newTels.IdPerson);
                CleanTel();
                TextBoxSearch2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Limpiar todo
        private void ButtonCleanTel_Click(object sender, EventArgs e)
        {
            CleanTel();
        }

        //Eliminar varios registros a la vez
        private void ButtonDeleteTel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar a estos números?", "ELIMINAR NÚMEROS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < DataGridViewTel.SelectedRows.Count; i++)
                    {
                        newTels = new Contact();
                        newTelControl = new TelControl();
                        newTelControl.Delete(Convert.ToInt32(DataGridViewTel.SelectedRows[i].Cells["ID2"].Value));
                    }
                    MessageBox.Show("Números eliminados con éxito!", "ELIMINAR NÚMEROS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ToListTel(Convert.ToInt32(LabelCustomer.Text));
                    CleanTel();
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
        private void CleanTel()
        {
            LabelIDTel.Text = "0";
            TextBoxTel.Clear();
        }

        //Validar nombre
        private void ValidityTel()
        {
            if (TextBoxTel.Text.Trim().Length == 0)
            {
                throw new Exception("El número no fue establecido!");
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
