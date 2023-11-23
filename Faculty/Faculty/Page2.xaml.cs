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

namespace Faculty
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        FacultyDBEntities faculty = new FacultyDBEntities();
        public Page2(string Name)
        {
            InitializeComponent();
            EmployeeData.ItemsSource = faculty.FacultyEmployees.Where(x => x.fac_Name == Name).ToList();

        }

        private void EmployeeData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
