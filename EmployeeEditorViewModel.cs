using System;
using System.ComponentModel;
using System.Windows;

namespace EmployeeEditorApp.ViewModels
{
    public class EmployeeEditorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly Employee employee;

        public EmployeeEditorViewModel(Employee employee)
        {
            this.employee = employee;
            PaymentTypes = Enum.GetValues(typeof(PaymentType));
        }

        public string Name
        {
            get => employee.Name;
            set
            {
                employee.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public PaymentType PaymentType
        {
            get => employee.PaymentType;
            set
            {
                employee.PaymentType = value;
                OnPropertyChanged(nameof(PaymentType));
                OnPropertyChanged(nameof(HoursVisibility));
            }
        }

        public decimal SalaryOrRate
        {
            get => employee.SalaryOrRate;
            set
            {
                employee.SalaryOrRate = value;
                OnPropertyChanged(nameof(SalaryOrRate));
            }
        }

        public int HoursWorked
        {
            get => employee.HoursWorked;
            set
            {
                employee.HoursWorked = value;
                OnPropertyChanged(nameof(HoursWorked));
            }
        }

        public Array PaymentTypes { get; }

        public Visibility HoursVisibility => PaymentType == PaymentType.Hourly ? Visibility.Visible : Visibility.Collapsed;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
