namespace EventBrokerAndScopes
{
    using System;
    using System.Windows.Forms;

    using Ninject;
    using Ninject.Modules;

    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            
            var kernel = InitializeKernel();
            var applicationMainForm = kernel.Get<MainForm>();
            
            Application.Run(applicationMainForm);
        }

        private static IKernel InitializeKernel()
        {
            NinjectModule module = new Module();
            return new StandardKernel(module);
        }
    }
}
