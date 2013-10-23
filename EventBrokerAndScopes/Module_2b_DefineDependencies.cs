namespace EventBrokerAndScopes
{
    using EventBrokerAndScopes.Content;
    using EventBrokerAndScopes.Editor;

    using Ninject.Extensions.bbvEventBroker;
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
            this.Kernel.DefineDependency<IEditorPresenter, IContentPresenter>();
            this.Kernel.DefineDependency<IEditorPresenter, IClearToolPresenter>();
            this.Kernel.DefineDependency<IEditorPresenter, IDateToolPresenter>();

            this.Kernel.Bind(x => x
                .FromThisAssembly().SelectAllClasses().Where(t => t.Name.EndsWith("Presenter"))
                .BindAllInterfaces()
                .Configure(b => b
                    .RegisterOnGlobalEventBroker()
                    .OnActivation<IPresenter>(o => o.Initialize())));

            this.Bind<IEditorFactory>().ToFactory();

            this.Kernel.Bind(x => x
                .FromThisAssembly().SelectAllClasses().Where(t => t.Name.EndsWith("View"))
                .BindAllInterfaces()
                .Configure((b, c) => b.When(r => r.Target.Member.DeclaringType.Name == c.Name.Replace("View", "Presenter")))
                );
        }
    }
}
