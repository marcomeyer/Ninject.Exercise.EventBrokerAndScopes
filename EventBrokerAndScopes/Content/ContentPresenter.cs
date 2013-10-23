namespace EventBrokerAndScopes.Content
{
    using System;
    using System.Globalization;

    using bbv.Common.Events;

    public class ContentPresenter : IContentPresenter
    {
        private readonly IContentView view;

        public ContentPresenter(IContentView view)
        {
            this.view = view;
        }

        public event EventHandler<EventArgs<IContentView>> InitializeContent;

        public void HandleClearContent(object sender, EventArgs e)
        {
            this.view.ClearContent();
        }

        public void HandleAddContent(object sender, EventArgs<string> e)
        {
            this.view.AddContent(e.Value);
        }

        public void Initialize()
        {
            this.InitializeContent(this, new EventArgs<IContentView>(this.view));
        }
    }
}