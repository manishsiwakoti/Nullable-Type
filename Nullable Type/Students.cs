using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable_Type
    {
    class Students
        {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int? SAT { get; set; }
        public double GPA { get; set; }

        public Students(int id, string fullname, int? sat, double gpa)
            {
            Id = id;
            FullName = fullname;
            SAT = sat;
            GPA = gpa;

            }
        
       




        }
    }
