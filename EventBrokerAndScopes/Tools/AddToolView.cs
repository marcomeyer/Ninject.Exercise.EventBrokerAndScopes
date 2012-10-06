namespace EventBrokerAndScopes.Tools
{
    using System;
    using System.Windows.Forms;

    using bbv.Common.Events;

    public partial class AddToolView : UserControl, IAddToolView
    {
        public AddToolView()
        {
            this.InitializeComponent();
        }

        public event EventHandler<EventArgs<DateTime>> AddClicked;

        private void BtnAddClick(object sender, EventArgs e)
        {
            var dateTime = DateTime.Now;
            this.AddClicked(this, new EventArgs<DateTime>(dateTime));
        }
    }
}
