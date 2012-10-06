namespace EventBrokerAndScopes.Editor
{
    using EventBrokerAndScopes.Content;
    using EventBrokerAndScopes.Tools;

    public interface IEditorView
    {
        void ShowEditor();

        void SetContentView(IContentView contentView);

        void AddToolView(IToolView toolView);
    }
}