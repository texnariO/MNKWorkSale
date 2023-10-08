using MNKWorkSale.Fragments;
using MNKWorkSale.Fragments.EMEX;
using MNKWorkSale.Fragments.FAVORITE;
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
    public partial class Main : Form
    {

        public MainFragmentUserControl mainFragment = new MainFragmentUserControl();

        public Main()
        {

            InitializeComponent();
            InitializationEventAttribute();
                ShowUserControlFragment(this, mainFragment);
        }
        private void InitializationEventAttribute()
        {
            mainFragment.ButtonClickEvent += new MainFragmentUserControl.ButtonClickEventHandler(MainFragment_ButtonClickEvent);

        }

        private void MainFragment_ButtonClickEvent(object sender, UserControl userControl)
        {
            InitializationEventAttribute();
            ShowUserControlFragment(this,userControl);
        }


        private void ShowUserControlFragment(object sender,UserControl userControl)
        {
            
            //InitializationEventAttribute();
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }
    }
}
