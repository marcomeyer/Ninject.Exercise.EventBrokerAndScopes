namespace EventBrokerAndScopes.Tools
{
    using System;
    using System.Windows.Forms;

    public partial class ClearToolView : UserControl, IClearToolView
    {
        public ClearToolView()
        {
            this.InitializeComponent();
        }

        public event EventHandler ClearClicked;

        private void BtnClearClick(object sender, EventArgs e)
        {
            this.ClearClicked(this, EventArgs.Empty);
        }
    }
}
