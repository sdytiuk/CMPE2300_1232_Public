using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class People
    {
        readonly int socialInsuranceNumber;
        string firstname, lastname;

        //CTOR (birth of a people)
        //all classes come with a default constructor
        //that initializes everything to defaults

        //override the free default CTOR?
        public People()
        {
            socialInsuranceNumber = 0;
            firstname = "Adam";
            lastname = "";
        }

        //what if you want to specify assignments?
        public People(string fName, string lastname, int socialInsuranceNumber)
        {
            firstname = fName;
            this.lastname = lastname;
            this.socialInsuranceNumber = socialInsuranceNumber;
        }

        public People(int socialInsuranceNumber, string lastname):this()
        {
            this.socialInsuranceNumber = socialInsuranceNumber;
            this.lastname = lastname;
        }

        public string ShowYourself()
        {
            return firstname + " " + lastname + ": " + socialInsuranceNumber.ToString();
        }
    }
}
