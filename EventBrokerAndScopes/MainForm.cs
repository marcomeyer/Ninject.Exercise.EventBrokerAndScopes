namespace EventBrokerAndScopes
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private readonly IEditorFactory editorFactory;

        public MainForm(IEditorFactory editorFactory)
        {
            this.editorFactory = editorFactory;
            InitializeComponent();
        }

        private void BtnCreateEditorClick(object sender, EventArgs e)
        {
            this.editorFactory.Create().Show();
        }

        private void BtnGCCollect(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
