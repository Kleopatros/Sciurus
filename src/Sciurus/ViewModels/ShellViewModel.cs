namespace Sciurus.ViewModels
{
    /// <summary>
    /// View model for the application shell.
    /// </summary>
    public class ShellViewModel : ViewModel
    {
        private string _title;

        /// <summary>
        /// Intializes a new <see cref="ShellViewModel"/> instance.
        /// </summary>
        public ShellViewModel()
        {
            // TODO: placeholders
            this.Title = "Partition - Sciurus";
        }

        /// <summary>
        /// Gets or sets the window's title.
        /// </summary>
        public string Title
        {
            get
            {
                return this.Get(ref _title);
            }

            private set
            {
                this.Set(ref _title, value);
            }
        }
    }
}
