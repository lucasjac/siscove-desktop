using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //BOTONES
        //Botón de Compras
        private void PurchaseButton_MouseHover(object sender, EventArgs e)
        {
            PurchaseButton.BackgroundImage = Properties.Resources.Purchases3;
        }

        private void PurchaseButton_MouseLeave(object sender, EventArgs e)
        {
            PurchaseButton.BackgroundImage = Properties.Resources.Purchases1;
        }

        private void PurchaseButton_MouseDown(object sender, MouseEventArgs e)
        {
            PurchaseButton.BackgroundImage = Properties.Resources.Purchases2;
        }

        private void PurchaseButton_MouseUp(object sender, MouseEventArgs e)
        {
            PurchaseButton.BackgroundImage = Properties.Resources.Purchases3;
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            if (!PanelUC.Controls.Contains(PurchasesUC.instantiate))
            {
                PanelUC.Controls.Add(PurchasesUC.instantiate);
                PurchasesUC.instantiate.Dock = DockStyle.Fill;
                PurchasesUC.instantiate.BringToFront();
            }
            else
            {
                PurchasesUC.instantiate.BringToFront();
            }
        }

        //Botón de Ventas
        private void SaleButton_MouseHover(object sender, EventArgs e)
        {
            SaleButton.BackgroundImage = Properties.Resources.Sales3;
        }

        private void SaleButton_MouseLeave(object sender, EventArgs e)
        {
            SaleButton.BackgroundImage = Properties.Resources.Sales1;
        }

        private void SaleButton_MouseDown(object sender, MouseEventArgs e)
        {
            SaleButton.BackgroundImage = Properties.Resources.Sales2;
        }

        private void SaleButton_MouseUp(object sender, MouseEventArgs e)
        {
            SaleButton.BackgroundImage = Properties.Resources.Sales3;
        }

        private void SaleButton_Click(object sender, EventArgs e)
        {
            if (!PanelUC.Controls.Contains(SalesUC.instantiate))
            {
                PanelUC.Controls.Add(SalesUC.instantiate);
                SalesUC.instantiate.Dock = DockStyle.Fill;
                SalesUC.instantiate.BringToFront();
            }
            else
            {
                SalesUC.instantiate.BringToFront();
            }
        }

        //Botón de Stock
        private void StockButton_Click(object sender, EventArgs e)
        {
            if (!PanelUC.Controls.Contains(StockUC.instantiate))
            {
                PanelUC.Controls.Add(StockUC.instantiate);
                StockUC.instantiate.Dock = DockStyle.Fill;
                StockUC.instantiate.BringToFront();
            }
            else
            {
                StockUC.instantiate.BringToFront();
            }
        }

        private void StockButton_MouseHover(object sender, EventArgs e)
        {
            StockButton.BackgroundImage = Properties.Resources.Stock3;
        }

        private void StockButton_MouseLeave(object sender, EventArgs e)
        {
            StockButton.BackgroundImage = Properties.Resources.Stock1;
        }

        private void StockButton_MouseDown(object sender, MouseEventArgs e)
        {
            StockButton.BackgroundImage = Properties.Resources.Stock2;
        }

        private void StockButton_MouseUp(object sender, MouseEventArgs e)
        {
            StockButton.BackgroundImage = Properties.Resources.Stock3;
        }

        //Botón de Unidades
        private void UnityButton_Click(object sender, EventArgs e)
        {
            if (!PanelUC.Controls.Contains(UnityUC.instantiate))
            {
                PanelUC.Controls.Add(UnityUC.instantiate);
                UnityUC.instantiate.Dock = DockStyle.Fill;
                UnityUC.instantiate.BringToFront();
            }
            else
            {
                UnityUC.instantiate.BringToFront();
            }
        }

        private void UnityButton_MouseHover(object sender, EventArgs e)
        {
            UnityButton.BackgroundImage = Properties.Resources.Unity3;
        }

        private void UnityButton_MouseLeave(object sender, EventArgs e)
        {
            UnityButton.BackgroundImage = Properties.Resources.Unity1;
        }

        private void UnityButton_MouseDown(object sender, MouseEventArgs e)
        {
            UnityButton.BackgroundImage = Properties.Resources.Unity2;
        }

        private void UnityButton_MouseUp(object sender, MouseEventArgs e)
        {
            UnityButton.BackgroundImage = Properties.Resources.Unity3;
        }

        //Botón de Clientes
        private void CustomerButton_MouseHover(object sender, EventArgs e)
        {
            CustomerButton.BackgroundImage = Properties.Resources.Customers3;
        }

        private void CustomerButton_MouseLeave(object sender, EventArgs e)
        {
            CustomerButton.BackgroundImage = Properties.Resources.Customers1;
        }

        private void CustomerButton_MouseDown(object sender, MouseEventArgs e)
        {
            CustomerButton.BackgroundImage = Properties.Resources.Customers2;
        }

        private void CustomerButton_MouseUp(object sender, MouseEventArgs e)
        {
            CustomerButton.BackgroundImage = Properties.Resources.Customers3;
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            PanelUC.Controls.Clear();
            if (!PanelUC.Controls.Contains(CustomersUC.instantiate))
            {
                PanelUC.Controls.Add(CustomersUC.instantiate);
                CustomersUC.instantiate.Dock = DockStyle.Fill;
                CustomersUC.instantiate.BringToFront();
            }
            else
            {
                CustomersUC.instantiate.BringToFront();
            }
        }

        //Botón de Distribuidoras
        private void DistributorButton_MouseHover(object sender, EventArgs e)
        {
            DistributorButton.BackgroundImage = Properties.Resources.Distributors3;
        }

        private void DistributorButton_MouseLeave(object sender, EventArgs e)
        {
            DistributorButton.BackgroundImage = Properties.Resources.Distributors1;
        }

        private void DistributorButton_MouseDown(object sender, MouseEventArgs e)
        {
            DistributorButton.BackgroundImage = Properties.Resources.Distributors2;
        }

        private void DistributorButton_MouseUp(object sender, MouseEventArgs e)
        {
            DistributorButton.BackgroundImage = Properties.Resources.Distributors3;
        }

        private void DistributorButton_Click(object sender, EventArgs e)
        {
            PanelUC.Controls.Clear();
            if (!PanelUC.Controls.Contains(DistributorsUC.instantiate))
            {
                PanelUC.Controls.Add(DistributorsUC.instantiate);
                DistributorsUC.instantiate.Dock = DockStyle.Fill;
                DistributorsUC.instantiate.BringToFront();
            }
            else
            {
                DistributorsUC.instantiate.BringToFront();
            }
        }

        //Botón de Salir
        private void ExitButton_MouseHover(object sender, EventArgs e)
        {
            ExitButton.BackgroundImage = Properties.Resources.Exit3;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackgroundImage = Properties.Resources.Exit1;
        }

        private void ExitButton_MouseDown(object sender, MouseEventArgs e)
        {
            ExitButton.BackgroundImage = Properties.Resources.Exit2;
        }

        private void ExitButton_MouseUp(object sender, MouseEventArgs e)
        {
            ExitButton.BackgroundImage = Properties.Resources.Exit3;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botón de Minimizar
        private void MinimizeButton_MouseHover(object sender, EventArgs e)
        {
            MinimizeButton.BackgroundImage = Properties.Resources.Minimize3;
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.BackgroundImage = Properties.Resources.Minimize1;
        }

        private void MinimizeButton_MouseDown(object sender, MouseEventArgs e)
        {
            MinimizeButton.BackgroundImage = Properties.Resources.Minimize2;
        }

        private void MinimizeButton_MouseUp(object sender, MouseEventArgs e)
        {
            MinimizeButton.BackgroundImage = Properties.Resources.Minimize3;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //ESCALABILIDAD DE COMPONENTES
        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                PictureBox[] buttons = {PurchaseButton, SaleButton, StockButton, UnityButton, CustomerButton, 
                    DistributorButton, ExitButton, MinimizeButton};
                Size sizebutton = new Size(calculateSize(97, "Width"), calculateSize(30, "Heigth"));
                Point location;
                int[] aux = { 2, 1, 1, 1, 0, 0, 650, 632, 74};
                for(int i = 0; i < 8; i++)
                {
                    if(i < 6)
                    {
                        location = new Point(0, calculateSize(aux[8], "Height") + aux[i]);
                        aux[8] += 30;
                    } else
                    {
                        sizebutton = new Size(calculateSize(13, "Width"), calculateSize(13, "Width"));
                        location = new Point(calculateSize(aux[i], "Width"), calculateSize(5, "Height"));
                    }
                    buttons[i].Size = sizebutton;
                    buttons[i].Location = location;
                }
                //Control de Usuario
                PanelUC.Size = new Size(calculateSize(546, "Width"), calculateSize(307, "Height"));
                PanelUC.Location = new Point(calculateSize(98, "Width"), calculateSize(23, "Height"));
            }
        }

        //Calcular tamaños y ubicaciones reescaladas
        private int calculateSize(int componentvalue, string size)
        {
            int actualvalue, previousvalue;
            switch(size)
            {
                case "Width":
                    actualvalue = this.Width;
                    previousvalue = 668;
                    break;
                default:
                    actualvalue = this.Height;
                    previousvalue = 353;
                    break;
            }
            int res = (componentvalue * actualvalue) / previousvalue;
            return res;
        }
    }
}
