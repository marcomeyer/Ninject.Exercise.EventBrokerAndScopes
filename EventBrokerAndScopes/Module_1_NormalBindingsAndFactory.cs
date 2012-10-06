namespace EventBrokerAndScopes
{
    using Ninject.Extensions.Conventions;
    using Ninject.Extensions.Factory;
    using Ninject.Modules;

    public class Module_1 : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IEditorFactory>().ToFactory();

            this.Kernel.Bind(x => x
                .FromThisAssembly().SelectAllClasses().Where(t => t.Name.EndsWith("Presenter"))
                .BindAllInterfaces()
                .Configure(b => b.OnActivation<IPresenter>(o => o.Initialize())));
            
            this.Kernel.Bind(x => x
                .FromThisAssembly().SelectAllClasses().Where(t => t.Name.EndsWith("View"))
                .BindAllInterfaces());
        }
    }
}
