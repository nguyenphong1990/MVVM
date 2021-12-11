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
using System.Windows.Navigation;
using System.Windows.Shapes;
using VMMW.ViewModel;

namespace VMMW.View
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class BubbleView : Button
    {
        private BubbleViewModel _bubble;
        public BubbleView()
        {
            InitializeComponent();
            DataContextChanged += HandleDataContextChanged;
        }

        void HandleDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            _bubble = e.NewValue as BubbleViewModel;
        }

        void HandleMouseEnter(object sender, MouseEventArgs e)
        {
            if (_bubble != null)
            {
            }
        }

        void HandleMouseLeave(object sender, MouseEventArgs e)
        {
            if (_bubble != null)
            {
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Background = Brushes.Green;
        }
    }
}
