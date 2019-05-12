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
        public Form1()
        {
            InitializeComponent();
        }

        void Button1_Click(object sender, EventArgs e)
        {
           if(File.Exists(@"C:\Users\1\Desktop\1.cmd"))
            {

                Method();
            }
        }

        void Method()
        {
            MessageBox.Show("Файл есть", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}

  

