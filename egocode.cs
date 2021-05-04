using Remix_OS.Ego_Code_Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remix_OS
{
    public partial class egocode : Form
    {
        public egocode()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(siticoneButton1, new System.Drawing.Point(20, 20));

        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Project f = new New_Project();
            f.Show();
        }
    }
}
