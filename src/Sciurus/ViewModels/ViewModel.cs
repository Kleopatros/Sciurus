using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sciurus.ViewModels
{
    /// <summary>
    /// Base class for all application view models.
    /// </summary>
    public abstract class ViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Occurs when a property value has changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoked after a property has changed.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Sets the value of a property and invokes the <see cref="PropertyChanged"/> event. If
        /// the value to assign is equal to present value of the property, no action is performed.
        /// </summary>
        /// <typeparam name="T">The type of the property.</typeparam>
        /// <param name="field">The field storing the property value.</param>
        /// <param name="value">The value to assign the property.</param>
        /// <param name="propertyName">The name of the property.</param>
        /// <returns>
        /// <c>true</c> if the property value has changed; <c>false</c> if <paramref name="field"/>
        /// was already equal to <paramref name="value"/>.
        /// </returns>
        protected bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;

                this.OnPropertyChanged(propertyName);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gets a property value.
        /// </summary>
        /// <typeparam name="T">The type of the property.</typeparam>
        /// <param name="field">The field storing the property value.</param>
        /// <returns>The value of <paramref name="field"/>.</returns>
        protected T Get<T>(ref T field)
        {
            return field;
        }
    }
}
