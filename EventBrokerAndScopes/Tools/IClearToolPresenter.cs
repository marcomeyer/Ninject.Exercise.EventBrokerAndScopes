namespace EventBrokerAndScopes.Tools
{
    using System;

    using bbv.Common.EventBroker;

    public interface IClearToolPresenter : IToolPresenter
    {
        [EventPublication("ClearContent")]        
        event EventHandler ClearContent;
    }
}