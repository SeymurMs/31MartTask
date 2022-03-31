using System;
using System.Collections.Generic;
using System.Text;

namespace _31MartTask
{
    internal class Student
    {
        public Student()
        {
            _no++;
            No = _no;
        }
        public int No { get;}
        private static int _no;
        public string Fullname { get; set; }
    }
}
