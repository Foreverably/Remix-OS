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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void siticonePictureBox4_Click(object sender, EventArgs e)
        {
            tabControl1.Controls.Add(new tabcreation());
        }

        private void siticoneVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void siticoneRoundedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Controls.Add(new tabcreation());
        }

        public class tabcreation : TabPage
        {
            WebBrowser wb = new WebBrowser();

            public tabcreation()
            {
                
                wb.Url = new Uri("https://google.com");
                wb.Dock = DockStyle.Fill;

                this.Controls.Add(wb);
            }
        }

        private void siticonePictureBox5_Click(object sender, EventArgs e)
        {
            TabPage current_tab = tabControl1.SelectedTab;
            tabControl1.TabPages.Remove(current_tab);
        }

        private void removeSelectedTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage current_tab = tabControl1.SelectedTab;
            tabControl1.TabPages.Remove(current_tab);
        }
    }
}
