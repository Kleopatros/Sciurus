namespace Sciurus.Windows
{
    using System.Windows.Data;
    using Sciurus.Properties;

    /// <summary>
    /// Provides high-level access to the definition of a settings binding, which connects the
    /// properties of binding target objects (typically, WPF elements), and the data source - the
    /// <see  cref="Settings.Default"/> instance.
    /// </summary>
    public class SettingsBinding : Binding
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsBinding"/> class.
        /// </summary>
        public SettingsBinding()
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsBinding"/> class with an initial
        /// path.
        /// </summary>
        /// <param name="path">The initial <see cref="Binding.Path"/> for the binding.</param>
        public SettingsBinding(string path)
            : base(path)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes the instance.
        /// </summary>
        private void Initialize()
        {
            this.Source = Settings.Default;
            this.Mode = BindingMode.TwoWay;
        }
    }
}
