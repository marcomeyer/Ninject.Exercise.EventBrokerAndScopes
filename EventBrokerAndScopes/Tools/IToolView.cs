namespace EventBrokerAndScopes.Tools
{
    using System;

    public interface IToolView
    {
        event EventHandler ButtonClicked;
    }
}