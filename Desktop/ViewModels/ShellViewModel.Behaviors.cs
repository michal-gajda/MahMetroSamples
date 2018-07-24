namespace Gajda.ProofOfConcept.MahMetroSample.Desktop.ViewModels
{
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Input;
    using Prism.Commands;

    public sealed partial class ShellViewModel
    {
        private bool isClose;

        public bool IsClose
        {
            get => this.isClose;

            set => this.SetProperty(ref this.isClose, value);
        }

        public ICommand WindowClosedCommand
        {
            get => new DelegateCommand(this.Dispose);
        }

        public ICommand WindowClosingCommand
        {
            get => new DelegateCommand<CancelEventArgs>(
                e =>
                {
                    var result = this.dialogService.ShowMessageBox(
                        this,
                        "Do you want to close this window",
                        "Question...",
                        MessageBoxButton.YesNo);
                    e.Cancel = result != MessageBoxResult.Yes;
                });
        }
    }
}
