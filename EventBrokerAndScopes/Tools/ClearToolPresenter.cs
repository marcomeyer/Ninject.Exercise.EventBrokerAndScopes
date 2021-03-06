﻿namespace EventBrokerAndScopes.Tools
{
    using System;

    using bbv.Common.Events;

    public class ClearToolPresenter : IClearToolPresenter
    {
        private readonly IToolView view;

        public ClearToolPresenter(IToolView view)
        {
            this.view = view;
            this.view.ButtonClicked += this.HandleButtonClicked;
        }

        public event EventHandler<EventArgs<IToolView>> InitializeTool;
        
        public event EventHandler ClearContent;
        
        public void Initialize()
        {
            this.InitializeTool(this, new EventArgs<IToolView>(this.view));
        }

        private void HandleButtonClicked(object sender, EventArgs e)
        {
            this.ClearContent(this, EventArgs.Empty);
        }
    }
}