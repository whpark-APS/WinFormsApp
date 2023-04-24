using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class SizeCtrl : UserControl
    {
        public SizeCtrl()
        {
            InitializeComponent();
        }

        private void SizeCtrl_SizeChanged(object sender, EventArgs e)
        {
            lblSize.Text = $"({Size.Width}, {Size.Height})";
        }
    }
}
