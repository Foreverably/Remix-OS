
namespace Remix_OS.Ego_Code_Windows
{
    partial class New_Project
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.siticonePanel1.Controls.Add(this.siticoneControlBox1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(800, 25);
            this.siticonePanel1.TabIndex = 6;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneControlBox1.ControlBoxStyle = Siticone.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(775, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(25, 25);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.siticonePanel1;
            // 
            // New_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New_Project";
            this.Text = "New_Project";
            this.Load += new System.EventHandler(this.New_Project_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
    }
}