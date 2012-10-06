namespace EventBrokerAndScopes.Content
{
    public interface IContentView
    {
        void AddContent(string content);

        void ClearContent();
    }
}