using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiaeLeo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngerar_Click(object sender, EventArgs e)
        {
            {
                int[] numero = new int[15];
                Random num = new Random();
                int i;
                for (i = 0; i < 15; i++)
                {
                    numero[i] = num.Next(0, 100);
                }
                for (i = 0; i < 15; i++)
                {
                    if (i % 2 == 0)
                    {
                        int x = numero[i];
                        txtnumero.Text = numero[i].ToString()+"\t"+txtnumero.Text+Environment.NewLine;
                    }
                }
            }
        }
    }
}
