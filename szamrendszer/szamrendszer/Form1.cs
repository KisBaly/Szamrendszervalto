using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamrendszer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inszam = textBox1.Text;

            int szmr = int.Parse(textBox2.Text);

            int szmrbe = int.Parse(textBox3.Text);

            int decert = Decbe(inszam, szmr);
            string vegeredmeny = Decbol(decert, szmrbe);
            label5.Text = vegeredmeny;
        }

        static int Decbe(string inp, int szr)
        {
            return Convert.ToInt32(inp, szr);
        }

        static string Decbol(int dec, int szrbe)
        {
            return Convert.ToString(dec, szrbe);
        }
    }
    }

