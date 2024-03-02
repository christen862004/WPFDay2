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
    /// Interaction logic for Shape.xaml
    /// </summary>
    public partial class Shape : Window
    {
        public Shape()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("I'm Rect");
        }

        private void Ellipse_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("I'm Elleipse");
        }
    }
}
