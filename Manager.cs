using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Lab1
{
    public class Manager : Employee
    {
        private int workingDays;
        // bật lương vd: 1.8 -> float
        private float salaryLevel;
        private string position;

        public Manager()
        {
        }

        public Manager(int workingDays, float salaryLevel, string position)
        {
            this.workingDays = workingDays;
            this.salaryLevel = salaryLevel;
            this.position = position;
        }

        public Manager(string name, int yearOfBirth, string degree, int workingDays, float salaryLevel, string position)
        {
            Name = name;
            YearOfBirth = yearOfBirth;
            Degree = degree;
            Salary = workingDays * salaryLevel;
            this.workingDays = workingDays;
            this.salaryLevel = salaryLevel;
            this.position = position;
        }

        public int WorkingDays
        {
            get => workingDays;
            set => workingDays = value;
        }

        public float SalaryLevel
        {
            get => salaryLevel;
            set => salaryLevel = value;
        }


        public string Position
        {
            get => position;
            set => position = value ?? throw new ArgumentNullException(nameof(value));
        }

        public void ToString()
        {
            Console.WriteLine("Tên nhân viên: " + Name);
            Console.WriteLine("Năm sinh: " + YearOfBirth);
            Console.WriteLine("Bằng cấp: " + Degree);
            Console.WriteLine("Lương: " + Salary);
            Console.WriteLine("Chức vụ: " + Position);
        }
    }
