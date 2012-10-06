namespace EventBrokerAndScopes.Tools
{
    using System;

    using bbv.Common.Events;

    public interface IAddToolView : IToolView
    {
        event EventHandler<EventArgs<DateTime>> AddClicked;
    }
}