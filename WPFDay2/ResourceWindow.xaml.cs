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
    /// Interaction logic for ResourceWindow.xaml
    /// </summary>
    public partial class ResourceWindow : Window
    {
        public ResourceWindow()
        {
            /*
             x:class x:name x:static  x:key
             */
            InitializeComponent();
            //double
            //type key value
            //txt1.FontSize //double <string ,object> decalare vaiblye 
            //txt1.Margin thickness
            //txt1.Background   brush
            //txt1.FontFamily   FontFamily
            //txt1.res[""]
            
            
        }
        public int Age { get; set; }
    }
}
