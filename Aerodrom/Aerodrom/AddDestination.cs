using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerodrom
{
    public partial class AddDestination : Form
    {
        Form1 mainForm;
        public AddDestination(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void addDestinationButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0)
                errorProviderName.SetError(nameTextBox, "Полето за име не смее да е празно!");
            if (errorProviderName.GetError(nameTextBox) == "")
            {
                ((Plane)mainForm.planesListBox.Items[mainForm.planesListBox.SelectedIndex])
                    .Destinations
                    .Add(new Destination(
                        nameTextBox.Text,
                        (float)pathNumbericUpDown.Value,
                        (float)priceNumericUpDown.Value));
                this.Close();
            }
        }

        private void discardDestinationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
