namespace EventBrokerAndScopes.Editor
{
    using bbv.Common.EventBroker;
    using bbv.Common.EventBroker.Handlers;
    using bbv.Common.Events;

    using EventBrokerAndScopes.Content;
    using EventBrokerAndScopes.Tools;

    public interface IEditorPresenter : IPresenter
    {
        void Show();

        [EventSubscription("InitializeContent", typeof(Publisher))]
        void HandleSetContentView(object sender, EventArgs<IContentView> e);

        [EventSubscription("InitializeTool", typeof(Publisher))]
        void HandleAddToolView(object sender, EventArgs<IToolView> e);
    }
}