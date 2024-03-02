using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDay2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Shape form = new Shape();
            form.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StretchShapeWindow form=new StretchShapeWindow();
            form.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ResourceWindow form = new ResourceWindow();
            form.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            StyleWindow win = new StyleWindow();
            win.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TriggerWindow win = new TriggerWindow();
            win.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            BrushWindow win = new BrushWindow();
            win.Show();
            //-----------------
        }
    }
}