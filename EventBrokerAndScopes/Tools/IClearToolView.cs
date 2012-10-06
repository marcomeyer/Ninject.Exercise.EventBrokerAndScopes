namespace EventBrokerAndScopes.Tools
{
    using System;

    public interface IClearToolView : IToolView
    {
        event EventHandler ClearClicked;
    }
}