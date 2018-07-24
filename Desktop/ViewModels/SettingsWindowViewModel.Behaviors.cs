namespace Gajda.ProofOfConcept.MahMetroSample.Desktop.ViewModels
{
    using Prism.Commands;
    using System.Windows.Input;

    public sealed partial class SettingsWindowViewModel
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
    }
}
