using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int number = 10;
        //10

        public Form1()
        {
            InitializeComponent();
        }

        void Button1_Click(object sender, EventArgs e)
        {
            if (number == 10)
            {
                label1.Text = "Да";
            }
            else
            {
                label1.Text = "Нет";
            }
            label1.Text = (number == 10 ? "Да" : "Нет");
        }
        }
    }
