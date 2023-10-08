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

namespace MNKWorkSale.Fragments
{
    public partial class FavoriteUserControl : UserControl
    {
        public FavoriteUserControl()
        {
            InitializeComponent();
        }
        public delegate void FavoriteUserControlButtonClickEventHandler(object sender, UserControl userControl);
        public event FavoriteUserControlButtonClickEventHandler FavoriteUserControlButtonClickEvent;

        private void RaiseButtonClickEvent(UserControl userControl)
        {
            if (FavoriteUserControlButtonClickEvent != null)
            {
                FavoriteUserControlButtonClickEvent(this, userControl);
            }
        }

        private void FragmentsFavorite_ButtonsClickEvent(object sender, UserControl userControl)
        {
            RaiseButtonClickEvent(userControl);
        }
        private void btnCreateFileForOptima_Click(object sender, EventArgs e)
        {
            FragmentsFavorite_ButtonsClickEvent(sender, new FragmentFileOptimaClientFavorite());
        }

        private void btnCreateFileSpecyfikacja_Click(object sender, EventArgs e)
        {
            FragmentsFavorite_ButtonsClickEvent(sender, new FragmentCreateFileSpecyficationFavorite());
        }

        private void btnCutFile_Click(object sender, EventArgs e)
        {
            FragmentsFavorite_ButtonsClickEvent(sender, new FragmentCutFileOrderFavorite());
        }
    }
}
