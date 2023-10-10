using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNKWorkSale
{
    internal class Utilitieses
    {
        #region Work with TextBoxes
        public bool checkTextBoxes(TextBox[] textBoxes)
        {
            foreach (TextBox box in textBoxes)
            {
                if (string.IsNullOrEmpty(box.Text)) return false;
            }

            return true;
        }
        public void textBox_TextChanged(Object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.BackColor = Color.BurlyWood;
            }
            else textBox.BackColor = SystemColors.Window;
        }

        #endregion
        #region Work with CheckBox
        public void checkBox_Clicked(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Console.WriteLine(checkBox.Checked);
            checkBox.Checked = !checkBox.Checked;
            Console.WriteLine(checkBox.Checked);
        }
        #endregion
        public string openFileToRead()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xlsx Files(*.xlsx)|*.xlsx| All Files(*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return "";
        }
        #region Work with Labels
        public void setLabelStartWorking(object sender)
        {
            Label label = (Label)sender;
            label.Text = "Початок роботи!";
            label.BackColor = Color.Yellow;
        }
        public void setLabelFinishWorkingSuccess(object sender)
        {
            Label label = (Label)sender;
            label.Text = "ОК";
            label.BackColor = Color.Green;
        }
        public void setLabelNormal(object sender)
        {
            Label label = (Label)sender;
            label.Text = "";
            label.BackColor = SystemColors.Window;
        }

        public void setLabelError(object sender, string ErrorMess)
        {
            Label labelError = (Label)sender;
            labelError.Text = ErrorMess;
            labelError.BackColor = Color.IndianRed;
        }
        #endregion
    }
}
