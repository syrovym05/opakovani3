using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Ukol 3";
            this.ShowIcon = false;
            panel1.Visible = false;


        }

        Zamestnanec zamestnanec;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {            
                zamestnanec = new Zamestnanec(textBox2.Text, textBox1.Text, int.Parse(textBox3.Text), dateTimePicker1.Value);
                label6.Text = zamestnanec.ToString();
                panel1.Visible = true;
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zamestnanec.PridejOdprHod(Convert.ToInt32(numericUpDown1.Value));
            label6.Text = zamestnanec.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zamestnanec.ZvysOsobni(Convert.ToInt32(numericUpDown2.Value));
            label6.Text = zamestnanec.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zamestnanec.Relaxace(3);
            label6.Text = zamestnanec.ToString();

        }
    }
}
