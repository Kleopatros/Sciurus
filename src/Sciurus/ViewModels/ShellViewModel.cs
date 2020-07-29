namespace Sciurus.ViewModels
{
    /// <summary>
    /// View model for the application shell.
    /// </summary>
    public class ShellViewModel : ViewModel
    {
        private string _title;
        private double _width;
        private double _height;
        private double _detailsViewWidth;
        private double _contentDetailsViewHeight;

        /// <summary>
        /// Intializes a new <see cref="ShellViewModel"/> instance.
        /// </summary>
        public ShellViewModel()
        {
            // TODO: placeholders
            this.Title = "Partition - Sciurus";
            this.Width = 1500;
            this.Height = 300;
            this.DetailsViewWidth = 250;
            this.ContentDetailsViewHeight = 600;
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

        /// <summary>
        /// Gets or sets the width of the window in device-independent units (1/96th inch per unit).
        /// This value must be equal to or greater than 0.0.
        /// </summary>
        public double Width
        {
            get
            {
                return this.Get(ref _width);
            }

            set
            {
                this.Set(ref _width, value);
            }
        }

        /// <summary>
        /// Gets or sets the height of the window in device-independent units (1/96th inch per unit).
        /// This value must be equal to or greater than 0.0.
        /// </summary>
        public double Height
        {
            get
            {
                return this.Get(ref _height);
            }

            set
            {
                this.Set(ref _height, value);
            }
        }

        /// <summary>
        /// Gets or sets the width of the details view in device-independent units (1/96th inch per
        /// unit). This value must be equal to or greater than 0.0.
        /// </summary>
        public double DetailsViewWidth
        {
            get
            {
                return this.Get(ref _detailsViewWidth);
            }

            set
            {
                this.Set(ref _detailsViewWidth, value);
            }
        }

        /// <summary>
        /// Gets or sets the height of the content details view in device-independent units (1/96th
        /// inch per unit). This value must be equal to or greater than 0.0.
        /// </summary>
        public double ContentDetailsViewHeight
        {
            get
            {
                return this.Get(ref _contentDetailsViewHeight);
            }

            set
            {
                this.Set(ref _contentDetailsViewHeight, value);
            }
        }
    }
}
