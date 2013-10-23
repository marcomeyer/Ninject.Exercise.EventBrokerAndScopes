namespace EventBrokerAndScopes.Tools
{
    using System;

    using bbv.Common.Events;

    public class TextToolPresenter : ITextToolPresenter
    {
        private readonly ITextToolView view;

        public TextToolPresenter(ITextToolView view)
        {
            this.view = view;
            this.view.ButtonClicked += this.HandleButtonClicked;
        }

        public event EventHandler<EventArgs<IToolView>> InitializeTool;

        public event EventHandler<EventArgs<string>> AddContent;

        public void Initialize()
        {
            this.InitializeTool(this, new EventArgs<IToolView>(this.view));
        }

        private void HandleButtonClicked(object sender, EventArgs eventArgs)
        {
            this.AddContent(this, new EventArgs<string>(this.view.MessageText));
        }
    }
}