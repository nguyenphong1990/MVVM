using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMMW.ViewModel
{
    public class BubbleViewModel : INotifyPropertyChanged
    {
        internal BubbleViewModel(BubbleBrustMatrixModel bubbleMatrix, int row, int column)
        {
            Column = column;
            Row = row;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
        }

        public int Column;
        public int Row;
    }
}
