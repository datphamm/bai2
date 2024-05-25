using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_Lab2
{
    internal class Student
    {
        private int ID;
        private string Khoa;
        private string TenSV;
        private float DiemTB;

        public Student() //Default constructor
        {
            ID = 1;
            TenSV = "Pham Xuan Dat";
            Khoa = "CNTT";
            DiemTB = 7;
        }

        public Student(Student stu) //Copy constructor
        {
            ID = stu.ID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }

        //Constructor with parameters
        public Student(int id, string ten, string kh, float dtb)
        {
            ID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        public int GetStudentId() => ID;
        public void SetStudentId(int value) => ID = value;

        public string getName() => TenSV;
        public void setName(string value) => TenSV = value;

        public string GetFaculty() => Khoa;
        public void SetFaculty(string value) => Khoa = value;

        public float GetMark() => DiemTB;
        public void SetMark(float value) => DiemTB = value;

        public void Show()
        {
            Console.WriteLine("ID: " + GetStudentId());
            Console.WriteLine("Họ và tên: " + getName());
            Console.WriteLine("Khoa: " + GetFaculty());
            Console.WriteLine("Điểm trung bình: " + GetMark());
        }

    }

}
   

