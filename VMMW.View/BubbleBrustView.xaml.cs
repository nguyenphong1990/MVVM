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
using VMMW.ViewModel;

namespace VMMW.View
{
    /// <summary>
    /// Interaction logic for BubbleBrustView.xaml
    /// </summary>
    public partial class BubbleBrustView : UserControl
    {
        public BubbleBrustView()
        {
            InitializeComponent();
            _bubbleMatrixView.MatrixDimensionsAvailable += HandleMatrixDimensionsAvailable;
        }

        private void HandleMatrixDimensionsAvailable(object sender, EventArgs e)
        {
            // Hook the keyboard event on the Window because this
            // control does not receive keystrokes.
            var window = Window.GetWindow(this);
        }
    }
}
