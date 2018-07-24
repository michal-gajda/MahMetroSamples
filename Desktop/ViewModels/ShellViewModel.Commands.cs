namespace Gajda.ProofOfConcept.MahMetroSample.Desktop.ViewModels
{
    using Gajda.ProofOfConcept.MahMetroSample.Desktop.Views;
    using Prism.Commands;
    using System.Windows.Input;

    public sealed partial class ShellViewModel
    {
        public ICommand ExitCommand
        {
            get => new DelegateCommand(() => { this.IsClose = true; });
        }

        public ICommand SettingsCommand
        {
            get => new DelegateCommand(() =>
            {
                var viewModel = new SettingsWindowViewModel(this.dialogService, this.eventAggregator, this.loggerFacade);
                var result = this.dialogService.ShowDialog<SettingsWindowView>(this, viewModel);
            });
        }
    }
}
