﻿using System;
using System.Windows.Forms;

namespace BorderlessGaming.Forms
{
    public partial class InputText : Form
    {
        public InputText()
        {
            InitializeComponent();
        }

        private void frmInputText_Shown(object sender, EventArgs e)
        {
            txtInput.Focus();
        }

        public string Title
        {
            get
            {
                return Text.Trim();
            }
            set
            {
                Text = value.Trim();
            }
        }

        public string Input
        {
            get
            {
                return txtInput.Text.Trim();
            }
            set
            {
                txtInput.Text = value.Trim();
            }
        }

        public string Instructions
        {
            get
            {
                return lblInstructions.Text.Trim();
            }
            set
            {
                lblInstructions.Text = value.Trim();
            }
        }
    }
}
