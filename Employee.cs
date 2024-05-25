using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Lab1
{
    public class Employee
    {
        private string name;
        private int yearOfBirth;
        private string degree;
        private float salary;

        public Employee()
        {
        }

        public Employee(string name, int yearOfBirth, string degree, float salary)
        {
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.degree = degree;
            this.salary = salary;
        }

        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int YearOfBirth
        {
            get => yearOfBirth;
            set => yearOfBirth = value;
        }

        public string Degree
        {
            get => degree;
            set => degree = value ?? throw new ArgumentNullException(nameof(value));
        }

        public float Salary
        {
            get => salary;
            set => salary = value;
        }

        public void ToString()
        {
            Console.WriteLine("Tên nhân viên: " + Name);
            Console.WriteLine("Năm sinh: " + YearOfBirth);
            Console.WriteLine("Bằng cấp: " + Degree);
            Console.WriteLine("Lương: " + Salary);
        }
    }
}
