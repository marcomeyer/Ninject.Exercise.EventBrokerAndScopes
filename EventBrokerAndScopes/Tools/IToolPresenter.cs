namespace EventBrokerAndScopes.Tools
{
    using System;

    using bbv.Common.EventBroker;
    using bbv.Common.Events;

    public interface IToolPresenter : IPresenter
    {
        [EventPublication("InitializeTool")]
        event EventHandler<EventArgs<IToolView>> InitializeTool;
    }
}