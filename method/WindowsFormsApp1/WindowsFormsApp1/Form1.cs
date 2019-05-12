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
        string file1 = @"C:\Users\1\Desktop\1.cmd";
        string file2 = @"C:\Users\1\Desktop\0.cmd";
        public Form1()
        {
            InitializeComponent();
        }

        void Button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(file1))
            {
                Method1();
            }
            else
            {
                Method2();
            }
    }
        void Method1()
        {
            MessageBox.Show("Файл есть", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        void Method2()
        {
            MessageBox.Show("Файла нет", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}

  

