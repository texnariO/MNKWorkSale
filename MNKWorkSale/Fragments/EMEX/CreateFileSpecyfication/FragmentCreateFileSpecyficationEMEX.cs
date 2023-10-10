using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MNKWorkSale.Utiliteses;

namespace MNKWorkSale.Fragments.EMEX
{
    public partial class FragmentCreateFileSpecyficationEMEX : UserControl
    {
        private string FileNameMaxi;
        private string FileNameWeightFromStorage;
        private string FileNameCods;
        private Utilitieses utiliteses = new Utilitieses();
        public FragmentCreateFileSpecyficationEMEX()
        {
            InitializeComponent();
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    ctrl.TextChanged += utiliteses.textBox_TextChanged;
                }
            }
            //checkBox1.Click += utiliteses.checkBox_Clicked;
            
        }

        private void buttonChooseFileFormSite_Click(object sender, EventArgs e)
        {
            utiliteses.setLabelNormal(this.labelError);
            string FileNameTeamp = utiliteses.openFileToRead();
            if (FileNameTeamp == "")
            {
                utiliteses.setLabelError(this.labelError, "Не вибрано файл з Максі");
            }
            else FileNameMaxi = FileNameTeamp;
        }

        private void buttonChFile_Click(object sender, EventArgs e)
        {
            utiliteses.setLabelNormal(this.labelError);
            string FileNameTeamp = utiliteses.openFileToRead();
            if (FileNameTeamp == "")
            {
                utiliteses.setLabelError(this.labelError, "Не вибрано файл з Вагами склада");
            }
            else FileNameWeightFromStorage = FileNameTeamp;
        }

        private void buttonChooseFileFromCods_Click(object sender, EventArgs e)
        {
            utiliteses.setLabelNormal(this.labelError);
            string FileNameTeamp = utiliteses.openFileToRead();
            if (FileNameTeamp == "")
            {
                utiliteses.setLabelError(this.labelError, "Не вибрано файл з Кодами");
            }
            else FileNameCods = FileNameTeamp;
        }

        private void buttonStartWork_Click(object sender, EventArgs e)
        {

        }
    }
}
