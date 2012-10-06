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

        ~ContentPresenter()
        {
        }

        public event EventHandler<EventArgs<IContentView>> InitializeContent;

        public void HandleAddContent(object sender, EventArgs<DateTime> e)
        {
            var content = e.Value.ToString("hh:mm:ss", CultureInfo.InvariantCulture);

            this.view.AddContent(content);
        }

        public void HandleClearContent(object sender, EventArgs e)
        {
            this.view.ClearContent();
        }

        public void Initialize()
        {
            this.InitializeContent(this, new EventArgs<IContentView>(this.view));
        }
    }
}