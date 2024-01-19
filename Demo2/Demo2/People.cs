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
        private string firstname, lastname;

        //how to allow access to display the firstname?
        //MANUAL PROPERTY!! BACKER FIELDS
        public string first
        {
            get { return firstname; } 
            set {
                if (value.ToLower()[0] == firstname.ToLower()[0]) firstname = value;
            }
        }

        public string WhatAmI
        {
            get { return "Person"; }
        }

        //AUTOMATIC PROPERTY
        //Automatically creates a backing field
        public string Id { get; private set; }

        //CTOR (birth of a people)
        //all classes come with a default constructor
        //that initializes everything to defaults

        //override the free default CTOR?
        public People()
        {
            socialInsuranceNumber = 0;
            firstname = "Adam";
            lastname = "";
            Id = socialInsuranceNumber.ToString();
        }

        //what if you want to specify assignments?
        public People(string fName, string lastname, int socialInsuranceNumber)
        {
            firstname = fName;
            this.lastname = lastname;
            this.socialInsuranceNumber = socialInsuranceNumber;
            Id = socialInsuranceNumber.ToString();
        }

        public People(int socialInsuranceNumber, string lastname):this()
        {
            this.socialInsuranceNumber = socialInsuranceNumber;
            this.lastname = lastname;
            Id = socialInsuranceNumber.ToString();
        }

        public string ShowYourself()
        {
            return firstname + " " + lastname + ": " + socialInsuranceNumber.ToString();
        }
    }
}
