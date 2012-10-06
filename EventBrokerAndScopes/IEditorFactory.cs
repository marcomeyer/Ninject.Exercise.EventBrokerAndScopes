namespace EventBrokerAndScopes
{
    using EventBrokerAndScopes.Editor;

    public interface IEditorFactory
    {
        IEditorPresenter Create();
    }
}