using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Lab1
{
   

    // nhà khoa học có mang tất cả tính chất của quản lý (chức vụ, bật lương)
    public class Scientist : Manager
    {
        // số bài báo xuất bản - published articles
        private int articles;

        public Scientist()
        {
        }

        public Scientist(int articles)
        {
            this.articles = articles;
        }

        public Scientist(int workingDays, float salaryLevel, string position, int articles) : base(workingDays, salaryLevel, position)
        {
            this.articles = articles;
        }

        public Scientist(string name, int yearOfBirth, string degree, int workingDays, float salaryLevel, string position, int articles) : base(name, yearOfBirth, degree, workingDays, salaryLevel, position)
        {
            this.articles = articles;
        }


        public int Articles
        {
            get => articles;
            set => articles = value;
        }

        public void ToString()
        {
            Console.WriteLine("Tên nhân viên: " + Name);
            Console.WriteLine("Năm sinh: " + YearOfBirth);
            Console.WriteLine("Bằng cấp: " + Degree);
            Console.WriteLine("Lương: " + Salary);
            Console.WriteLine("Chức vụ: " + Position);
            Console.WriteLine("Bài báo công bố: " + Articles);
        }
    }
}
