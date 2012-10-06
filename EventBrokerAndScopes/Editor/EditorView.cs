namespace EventBrokerAndScopes.Editor
{
    using System.Windows.Forms;

    using EventBrokerAndScopes.Content;
    using EventBrokerAndScopes.Tools;

    public partial class EditorView : Form, IEditorView
    {
        public EditorView()
        {
            this.InitializeComponent();
        }

        public void ShowEditor()
        {
            this.Show();
        }

        public void SetContentView(IContentView contentView)
        {
            this.AddControlToPanel(contentView, this.splitContainer1.Panel1, DockStyle.Fill);
        }

        public void AddToolView(IToolView toolView)
        {
            this.AddControlToPanel(toolView, this.splitContainer1.Panel2, DockStyle.Top);
        }

        private void AddControlToPanel(object view, Panel panel, DockStyle dockStyle)
        {
            var viewAsControl = view as Control;
            if (viewAsControl != null)
            {
                viewAsControl.Dock = dockStyle;
                panel.Controls.Add(viewAsControl);
            }
        }
    }
}
