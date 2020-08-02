namespace Sciurus.ViewModels
{
    /// <summary>
    /// View model for a workspace partition.
    /// </summary>
    public class PartitionViewModel : ViewModel
    {
        private string _name;

        /// <summary>
        /// Intializes a new <see cref="PartitionViewModel"/> instance.
        /// </summary>
        public PartitionViewModel()
        {
        }

        /// <summary>
        /// Gets or sets the partition name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.Get(ref _name);
            }

            set
            {
                this.Set(ref _name, value);
            }
        }
    }
}
