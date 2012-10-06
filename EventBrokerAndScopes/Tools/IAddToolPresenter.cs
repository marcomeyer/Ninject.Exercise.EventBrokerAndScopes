namespace EventBrokerAndScopes.Tools
{
    using System;

    using bbv.Common.EventBroker;
    using bbv.Common.Events;

    public interface IAddToolPresenter : IToolPresenter
    {
        [EventPublication("AddContent")]
        event EventHandler<EventArgs<DateTime>> AddContent;
    }
}