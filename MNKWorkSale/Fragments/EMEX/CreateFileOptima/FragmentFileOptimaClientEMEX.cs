using MNKWorkSale.Fragments.EMEX.CreateFileOptima;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNKWorkSale.Fragments.EMEX
{
    public partial class FragmentFileOptimaClientEMEX : UserControl
    {
        private string FileName;
        private Utilitieses utilitieses = new Utilitieses();
        private CoreCreateFileOptimaClientEmex logicWorking = new CoreCreateFileOptimaClientEmex();
        public FragmentFileOptimaClientEMEX()
        {
            InitializeComponent();

            textBoxWritePrice.TextChanged += textBox_TextChanged;
            textBoxWriteCounts.TextChanged += textBox_TextChanged;  
            textBoxWritePositions.TextChanged += textBox_TextChanged;   
        }

        public void textBox_TextChanged(Object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(string.IsNullOrEmpty(textBox.Text))
            {
                textBox.BackColor = Color.BurlyWood;
            }else textBox.BackColor = SystemColors.Window;
        }

        private void btnChooseFileForWork_Click(object sender, EventArgs e)
        {
            utilitieses.setLabelNormal(this.labelError);
            string FileNameTeamp = utilitieses.openFileToRead();
            if (FileNameTeamp == "")
            {
                utilitieses.setLabelError(this.labelError, "Не вибрано файла");
            }
            else FileName = FileNameTeamp;
        }

        private void btnStartWork_Click(object sender, EventArgs e)
        {
            utilitieses.setLabelNormal(this.labelError);
            TextBox[] listTextBoxes = {textBoxWritePrice, textBoxWriteCounts, textBoxWritePositions};
            if (!utilitieses.checkTextBoxes(listTextBoxes) || FileName=="" || FileName==null)
            {
                utilitieses.setLabelError(this.labelError, "Заповніть всі поля коректно");
                return;
            }
            utilitieses.setLabelStartWorking(this.labelError);
            string ErrorText  = logicWorking.CreateFileOptimaClientEmex(textBoxWritePrice.Text, textBoxWritePositions.Text, textBoxWriteCounts.Text, FileName);
            if (ErrorText == "OK") utilitieses.setLabelFinishWorkingSuccess(this.labelError);
            else utilitieses.setLabelError(this.labelError, ErrorText);
        }
    }
}
