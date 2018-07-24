namespace Gajda.ProofOfConcept.MahMetroSample.Desktop.ViewModels
{
    using Prism.Commands;
    using System.Windows.Input;

    public sealed partial class SettingsWindowViewModel
    {
        public ICommand CancelCommand
        {
            get => new DelegateCommand(() =>
            {
                this.DialogResult = false;
                this.IsClose = true;
            });
        }

        public ICommand OkCommand
        {
            get => new DelegateCommand(() =>
            {
                this.DialogResult = true;
                this.IsClose = true;
            });
        }
    }
}
