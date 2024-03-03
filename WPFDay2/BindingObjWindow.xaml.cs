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
    /// Interaction logic for BindingObjWindow.xaml
    /// </summary>
    public partial class BindingObjWindow : Window
    {
        public BindingObjWindow()
        {
            InitializeComponent();
          //  List<string> empName
           // cboxEmpList.ItemsSource = EmployeeSampleData.Emps;
           
        }
        Employee emp;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //id //ge //bind
            //int index =int.Parse(txtIndex.Text);
            //emp = EmployeeSampleData.Emps[index];
           // emp = (Employee)cboxEmpList.SelectedItem;
           // EmpPanel.DataContext = emp;
        }
    }
}
