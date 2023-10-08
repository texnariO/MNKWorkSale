using MNKWorkSale.Fragments.EMEX;
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
    public partial class EmexUserControl : UserControl
    {
        public EmexUserControl()
        {
            InitializeComponent();
        }

        public delegate void EmexUserControlButtonClickEventHandler(object sender, UserControl userControl);
        public event EmexUserControlButtonClickEventHandler EmexUserControlButtonClickEvent;

        private void RaiseButtonClickEvent(UserControl userControl)
        {
            EmexUserControlButtonClickEvent?.Invoke(this, userControl);
        }

        private void FragmentsEmex_ButtonsClickEvent(UserControl userControl)
        {
            RaiseButtonClickEvent(userControl);
        }


        private void btnFileCutOrder_Click(object sender, EventArgs e)
        {
            EmexUserControlButtonClickEvent?.Invoke(this,new FragmentCutFileOrdersEMEX());
        }

        private void btnCreateFileSpecyfikacja_Click(object sender, EventArgs e)
        {
            FragmentsEmex_ButtonsClickEvent(new FragmentCreateFileSpecyficationEMEX());
        }

        private void btnCreateFileForOptima_Click(object sender, EventArgs e)
        {
            FragmentsEmex_ButtonsClickEvent(new FragmentFileOptimaClientEMEX());
        }
    }
}
