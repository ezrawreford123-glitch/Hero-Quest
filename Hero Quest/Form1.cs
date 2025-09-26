using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Quest
{
    public partial class Form1 : Form
    {
        string heroName;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            heroName = nameInput.Text;
           //this will show the text that appears after you press the button
            outputLabel.Text = "hello ezra. have a glorious adventure.";
            outputLabel.Visible = true;
            //this makes the label visible when the code is ran
        }
    }
}
