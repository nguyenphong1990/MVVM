using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VMMW.View
{
    /// <summary>
    /// Interaction logic for BuubleMatricView.xaml
    /// </summary>
    public partial class BuubleMatricView : ItemsControl
    {
        public BuubleMatricView()
        {
            InitializeComponent();
        }
        private BubbleCanvas _bubbleCanvas;

        internal int ColumnCount = 8;

        /// <summary>Returns the number of rows in the bubble matrix.</summary>
        internal int RowCount = 8;


        internal event EventHandler MatrixDimensionsAvailable;
        private void HandleBubbleCanvasLoaded(object sender, RoutedEventArgs e)
        {
            // Store a reference to the panel that contains the bubbles.
            _bubbleCanvas = sender as BubbleCanvas;
            RaiseMatrixDimensionsAvailable();
        }

        private void RaiseMatrixDimensionsAvailable()
        {
            MatrixDimensionsAvailable?.Invoke(this, EventArgs.Empty);
        }
    }
}
