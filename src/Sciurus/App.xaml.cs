using System.Windows;
using Sciurus.ViewModels;
using Sciurus.Views;

namespace Sciurus
{
    /// <summary>
    /// Interaction logic for the application.
    /// </summary>
    /// <remarks>
    /// Implementation based on PrismApplicationBase.
    /// </remarks>
    /// <seealso cref="https://github.com/PrismLibrary/Prism"/>
    public partial class App : Application
    {
        /// <summary>
        /// Raises the <see cref="Application.Startup"/> event.
        /// </summary>
        /// <param name="e">A <see cref="StartupEventArgs"/> that contains the event data.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            this.Initialize();
        }

        /// <summary>
        /// Raises the <see cref="Application.Exit"/> event.
        /// </summary>
        /// <param name="e">An <see cref="ExitEventArgs"/> that contains the event data.</param>
        protected override void OnExit(ExitEventArgs e)
        {
            Sciurus.Properties.Settings.Default.Save();
            base.OnExit(e);
        }

        /// <summary>
        /// Runs the initialization sequence to configure the application.
        /// </summary>
        private void Initialize()
        {
            Window mainView = this.CreateMainView();
            if (mainView != null)
            {
                this.InitializeMainView(mainView);
            }

            this.OnInitialized();
        }

        /// <summary>
        /// Creates the main view of the application.
        /// </summary>
        /// <returns>The main view of the application.</returns>
        private Window CreateMainView()
        {
            MainViewModel mainViewModel = new MainViewModel();
            MainView mainView = new MainView() { DataContext = mainViewModel };
            return mainView;
        }

        /// <summary>
        /// Initializes the main view.
        /// </summary>
        private void InitializeMainView(Window mainView)
        {
            this.MainWindow = mainView;
        }

        /// <summary>
        /// Contains actions that should occur last in the initialization sequence.
        /// </summary>
        private void OnInitialized()
        {
            this.MainWindow?.Show();
        }
    }
}
