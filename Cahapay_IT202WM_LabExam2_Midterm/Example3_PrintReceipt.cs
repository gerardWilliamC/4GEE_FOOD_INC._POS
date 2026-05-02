using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cahapay_IT202WM_LabExam2_Midterm
{
    public partial class Example3_PrintReceipt : Form
    {
        public Example3_PrintReceipt(ListBox.ObjectCollection items)
        {
            InitializeComponent();

            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void Example2_PrintReceipt_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
