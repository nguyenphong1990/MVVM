using MvvmFoundation.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMMW.ViewModel
{
    public class BubbleBrustMatrixModel : ObservableObject
    {
        private readonly BubbleFactory _bubbleFactory;
        private readonly ObservableCollection<BubbleViewModel> _bubblesInternal;
        private bool _isIdle;
        internal BubbleBrustMatrixModel()
        {
            _bubblesInternal = new ObservableCollection<BubbleViewModel>();
            Bubbles = new ReadOnlyObservableCollection<BubbleViewModel>(_bubblesInternal);
            _bubbleFactory = new BubbleFactory(this);
        }
        public ReadOnlyObservableCollection<BubbleViewModel> Bubbles { get; private set; }
        internal void AddBubble(BubbleViewModel bubble)
        {
            if (bubble == null)
                throw new ArgumentNullException("bubble");

            _bubblesInternal.Add(bubble);
        }

        internal int ColumnCount = 8;

        /// <summary>Gets or sets the row count.</summary>
        internal int RowCount { get; set; }

        public bool IsIdle
        {
            get { return _isIdle; }
            internal set
            {
                if (value.Equals(_isIdle))
                    return;

                _isIdle = value;

                RaisePropertyChanged("IsIdle");
            }
        }
    }
}
