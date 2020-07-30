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
            Window shell = this.CreateShell();
            if (shell != null)
            {
                this.InitializeShell(shell);
            }

            this.OnInitialized();
        }

        /// <summary>
        /// Creates the shell or main window of the application.
        /// </summary>
        /// <returns>The shell of the application.</returns>
        private Window CreateShell()
        {
            ShellViewModel shellViewModel = new ShellViewModel();
            Shell shell = new Shell() { DataContext = shellViewModel };
            return shell;
        }

        /// <summary>
        /// Initializes the shell.
        /// </summary>
        private void InitializeShell(Window shell)
        {
            this.MainWindow = shell;
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
