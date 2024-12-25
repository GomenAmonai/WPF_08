using System.ComponentModel;

namespace EmployeeEditorApp.Models
{
    public class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        private PaymentType paymentType;
        private decimal salaryOrRate;
        private int hoursWorked;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public PaymentType PaymentType
        {
            get => paymentType;
            set
            {
                paymentType = value;
                OnPropertyChanged(nameof(PaymentType));
            }
        }

        public decimal SalaryOrRate
        {
            get => salaryOrRate;
            set
            {
                salaryOrRate = value;
                OnPropertyChanged(nameof(SalaryOrRate));
            }
        }

        public int HoursWorked
        {
            get => hoursWorked;
            set
            {
                hoursWorked = value;
                OnPropertyChanged(nameof(HoursWorked));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public enum PaymentType
    {
        FixedSalary,
        Hourly,
        PerProject
    }
}
