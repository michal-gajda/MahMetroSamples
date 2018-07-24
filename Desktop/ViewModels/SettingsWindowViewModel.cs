namespace Gajda.ProofOfConcept.MahMetroSample.Desktop.ViewModels
{
    using MvvmDialogs;
    using Prism.Events;
    using Prism.Logging;
    using Prism.Mvvm;
    using System;

    public sealed partial class SettingsWindowViewModel : BindableBase, IDisposable, IModalDialogViewModel
    {
        private readonly IDialogService dialogService;
        private readonly IEventAggregator eventAggregator;
        private readonly ILoggerFacade loggerFacade;
        private volatile bool disposed;

        public SettingsWindowViewModel(IDialogService dialogService, IEventAggregator eventAggregator, ILoggerFacade loggerFacade)
        {
            this.dialogService = dialogService;
            this.eventAggregator = eventAggregator;
            this.loggerFacade = loggerFacade;
        }

        ~SettingsWindowViewModel()
        {
            this.Dispose(false);
        }

        public bool? DialogResult { get; private set; }

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