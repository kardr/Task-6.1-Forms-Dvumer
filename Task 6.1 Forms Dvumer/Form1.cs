using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6._1_Forms_Dvumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(numericUpDown1.Value);
                int m = Convert.ToInt32(numericUpDown2.Value);
                int[,] mass = new int[n, m];
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        mass[i, j] = r.Next(-50, 50);
                        textBox1.Text += mass[i, j] + "       "+"\n\r"; 
                    }
                    textBox1.Text += "\n\r";
                }
                textBox1.Text += "\n\r";
                for (int i = 1; i < n; i = i +2)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (mass[i, j] > 0)
                        {
                            textBox2.Text += mass[i, j] + "   ";
                        }
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }
    }
}
