using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerodrom
{
    public partial class AddPlane : Form
    {
        Form1 mainForm;
        public AddPlane(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void savePlaneButton_MouseClick(object sender, MouseEventArgs e)
        {
            Plane plane = null;
            if (cityTextBox.Text.Length == 0)
                //errorMessage.Append("Полето за име на градот е празно\n");
                wrongInfoErrorProvider.SetError(cityTextBox, "Полето за име на градот е празно\n");
            else
                wrongInfoErrorProvider.SetError(cityTextBox, "");
            if (nameTextBox.Text.Length == 0)
                //errorMessage.Append("Полето за име на аеродромот е празно\n");
                wrongInfoErrorProvider.SetError(nameTextBox, "Полето за име на аеродромот е празно\n");
            else
                wrongInfoErrorProvider.SetError(nameTextBox, "");
            if (abbriviationTextBox.Text.Length != 3 ||
                Regex.Matches(abbriviationTextBox.Text, @"[A-Z]").Count != 3)
                //errorMessage.Append("Полето за кратенк мора да содржи точно три големи букви");
                wrongInfoErrorProvider.SetError(abbriviationTextBox, "Полето за кратенкa мора да содржи точно три големи букви");
            else
                wrongInfoErrorProvider.SetError(abbriviationTextBox, "");

            if(wrongInfoErrorProvider.GetError(cityTextBox)==""&&
                wrongInfoErrorProvider.GetError(nameTextBox)==""&&
                wrongInfoErrorProvider.GetError(abbriviationTextBox)=="")
            {
                plane = new Plane(
                    cityTextBox.Text,
                    nameTextBox.Text,
                    abbriviationTextBox.Text);
                mainForm.planesListBox.Items.Add(plane);
                this.Close();
            }
            
        }

        private void discardPlaneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
