using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Written_for_Errors_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<int> var = new List<int>();
            nums.Add(51);
            nums.Add(39);
            printNums(var);
        }

        void printNums(List<int> ns)
        {
            foreach (int i in ns)
            {
                richTextBox1.AppendText(i + ", ");

            }
            richTextBox1.AppendText("\n===============\n");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
