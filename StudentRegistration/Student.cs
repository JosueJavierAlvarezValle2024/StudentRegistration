using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    internal class Student : Person
    {
        private Func<string> toString;
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private DateTime dateTime;

        public string Tuition { get; set; }
        public string Career { get; set; }
        public double Average { get; set; }

        public Student(double average,string career,string tuition ,string name, string fatherLN, string motherLN, DateTime birthdai) : base(name, fatherLN, motherLN, birthdai)
        {
        
            this.Tuition = tuition;
            this.Career = career;
            this.Average = average;
        }

       

        public override string ToString()
        {
            return base.ToString() + " "+Tuition + " "+Career + " "+Average;
        }
    }
}
