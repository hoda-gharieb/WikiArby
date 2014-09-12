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
    public partial class Form2 : Form
    {
        public int ROW, COL;
        public bool C1, C2, C3;
        public Form2()
        {
            InitializeComponent();
        }

        private void TEST_Click(object sender, EventArgs e)
        {
            C1 = checkBox1.Checked;
            C2 = checkBox2.Checked;
            C3 = checkBox3.Checked;
            if (ROWBox1.Text == "" )
                ROWBox1.Text = "1";
            int.TryParse(ROWBox1.Text, out ROW);
            if (COLBox2.Text == "")
                COLBox2.Text = "1";
            int.TryParse(COLBox2.Text, out COL);
        }
    }
}
