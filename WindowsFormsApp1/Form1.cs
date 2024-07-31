using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                        Panel yellowPanel = new Panel();
                        yellowPanel.Width = 25;
                        yellowPanel.Height = 25;
                        yellowPanel.BackColor = Color.Yellow;
                        yellowPanel.Left = (buttons[i, j].Width - yellowPanel.Width)/2;
                        yellowPanel.Top = (buttons[i, j].Height - yellowPanel.Height) / 2;

                        buttons[i, j].Controls.Add(yellowPanel);

                    }
                    else
                    { 
                    buttons[i, j].BackColor = Color.White;
                }
                this.Controls.Add(buttons[i, j]);

            }
                top += 50;
                left = 0;
        }
        }
    }
}
