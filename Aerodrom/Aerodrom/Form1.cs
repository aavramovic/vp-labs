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
    public partial class Form1 : Form
    {
        AddPlane addPlaneForm;
        AddDestination addDestinationFrom;
        public Form1()
        {
            InitializeComponent();
        }
        private void addPlaneButton_Click(object sender, EventArgs e)
        {
            addPlaneForm = new AddPlane(this);
            addPlaneForm.ShowDialog();
        }
       
        private void deletePlaneButton_Click(object sender, EventArgs e)
        {
            if(planesListBox.SelectedIndex != -1)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(
                    "Дали сте сигурни дека сакате да го избришете овој аеродром?",
                    "Избриши авион", buttons);

                if(result == DialogResult.Yes)
                    planesListBox.Items.RemoveAt(planesListBox.SelectedIndex);
            }
        }

        private void addDestinationButton_Click(object sender, EventArgs e)
        {
            if (planesListBox.SelectedIndex != -1)
            {
                addDestinationFrom = new AddDestination(this);
                addDestinationFrom.ShowDialog();
                planesListBox_SelectedIndexChanged(sender, e);
            }
        }

        private void planesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (planesListBox.SelectedIndex != -1)
            {
                destinationsListBox.Items.Clear();
                List<Destination> destinations = ((Plane)planesListBox
                        .Items[planesListBox.SelectedIndex])
                        .Destinations;
                float maxPrice = 0;
                float sumForAverage = 0;
                foreach (Destination destination in destinations)
                {
                    destinationsListBox.Items.Add(destination);
                    if (destination.Price > maxPrice)
                        maxPrice = destination.Price;
                    sumForAverage += destination.Distance;
                }
                mostExpensiveDestinationTextBox.Text = maxPrice.ToString();
                if (destinations.Count != 0)
                    averageDistanceTextBox.Text = (sumForAverage / destinations.Count).ToString();
                else
                    averageDistanceTextBox.Text = "0";
            }
        }

        private void planesListBox_SelectedIndexChanged(object sender, ControlEventArgs e)
        {
            if (planesListBox.SelectedIndex != -1)
            {
                destinationsListBox.Items.Clear();
                List<Destination> destinations = ((Plane)planesListBox
                        .Items[planesListBox.SelectedIndex])
                        .Destinations;
                foreach (Destination destination in destinations)
                    destinationsListBox.Items.Add(destination);
            }
        }
    }

    public class Plane
    {
        public string City { get; set; }
        public string Name { get; set; }
        public string Abbriviation { get; set; }
        public List<Destination> Destinations { get; set; }

        public Plane(string city, string name, string abbriviation)
        {
            City = city;
            Name = name;
            Abbriviation = abbriviation;
            Destinations = new List<Destination>();
        }

        public override string ToString()
        {
            return Abbriviation + " - " + Name + " - " + City;
        }
    }

    public class Destination
    {
        public string Name { get; set; }
        public float Distance { get; set; }
        public float Price { get; set; }

        public Destination(string name, float distance, float price)
        {
            Name = name;
            Distance = distance;
            Price = price;
        }

        public override string ToString()
        {
            return Name + "    " + Distance + " - " + Price;
        }
    }
}
