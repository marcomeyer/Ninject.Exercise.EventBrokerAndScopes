namespace EventBrokerAndScopes.Tools
{
    using System;

    using bbv.Common.EventBroker;
    using bbv.Common.Events;

    public interface ITextToolPresenter : IToolPresenter
    {
        [EventPublication("AddContent")]
        event EventHandler<EventArgs<string>> AddContent;
    }
}