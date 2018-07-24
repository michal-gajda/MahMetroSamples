namespace Gajda.ProofOfConcept.MahMetroSample.Desktop.ViewModels
{
    using MvvmDialogs;
    using Prism.Events;
    using Prism.Logging;
    using Prism.Mvvm;
    using System;

    public sealed partial class ShellViewModel : BindableBase, IDisposable
    {
        private volatile bool disposed;
        private readonly IDialogService dialogService;
        private readonly IEventAggregator eventAggregator;
        private readonly ILoggerFacade loggerFacade;

        public ShellViewModel(IDialogService dialogService, IEventAggregator eventAggregator, ILoggerFacade loggerFacade)
        {
            this.dialogService = dialogService;
            this.eventAggregator = eventAggregator;
            this.loggerFacade = loggerFacade;
        }

        ~ShellViewModel()
        {
            this.Dispose(false);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {

            }

            this.disposed = true;
        }
    }
}
