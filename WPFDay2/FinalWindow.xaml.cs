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
using System.Windows.Shapes;

namespace WPFDay2
{
    /// <summary>
    /// Interaction logic for FinalWindow.xaml
    /// </summary>
    public partial class FinalWindow : Window
    {


        public int ITI
        {
            get { return (int)GetValue(ITIProperty); }
            set { SetValue(ITIProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ITIProperty =
            DependencyProperty.Register("ITI", typeof(int),
                typeof(FinalWindow), new PropertyMetadata(44));




        public FinalWindow()
        {
            InitializeComponent();
           //btn1.BeginAnimation(Button.WidthProperty,)
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Enter Button");
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("Enter Grid");

        }

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
         //   MessageBox.Show("Enter Window");

        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Enter Window");

        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Enter button");

        }
    }
}
