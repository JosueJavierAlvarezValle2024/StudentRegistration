using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    internal class NamePerson
    {
        public string Name { get; set; }

        public string FatherLN { get; set; }
        public string MotherLN { get; set; }


        public NamePerson(string name, string fatherLN, string motherLN)
        {
            this.Name = name;
            this.FatherLN = fatherLN;
            this.MotherLN = motherLN;
        }
        public override string ToString()
        {
            return (Name + " " + FatherLN + " " + MotherLN + " ");
        }
    }
}
