namespace static_extension_HW.Models
{
    internal class Group
    {
        private int _studentcount;
        public string GroupNo { get; set; }
        public int StudentLimit { get; set; }
        private Student[] Students;

        public Group(string groupno, int studentlimit)
        {
            if (!CheckGroupNo(groupno))
            {
                Console.WriteLine("Invalid Group");
            }
            else if (studentlimit < 5 || studentlimit > 18)
            {
                Console.WriteLine("Not enough students");
            }

            GroupNo = groupno;
            StudentLimit = studentlimit;
            Students = new Student[0];
        }

        public bool CheckGroupNo(string groupno)
        {
            if (groupno.Length == 5)
                if (char.IsUpper(groupno[0]) && char.IsUpper(groupno[1]))
                    if (char.IsDigit(groupno[2]) && char.IsDigit(groupno[3]) && char.IsDigit(groupno[4]))
                        return true;

            return false;
        }

        public void AddStudent(Student student)
        {
            if (_studentcount < 5)
            {
                Console.WriteLine("There must be at least 5 students");
                return;
            }
            else if (_studentcount >= StudentLimit)
            {
                Console.WriteLine("The group is full");
                return;
            }

            Array.Resize(ref Students, _studentcount + 1);
            Students[_studentcount] = student;
            _studentcount++;
            Console.WriteLine($"Student {student.FullName} is now in group {GroupNo}");
        }

        public Student GetStudent(int id)
        {
            foreach (var student in Students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

        public Student[] GetAllStudents()
        {
            return Students;
        }
    }
}