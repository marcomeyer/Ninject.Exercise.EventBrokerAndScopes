namespace EventBrokerAndScopes.Tools
{
    using System;

    using bbv.Common.Events;

    public class ClearToolPresenter : IClearToolPresenter
    {
        private readonly IClearToolView view;

        public ClearToolPresenter(IClearToolView view)
        {
            this.view = view;
            this.view.ClearClicked += this.HandleClearClicked;
        }

        public event EventHandler<EventArgs<IToolView>> InitializeTool;
        
        public event EventHandler ClearContent;
        
        public void Initialize()
        {
            this.InitializeTool(this, new EventArgs<IToolView>(this.view));
        }

        private void HandleClearClicked(object sender, EventArgs e)
        {
            this.ClearContent(this, EventArgs.Empty);
        }
    }
}