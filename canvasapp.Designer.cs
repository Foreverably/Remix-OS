
namespace Remix_OS
{
    partial class canvasapp
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
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneControlBox3 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this._labeldrag = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this._controlboxdrag = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.siticoneControlBox3);
            this.siticonePanel1.Controls.Add(this.siticoneControlBox2);
            this.siticonePanel1.Controls.Add(this.siticoneControlBox1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(1192, 25);
            this.siticonePanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(555, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Canvas";
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.BorderRadius = 10;
            this.siticoneControlBox3.ControlBoxStyle = Siticone.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox3.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox3.HoveredState.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox3.Location = new System.Drawing.Point(1117, 0);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.Size = new System.Drawing.Size(25, 25);
            this.siticoneControlBox3.TabIndex = 2;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxStyle = Siticone.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.siticoneControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(1142, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(25, 25);
            this.siticoneControlBox2.TabIndex = 1;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneControlBox1.ControlBoxStyle = Siticone.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1167, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(25, 25);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // _labeldrag
            // 
            this._labeldrag.TargetControl = this.label1;
            // 
            // _controlboxdrag
            // 
            this._controlboxdrag.TargetControl = this.siticonePanel1;
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 10;
            this.siticoneElipse1.TargetControl = this;
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = true;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 25);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(1192, 667);
            this.chromiumWebBrowser1.TabIndex = 2;
            this.chromiumWebBrowser1.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.chromiumWebBrowser1_LoadingStateChanged);
            // 
            // canvasapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 692);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "canvasapp";
            this.Text = "canvasapp";
            this.Load += new System.EventHandler(this.canvasapp_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneDragControl _labeldrag;
        private Siticone.UI.WinForms.SiticoneDragControl _controlboxdrag;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
    }
}