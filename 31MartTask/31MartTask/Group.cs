using System;
using System.Collections.Generic;
using System.Text;

namespace _31MartTask
{
    internal class Group
    {
        public Group(Type type)
        {
            this.Type = type;


            switch (type)
            {
                case Type.programming:
                   
                    _noP++;
                    No = "P" + _noP;
                    break;
                case Type.design:
                    
                    _noD++;
                    No = "D" + _noD;
                    break;
                case Type.system:
                    
                    _noS++;
                    No = "S" + _noS;
                    break;
                default:
                    break;
            }


        }
        public string No { get;}
        private static int _noP = 100 ;
        private static int _noS = 100;
        private static int _noD = 100;
        public Type Type { get; set; }
        public Student[] students = new Student[0]; 


        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length+1);
            students[students.Length-1] =student;
        }
        public Student FindFindStudentByNo(int? no)
        {
            foreach (var item in students)
            {
                if (item.No == no)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
