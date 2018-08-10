namespace Gajda.ProofOfConcept.MahMetroSample.Desktop
{
    using MvvmDialogs;
    using Prism.Ioc;
    using Prism.Logging;
    using Prism.Modularity;
    using Prism.Unity;
    using System.Windows;
    using Views;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected virtual ILoggerFacade CreateLogger()
        {
            return new TextLogger();
        }

        protected override Window CreateShell()
        {
            return this.Container.Resolve<ShellView>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var logger = this.Container.Resolve<ILoggerFacade>();
            logger.Log("OnStartup", Category.Info, Priority.None);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            var logger = this.Container.Resolve<ILoggerFacade>();
            logger.Log("OnExit", Category.Info, Priority.None);

            base.OnExit(e);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance<IDialogService>(new DialogService());
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
        }
    }
}
