namespace Gajda.ProofOfConcept.MahMetroSample.Desktop.ViewModels
{
    public sealed partial class ShellViewModel
    {
        private string title = "Sample";

        public string Title
        {
            get => this.title;
            set => this.SetProperty(ref this.title, value);
        }
    }
}
