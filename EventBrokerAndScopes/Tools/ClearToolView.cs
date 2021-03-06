﻿namespace EventBrokerAndScopes.Tools
{
    using System;
    using System.Windows.Forms;

    public partial class ClearToolView : UserControl, IToolView
    {
        public ClearToolView()
        {
            this.InitializeComponent();
        }

        public event EventHandler ButtonClicked;

        private void BtnClearClick(object sender, EventArgs e)
        {
            this.ButtonClicked(this, EventArgs.Empty);
        }
    }
}
