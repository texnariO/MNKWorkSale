using MNKWorkSale.Fragments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNKWorkSale.Fragments
{
    public partial class MainFragmentUserControl : UserControl
    {
        public EmexUserControl emexUserControl = new EmexUserControl();
        public FavoriteUserControl favoriteUserControl = new FavoriteUserControl();
        public delegate void ButtonClickEventHandler(object sender, UserControl userControl);
        public event ButtonClickEventHandler ButtonClickEvent;

        private void RaiseButtonClickEvent(UserControl userControl)
        {
            if (ButtonClickEvent != null)
            {
                ButtonClickEvent(this, userControl);
            }
        }

        public MainFragmentUserControl()
        {
            InitializeComponent();
            emexUserControl.EmexUserControlButtonClickEvent += new EmexUserControl.EmexUserControlButtonClickEventHandler(Fragments_ButtonClickEvent);
            favoriteUserControl.FavoriteUserControlButtonClickEvent += new FavoriteUserControl.FavoriteUserControlButtonClickEventHandler(Fragments_ButtonClickEvent);
        }

        private void Fragments_ButtonClickEvent(object sender, UserControl userControl)
        {
           ShowUserControlFragmentWithOptionWork(userControl);
        }

        private void buttonFirstClient_Click(object sender, EventArgs e)
        {
            this.buttonSecondClient.BackColor = SystemColors.Control;
            this.buttonFirstClient.BackColor = Color.Green;
            ShowUserControlFragmentWithOptionWork(emexUserControl);
        }
    
        private void buttonSecondClient_Click(object sender, EventArgs e)
        {
            this.buttonFirstClient.BackColor = SystemColors.Control;
            this.buttonSecondClient.BackColor = Color.Green;
            ShowUserControlFragmentWithOptionWork(favoriteUserControl);
        }
        private void ShowUserControlFragmentWithOptionWork(UserControl userControl)
        {
            panelMainFragment.Controls.Clear();
            panelMainFragment.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }


    }
}
