using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using System.Windows.Media;

namespace Curling.Controls
{
    /// <summary>
    /// Interaction logic for GyroBox.xaml
    /// </summary>
    public partial class GyroBox : UserControl
    {
        private GyroBox gyroBox;
        TranslateTransform transform = new TranslateTransform();

        public GyroBox()
        {
            InitializeComponent();
            gyroBox = this;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
        }

        private void Thumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            transform.X += e.HorizontalChange;
            transform.Y += e.VerticalChange;
            gyroThumb.RenderTransform = transform;
        }
    }
}
