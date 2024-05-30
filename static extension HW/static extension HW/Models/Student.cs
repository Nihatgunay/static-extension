using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_extension_HW.Models
{
    internal class Student
    {
        private static int _count;
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Point { get; set; }

        static Student()
        {
            _count = 0;
        }
        public Student(string fullname, string point)
        {
            _count++;
            Id = _count;
            FullName = fullname;
            Point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Fullname: {FullName}");
            Console.WriteLine($"Point: {Point}");
        }
    }
}
