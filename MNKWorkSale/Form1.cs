using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNKWorkSale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainFragmentUserControl mainFragment = new MainFragmentUserControl();
            ShowUserControlFragment(mainFragment);
        }

        private void ShowUserControlFragment(UserControl userControl)
        {
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }
    }
}
