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
            if (File.Exists(@"C:\Users\Fil\Desktop\1.cmd"))
            {
                MessageBox.Show("Файл есть', 'Есть ли файл", MessageBoxIcon.Asterisk);
            }

        }
        string Method()
        {
            return Location.ToString();
        }





        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
