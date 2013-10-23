namespace EventBrokerAndScopes.Tools
{
    using System;
    using System.Globalization;

    using bbv.Common.Events;

    public class DateToolPresenter : IDateToolPresenter
    {
        private readonly IToolView view;

        public DateToolPresenter(IToolView view)
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
            var dateTime = DateTime.Now;

            this.AddContent(this, new EventArgs<string>(dateTime.ToString(CultureInfo.CurrentUICulture)));
        }
    }
}