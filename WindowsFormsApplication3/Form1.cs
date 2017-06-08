using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        private int i = 145;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 45)
                while (i != 145)
                {
                    panel3.Size = new Size(672 - i, 364);
                    panel1.Size = new Size(i, 315);

                    button3.Visible = false;

                    i++;
                }
            else
                while (i != 45)
                {
                    panel3.Size = new Size(557 + i, 364);
                    panel1.Size = new Size(i, 315);


                    button3.Visible = false;

                    i--;
                }
            button3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}