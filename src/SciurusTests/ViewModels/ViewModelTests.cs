namespace SciurusTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Sciurus.ViewModels;

    /// <summary>
    /// Tests the <see cref="ViewModel"/> class.
    /// </summary>
    [TestClass]
    public class ViewModelTests
    {
        /// <summary>
        /// Tests <see cref="ViewModel.Set{T}(ref T, T, string)"/> raises a
        /// <see cref="System.ComponentModel.INotifyPropertyChanged.PropertyChanged"/> event when
        /// the property value is changed.
        /// </summary>
        [TestMethod]
        public void SetRaisesPropertyChanged()
        {
            TestViewModel test = new TestViewModel();
            test.PropertyChanged += (sender, args) =>
            {
                Assert.AreSame(test, sender);
                Assert.AreEqual(nameof(TestViewModel.IntProperty), args.PropertyName);
            };

            test.IntProperty = 5;
        }

        /// <summary>
        /// Tests <see cref="ViewModel.Set{T}(ref T, T, string)"/> does not raise a
        /// <see cref="System.ComponentModel.INotifyPropertyChanged.PropertyChanged"/> event when
        /// the property value is set to the same value repeatedly.
        /// </summary>
        [TestMethod]
        public void SetRaisesPropertyChangedOnlyIfChanged()
        {
            int eventCount = 0;

            TestViewModel test = new TestViewModel();
            test.PropertyChanged += (sender, args) => eventCount++;

            test.IntProperty = 5;
            Assert.AreEqual(1, eventCount);

            test.IntProperty = 5;
            Assert.AreEqual(1, eventCount);

            test.IntProperty = 6;
            Assert.AreEqual(2, eventCount);
        }

        /// <summary>
        /// Tests <see cref="ViewModel.Get{T}(ref T)"/> returns the property value.
        /// </summary>
        [TestMethod]
        public void GetReturnsValue()
        {
            TestViewModel test = new TestViewModel();
            test.IntProperty = 5;
            Assert.AreEqual(5, test.IntProperty);
        }

        /// <summary>
        /// Facilitates testing of the <see cref="ViewModel"/> class, which is abstract.
        /// </summary>
        public class TestViewModel : ViewModel
        {
            private int _intProperty;

            /// <summary>
            /// Gets or sets an integer test property.
            /// </summary>
            public int IntProperty
            {
                get
                {
                    return this.Get(ref _intProperty);
                }

                set
                {
                    this.Set(ref _intProperty, value);
                }
            }
        }
    }
}
