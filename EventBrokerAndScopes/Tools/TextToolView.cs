namespace EventBrokerAndScopes.Tools
{
    using System;
    using System.Windows.Forms;

    public partial class TextToolView : UserControl, ITextToolView
    {
        public TextToolView()
        {
            this.InitializeComponent();
        }

        public event EventHandler ButtonClicked;

        public string MessageText
        {
            get
            {
                return this.textBox1.Text;
            }
        }

        private void BtnAddClick(object sender, EventArgs e)
        {
            this.ButtonClicked(this, EventArgs.Empty);
        }
    }
}
