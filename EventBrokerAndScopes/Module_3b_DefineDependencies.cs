namespace EventBrokerAndScopes
{
    using EventBrokerAndScopes.Content;
    using EventBrokerAndScopes.Editor;
    using EventBrokerAndScopes.Tools;

    using Ninject.Extensions.bbvEventBroker;
    using Ninject.Extensions.Conventions;
    using Ninject.Extensions.DependencyCreation;
    using Ninject.Extensions.Factory;
    using Ninject.Modules;

    public class Module_3b : NinjectModule
    {
        private const string EditorEventBrokerName = "EditorEventBroker";

        public override void Load()
        {
            this.Kernel.Bind(x => x
                .FromThisAssembly().SelectAllClasses().Where(t => t.Name.EndsWith("Presenter"))
                .BindAllInterfaces()
                .Configure(b => b
                    .RegisterOnEventBroker(EditorEventBrokerName)
                    .OnActivation<IPresenter>(o => o.Initialize()))
                .ConfigureFor<EditorPresenter>(b => b
                    .InTransientScope()
                    .OwnsEventBroker(EditorEventBrokerName)));

            this.Bind<IEditorFactory>().ToFactory();

            this.Kernel.Bind(x => x
                .FromThisAssembly().SelectAllClasses().Where(t => t.Name.EndsWith("View"))
                .BindAllInterfaces()
                .Configure((b, c) => b.When(r => r.Target.Member.DeclaringType.Name == c.Name.Replace("View", "Presenter")))
                );

            this.Kernel.DefineDependency<IEditorPresenter, IContentPresenter>();
            this.Kernel.DefineDependency<IEditorPresenter, IClearToolPresenter>();
            this.Kernel.DefineDependency<IEditorPresenter, IDateToolPresenter>();
        }
    }
}
