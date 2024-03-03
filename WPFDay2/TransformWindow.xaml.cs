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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFDay2
{
    /// <summary>
    /// Interaction logic for TransformWindow.xaml
    /// </summary>
    public partial class TransformWindow : Window
    {
        public TransformWindow()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            
            //create anima (width
            DoubleAnimation anim1=new DoubleAnimation();

            //confi
            anim1.From = 100; ;
            anim1.To = 300;
            anim1.Duration = TimeSpan.FromSeconds(5);
            anim1.AutoReverse = true;
            anim1.BeginTime = TimeSpan.FromSeconds(1);
            //connect 
            rect1.BeginAnimation(Rectangle.WidthProperty, anim1);
            rect1.BeginAnimation(Rectangle.HeightProperty, anim1);
        }
    }
}
