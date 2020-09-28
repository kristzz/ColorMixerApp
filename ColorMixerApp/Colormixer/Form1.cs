using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void SetColorsButton_Click(object sender, EventArgs e)
        {

            int redValue = Int32.Parse(RedValue.Text);
            int greenValue = Int32.Parse(GreenValue.Text);
            int blueValue = Int32.Parse(BlueValue.Text);


            RedBulb.BackColor = Color.FromArgb(redValue, 0, 0);
            GreenBulb.BackColor = Color.FromArgb(0, blueValue, 0);
            BlueBulb.BackColor = Color.FromArgb(0, 0, greenValue);
            this.BackColor = Color.FromArgb(redValue, greenValue, blueValue);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
