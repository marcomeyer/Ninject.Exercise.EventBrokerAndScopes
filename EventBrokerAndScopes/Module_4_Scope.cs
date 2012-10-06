namespace EventBrokerAndScopes
{
    using EventBrokerAndScopes.Content;
    using EventBrokerAndScopes.Editor;
    using EventBrokerAndScopes.Tools;

    using Ninject.Extensions.bbvEventBroker;
    using Ninject.Extensions.Conventions;
    using Ninject.Extensions.DependencyCreation;
    using Ninject.Extensions.Factory;
    using Ninject.Extensions.NamedScope;
    using Ninject.Modules;

    public class Module_4 : NinjectModule
    {
        private const string EditorEventBrokerName = "EditorEventBroker";
        private const string EditorScopeName = "EditorScope";

        public override void Load()
        {
            this.Bind<IEditorFactory>().ToFactory();

            this.Kernel.Bind(x => x
                .FromThisAssembly().SelectAllClasses().Where(t => t.Name.EndsWith("Presenter"))
                .BindAllInterfaces()
                .Configure(b => b
                    .InNamedScope(EditorScopeName)
                    .RegisterOnEventBroker(EditorEventBrokerName)
                    .OnActivation<IPresenter>(o => o.Initialize()))
                .ConfigureFor<EditorPresenter>(b => b
                    .InTransientScope()
                    .OwnsEventBroker(EditorEventBrokerName)
                    .DefinesNamedScope(EditorScopeName)));
            
            this.Kernel.Bind(x => x
                .FromThisAssembly().SelectAllClasses().Where(t => t.Name.EndsWith("View"))
                .BindAllInterfaces());

            this.Kernel.DefineDependency<IEditorPresenter, IContentPresenter>();
            this.Kernel.DefineDependency<IEditorPresenter, IClearToolPresenter>();
            this.Kernel.DefineDependency<IEditorPresenter, IAddToolPresenter>();
        }
    }
}
