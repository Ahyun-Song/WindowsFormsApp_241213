using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_241213
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox_print.Text = "이것은\r\n멀티박스\r\n텍스트박스";
            // MessageBox.Show("Hello");

            String msg = "Hello!!";

            int a = 0;
        }


    }
}
