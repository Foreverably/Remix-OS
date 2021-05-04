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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            Launcher.Visible = false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Launcher.Visible = true;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.TopLevel = false;
            f.Parent = this;
            f.Show();

            Launcher.Visible = false;
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            UACwarn.Visible = true;

            Launcher.Visible = false;
        }

        private void siticoneCircleButton6_Click(object sender, EventArgs e)
        {
            Warnn.Visible = false;

        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Warnn.Visible = false;
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            regedit f = new regedit();
            f.TopLevel = false;
            f.Parent = this;
            f.Show();

            UACwarn.Visible = false;
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            UACwarn.Visible = false;
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            canvasapp f = new canvasapp();
            f.TopLevel = false;
            f.Parent = this;
            f.Show();

            Launcher.Visible = false;
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            Drive f = new Drive();
            f.TopLevel = false;
            f.Parent = this;
            f.Show();

            Launcher.Visible = false;
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            musicplayer f = new musicplayer();
            f.TopLevel = false;
            f.Parent = this;
            f.Show();

            Launcher.Visible = false;
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            Files f = new Files();
            f.TopLevel = false;
            f.Parent = this;
            f.Show();

            Launcher.Visible = false;
        }

        private void Launcher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            egocode f = new egocode();
            f.TopLevel = false;
            f.Parent = this;
            f.Show();

            Launcher.Visible = false;
        }

        private void showTitleBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {
            Terminal f = new Terminal();
            f.TopLevel = false;
            f.Parent = this;
            f.Show();

            Launcher.Visible = false;
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siticonePanel1.Visible = true;
        }

        private void siticoneCircleButton2_Click(object sender, EventArgs e)
        {
            siticonePanel1.Visible = false;
        }

        private void siticoneButton12_Click(object sender, EventArgs e)
        {
           _account.Show(siticoneButton1, new System.Drawing.Point(20, 20));

        }
    }
}
