﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations;
using System.IO.Packaging;
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
    /// Interaction logic for DataCollector.xaml
    /// </summary>
    public partial class DataCollector : Page
    {
        private FacultyDBEntities faculty = new FacultyDBEntities();

        public DataCollector()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FacultyEmployee emp = new FacultyEmployee();
                emp.fac_Name = txtName.Text;
                emp.fac_Age = txtAge.Text;
                emp.fac_Address = txtAddress.Text;
                emp.fac_Depa = txtDep.Text;

                faculty.FacultyEmployees.AddOrUpdate(emp);
                faculty.SaveChanges();
                MessageBox.Show("Data Saved Successefuly!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            txtName.Text = txtAge.Text = txtAddress.Text = txtDep.Text = string.Empty;
        }

        private void btnOpenData_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text != "")
            {                
                Page2 page2 = new Page2(txtName.Text);
                this.NavigationService.Navigate(page2);
            }
            else
                MessageBox.Show("Please fill name text box!");
        }
    }
}
