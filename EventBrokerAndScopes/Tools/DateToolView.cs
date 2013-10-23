namespace EventBrokerAndScopes.Tools
{
    using System;
    using System.Windows.Forms;

    public partial class DateToolView : UserControl, IToolView
    {
        public DateToolView()
        {
            this.InitializeComponent();
        }

        public event EventHandler ButtonClicked;

        private void BtnAddClick(object sender, EventArgs e)
        {
            this.ButtonClicked(this, EventArgs.Empty);
        }
    }
}
