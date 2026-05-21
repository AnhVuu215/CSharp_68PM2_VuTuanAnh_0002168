using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLSV uCQLSV = new UCQLSV();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uCQLSV);

        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLLH uCQLLH = new UCQLLH();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uCQLLH);
        }
    }
}
