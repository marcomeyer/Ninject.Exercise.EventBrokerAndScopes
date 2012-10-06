namespace EventBrokerAndScopes.Tools
{
    using System;

    using bbv.Common.Events;

    public class AddToolPresenter : IAddToolPresenter
    {
        private readonly IAddToolView view;

        public AddToolPresenter(IAddToolView view)
        {
            this.view = view;
            this.view.AddClicked += this.HandleAddClicked;
        }

        public event EventHandler<EventArgs<IToolView>> InitializeTool;

        public event EventHandler<EventArgs<DateTime>> AddContent;

        public void Initialize()
        {
            this.InitializeTool(this, new EventArgs<IToolView>(this.view));
        }

        private void HandleAddClicked(object sender, EventArgs<DateTime> eventArgs)
        {
            this.AddContent(this, new EventArgs<DateTime>(eventArgs.Value));
        }
    }
}