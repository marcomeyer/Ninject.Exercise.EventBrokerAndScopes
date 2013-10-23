namespace EventBrokerAndScopes.Content
{
    using System;

    using bbv.Common.EventBroker;
    using bbv.Common.EventBroker.Handlers;
    using bbv.Common.Events;

    public interface IContentPresenter : IPresenter
    {
        [EventPublication("InitializeContent")]
        event EventHandler<EventArgs<IContentView>> InitializeContent;
                
        [EventSubscription("ClearContent", typeof(Publisher))]
        void HandleClearContent(object sender, EventArgs e);

        [EventSubscription("AddContent", typeof(Publisher))]
        void HandleAddContent(object sender, EventArgs<string> e);
    }
}