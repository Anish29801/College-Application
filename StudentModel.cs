using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Application
{
    public class StudentModel
    {
        // Student Model
        private string studentName = string.Empty;
        private int studentRoll = 0;
        private int studentMarks = 0;

        // Student Properties
        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }
        public int StudentRoll
        {
            get
            {
                return studentRoll;
            }
            set
            {
                studentRoll = value;
            }
        }
        public int StudentMarks
        {
            get
            {
                return studentMarks;
            }
            set
            {
                studentMarks = value;
            }
        }
    }
}
