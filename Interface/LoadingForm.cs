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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_SizeChanged(object sender, EventArgs e)
        {
            PictureBoxLoading.Width = (247 * this.Width - 2672) / 668;
            PictureBoxLoading.Height = (198 * this.Height + 1412) / 353;
            int x_point = (246 * this.Width + 2672) / 668;
            int y_point = (78 * this.Height) / 353;
            PictureBoxLoading.Location = new Point(x_point, y_point);
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            PictureBoxLoading.Load("Loading.gif");
        }
    }
}
