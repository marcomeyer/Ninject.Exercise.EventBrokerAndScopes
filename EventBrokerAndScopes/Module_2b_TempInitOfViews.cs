namespace EventBrokerAndScopes
{
    using EventBrokerAndScopes.Content;
    using EventBrokerAndScopes.Editor;

    using Ninject.Extensions.DependencyCreation;

    using bbv.Common.Events;

    using EventBrokerAndScopes.Tools;

    using Ninject.Extensions.Conventions;
    using Ninject.Extensions.Factory;
    using Ninject.Modules;

    public class Module_2b : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IEditorFactory>().ToFactory();

            this.Kernel.Bind(x => x
                .FromThisAssembly().SelectAllClasses().Where(t => t.Name.EndsWith("Presenter"))
                .BindAllInterfaces()
                .Configure(b => b.OnActivation<IPresenter>(o => o.Initialize()))
                .ConfigureFor<EditorPresenter>(b => b.OnActivation<EditorPresenter>(o =>
                    {
                        o.HandleSetContentView(null, new EventArgs<IContentView>(new ContentView()));
                        o.HandleAddToolView(null, new EventArgs<IToolView>(new AddToolView()));
                        o.HandleAddToolView(null, new EventArgs<IToolView>(new ClearToolView()));
                    })));
            
            this.Kernel.Bind(x => x
                .FromThisAssembly().SelectAllClasses().Where(t => t.Name.EndsWith("View"))
                .BindAllInterfaces());

            this.Kernel.DefineDependency<IEditorPresenter, IContentPresenter>();
            this.Kernel.DefineDependency<IEditorPresenter, IClearToolPresenter>();
            this.Kernel.DefineDependency<IEditorPresenter, IAddToolPresenter>();
        }
    }
}
