using System.Windows;
using EmployeeEditorApp.Models;
using EmployeeEditorApp.ViewModels;

namespace EmployeeEditorApp.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

 
            Employee employee = new Employee
            {
                Name = "John Doe",
                PaymentType = PaymentType.FixedSalary,
                SalaryOrRate = 5000
            };


            DataContext = new EmployeeEditorViewModel(employee);
        }
    }
}
