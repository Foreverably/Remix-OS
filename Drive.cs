﻿using System;
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
    public partial class Drive : Form
    {
        public Drive()
        {
            InitializeComponent();
        }

        private void Drive_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://drive.google.com/drive/my-drive");
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }
    }
}
