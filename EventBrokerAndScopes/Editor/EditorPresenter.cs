namespace EventBrokerAndScopes.Editor
{
    using EventBrokerAndScopes.Content;

    using bbv.Common.Events;

    using EventBrokerAndScopes.Tools;

    public class EditorPresenter : IEditorPresenter
    {
        private readonly IEditorView view;

        public EditorPresenter(IEditorView view)
        {
            this.view = view;
        }

        public void Show()
        {
            this.view.ShowEditor();
        }

        public void HandleSetContentView(object sender, EventArgs<IContentView> e)
        {
            this.view.SetContentView(e.Value);
        }

        public void HandleAddToolView(object sender, EventArgs<IToolView> e)
        {
            this.view.AddToolView(e.Value);
        }

        public void Initialize()
        {
        }
    }
}