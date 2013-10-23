namespace EventBrokerAndScopes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using EventBrokerAndScopes.Content;
    using EventBrokerAndScopes.Editor;
    using EventBrokerAndScopes.Tools;

    using Ninject.Extensions.bbvEventBroker;
    using Ninject.Extensions.Conventions;
    using Ninject.Extensions.Conventions.BindingBuilder;
    using Ninject.Extensions.Conventions.BindingGenerators;
    using Ninject.Extensions.DependencyCreation;
    using Ninject.Extensions.Factory;
    using Ninject.Extensions.NamedScope;
    using Ninject.Modules;
    using Ninject.Syntax;

    public class Module_5 : NinjectModule
    {
        private const string EditorEventBrokerName = "EditorEventBroker";
        private const string EditorScopeName = "EditorScope";

        public override void Load()
        {
            this.Kernel.DefineDependency<IEditorPresenter, IContentPresenter>();

            this.Kernel.Bind(x => x
                .FromThisAssembly().SelectAllClasses().InheritedFrom<IToolPresenter>()
                .BindWith(new DefaultInterfaceBindingGenerator(new BindableTypeSelector(), new DependencyCreationBindingCreator()))); 
            
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

            this.Bind<IEditorFactory>().ToFactory();

            this.Kernel.Bind(x => x
                .FromThisAssembly().SelectAllClasses().Where(t => t.Name.EndsWith("View"))
                .BindAllInterfaces()
                .Configure((b, c) => b.When(r => r.Target.Member.DeclaringType.Name == c.Name.Replace("View", "Presenter")))
                );
        }

        private class DependencyCreationBindingCreator : IBindingCreator
        {
            public IEnumerable<IBindingWhenInNamedWithOrOnSyntax<object>> CreateBindings(IBindingRoot bindingRoot, IEnumerable<Type> serviceTypes, Type implementationType)
            {
                typeof(DependencyCreationExtensionMethods)
                    .GetMethod("DefineDependency")
                    .MakeGenericMethod(typeof(IEditorPresenter), serviceTypes.Single())
                    .Invoke(null, new object[] { bindingRoot });

                return Enumerable.Empty<IBindingWhenInNamedWithOrOnSyntax<object>>();
            }
        }
    }
}
