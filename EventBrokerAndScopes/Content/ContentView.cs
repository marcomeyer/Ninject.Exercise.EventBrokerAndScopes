namespace EventBrokerAndScopes.Content
{
    using System.Windows.Forms;

    public partial class ContentView : UserControl, IContentView
    {
        public ContentView()
        {
            this.InitializeComponent();
        }

        public void AddContent(string content)
        {
            this.listBox.Items.Add(content);
        }

        public void ClearContent()
        {
            this.listBox.Items.Clear();
        }
    }
}
