namespace EventBrokerAndScopes
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using EventBrokerAndScopes.Editor;

    public partial class MainForm : Form
    {
        private readonly IEditorFactory editorFactory;

        private readonly IList<IEditorPresenter> editors;

        public MainForm(IEditorFactory editorFactory)
        {
            this.editorFactory = editorFactory;
            this.editors = new List<IEditorPresenter>();
            InitializeComponent();
        }

        private void BtnCreateEditorClick(object sender, EventArgs e)
        {
            IEditorPresenter editor = this.editorFactory.Create();
            this.editors.Add(editor);
            editor.Show();
        }

        private void BtnGCCollect(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
