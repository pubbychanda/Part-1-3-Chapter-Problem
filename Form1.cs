using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3___Chapter_Problem
{
    public partial class BasicInput : Form
    {
        int life_expectancy = 82;
        int years_left;
        int age;
        double tallest_man = 2.72;
        double height_difference;
        double height;
        string name;

        public BasicInput()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            ///ask for help with tryparsing
            age = Convert.ToInt32(numAge.Value);
            height = Math.Round(Convert.ToDouble(txtHeight.Text), 2);
            name = txtName.Text;
            years_left = life_expectancy - age;;
            height_difference = tallest_man - height;

            lblResults.Text = 
                "Greetings, " + name + ". " + "it would appear that you have approximately " + years_left + " years left to live, and you are approximatetly " + height_difference + "m shorter than the tallest man in the world.";
        }
    }
}
