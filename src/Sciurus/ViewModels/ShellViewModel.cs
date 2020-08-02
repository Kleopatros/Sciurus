using System.Collections.ObjectModel;

namespace Sciurus.ViewModels
{
    /// <summary>
    /// View model for the application shell.
    /// </summary>
    public class ShellViewModel : ViewModel
    {
        private string _title;

        private ObservableCollection<PartitionViewModel> _partitions;
        private PartitionViewModel _selectedPartition;

        /// <summary>
        /// Intializes a new <see cref="ShellViewModel"/> instance.
        /// </summary>
        public ShellViewModel()
        {
            // TODO: placeholders
            this.Title = "Workspace - Sciurus";
            this.Partitions = new ObservableCollection<PartitionViewModel>();
            this.Partitions.Add(new PartitionViewModel() { Name = "Default" });
            this.Partitions.Add(new PartitionViewModel() { Name = "Partition 1" });
            this.SelectedPartition = this.Partitions[0];
        }

        /// <summary>
        /// Gets the window's title.
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
        /// Gets the collection of workspace partitions.
        /// </summary>
        public ObservableCollection<PartitionViewModel> Partitions
        {
            get
            {
                return this.Get(ref _partitions);
            }

            private set
            {
                this.Set(ref _partitions, value);
            }
        }

        /// <summary>
        /// Gets or sets the selected partition.
        /// </summary>
        public PartitionViewModel SelectedPartition
        {
            get
            {
                return this.Get(ref _selectedPartition);
            }

            set
            {
                this.Set(ref _selectedPartition, value);
            }
        }
    }
}
