using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bing_Translator
{
    public partial class Form3 : Form
    {
        public string URL, TEXT;
        public bool R1, R2;
        public Form3()
        {
            InitializeComponent();
        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            URL = URLBox.Text;
            TEXT = textBox.Text;
            R1 = radioButton1.Checked;
            R2 = radioButton2.Checked;
        }
    }
}
