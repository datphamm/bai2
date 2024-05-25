using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Lab1
{
    public class Prog
    {
        public static void Main()
        {
            int n;
            Console.Write("Nhập số lượng NV: ");
            n = int.Parse(Console.ReadLine());
            ArrayList ds = ThemNV(n);

            InDanhSachNV(ds);


        }

        public static ArrayList ThemNV(int n)
        {
            ArrayList ds = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Tên nhân viên: ");
                string name = Console.ReadLine();

                Console.WriteLine("Năm sinh: ");
                int yearOfBirth = int.Parse(Console.ReadLine());

                Console.WriteLine("Bằng cấp: ");
                string degree = Console.ReadLine();

                Console.WriteLine("Chức vụ (Khoa học/1) | (Quản lý/2) | (Nhân viên/3): ");
                int job = int.Parse(Console.ReadLine());
                if (job == 3)
                {
                    Console.WriteLine("Nhập lương khoán của nhân viên: ");
                    float salary = float.Parse(Console.ReadLine());
                    ds.Add(new Employee(name, yearOfBirth, degree, salary));
                }
                else
                {
                    Console.WriteLine("Nhập chức vụ của nhân viên: ");
                    string positon = Console.ReadLine();

                    Console.WriteLine("Nhập số ngày công: ");
                    int workingDays = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nhập bật lương: ");
                    float salaryLevel = float.Parse(Console.ReadLine());

                    if (job == 1)
                    {
                        Console.WriteLine("Nhập số bài báo đã công bố: ");
                        int articles = int.Parse(Console.ReadLine());
                        ds.Add(new Scientist(name, yearOfBirth, degree, workingDays, salaryLevel, positon, articles));
                        continue;
                    }

                    ds.Add(new Manager(name, yearOfBirth, degree, workingDays, salaryLevel, positon));
                }
            }
            return ds;
        }

        public static void InDanhSachNV(ArrayList ds)
        {
            float ScientistSalary = 0;
            float ManagerSalary = 0;
            float EmployeeSalary = 0;
            foreach (var nv in ds)
            {
                if (nv.GetType() == typeof(Scientist))
                {
                    Scientist show = (Scientist)nv;
                    show.ToString();
                    ScientistSalary += show.Salary;
                }
                else if (nv.GetType() == typeof(Manager))
                {
                    Manager show = (Manager)nv;
                    show.ToString();
                    ManagerSalary += show.Salary;
                }
                else
                {
                    Employee show = (Employee)nv;
                    show.ToString();
                    EmployeeSalary += show.Salary;
                }
                Console.WriteLine("---------------------------------------");
            }

            Console.WriteLine("Tổng lương phải trả cho các nhà khoa học: " + ScientistSalary);
            Console.WriteLine("Tổng lương phải trả cho các nhà quản lý: " + ManagerSalary);
            Console.WriteLine("Tổng lương phải trả cho các nhân viên: " + EmployeeSalary);
        }
    }
}
