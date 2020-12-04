using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoulderMichigan
{
    public partial class frm_FitnessLabDayPass : Form
    {
        public frm_FitnessLabDayPass()
        {
            InitializeComponent();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            string message = ($"Thank you for booking with us, {textBox_FirstName.Text}. See you soon!");
            MessageBox.Show(message);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_ZipCode.Text, out int zipCode))
            {
                MessageBox.Show("Please enter a valid zipcode.");
            }
        }

        private void textBox_WaiverDisclaimer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
