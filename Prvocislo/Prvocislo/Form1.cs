using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prvocislo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool jePrvocislo(int cislo)
        {

            if(cislo == 2 || cislo == 3 || cislo == 5 || cislo == 7 || cislo == 11 || cislo == 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void presun(int[] pole)
        {
            listBox1.Items.Clear();

            foreach (int cislo in pole)
            {
                if(jePrvocislo(cislo) == true)
                {
                    listBox1.Items.Add(cislo);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int ncisel = (int)numericUpDown1.Value;
            int[] polencisel = new int[ncisel];
            Random rng = new Random();

            for(int i = 0;i < ncisel;i++)
            {
                polencisel[i] = rng.Next(2, 16);
                textBox1.Text += polencisel[i];
                textBox1.Text += Environment.NewLine;
            }
            
            presun(polencisel);

        }
    }
}
