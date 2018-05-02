using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PrjAssignment6
{
    public partial class Form1 : Form
    {
        string bevLine, appLine, mnLine, desLine;
        StreamReader bev = new StreamReader("Beverages.txt");
        StreamReader app = new StreamReader("Appetizers.txt");
        StreamReader mn = new StreamReader("Mains.txt");
        StreamReader des = new StreamReader("Desserts.txt");
        double[] bevPrices = new double[6];
        double[] appPrices = new double[7];
        double[] mainsPrices = new double[9];
        double[] desPrices = new double[5];

        double[] desPrice = new double[5];
        public Form1()
        {
            InitializeComponent();
            int prices = 0;
            bevLine = bev.ReadLine();
            while(!bev.EndOfStream)
            {
                var split = bevLine.Split('$');
                bevComboBox.Items.Add(bevLine);
                bevLine = bev.ReadLine();
                bevPrices[prices] = Double.Parse(split[1]);
                prices++;
            }

            prices = 0;
            appLine = app.ReadLine();
            while (!app.EndOfStream)
            {
                var split = appLine.Split('$');
                appetizerComboBox.Items.Add(appLine);
                appLine = app.ReadLine();
                appPrices[prices] = Double.Parse(split[1]);
                prices++;
            }

            prices = 0;
            mnLine = mn.ReadLine();
            while (!mn.EndOfStream)
            {
                var split = mnLine.Split('$');
                mainsComboBox.Items.Add(mnLine);
                mnLine = mn.ReadLine();
                mainsPrices[prices] = Double.Parse(split[1]);
                prices++;
            }

            prices = 0;
            desLine = des.ReadLine();
            while (!des.EndOfStream)
            {
                var split = desLine.Split('$');
                dessertsComboBox.Items.Add(desLine);
                desLine = des.ReadLine();
                desPrices[prices] = Double.Parse(split[1]);
                prices++;
            }
        }
        double total = 0;


        private void bevAdd_Click(object sender, EventArgs e)
        {
            int x = bevComboBox.SelectedIndex;
            if (x == -1)
                MessageBox.Show("Please select a beverage.");
            else
                total += bevPrices[x];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = appetizerComboBox.SelectedIndex;
            if (x == -1)
                MessageBox.Show("Please select an appetizer.");
            else
                total += appPrices[x];
        }

        private void mainsAddButton_Click(object sender, EventArgs e)
        {
            int x = mainsComboBox.SelectedIndex;
            if (x == -1)
                MessageBox.Show("Please select a main course.");
            else
                total += mainsPrices[x];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dessertAddButton_Click(object sender, EventArgs e)
        {
            int x = dessertsComboBox.SelectedIndex;
            if (x == -1)
                MessageBox.Show("Please select a dessert.");
            else
                total += desPrices[x];
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total price cleared.");
            total = 0;
        }

        private void subttlButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your total price is: " + total.ToString("C"));
        }
    }
}
