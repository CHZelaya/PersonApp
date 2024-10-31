using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    internal class Person
    {
        // attributes
        private string fname;
        private string lname;
        private string dob;


        // get and set methods for the attributes
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        private string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        // constructor for the Person class
        public Person(string fname, string lname, string dob)
        {
            Fname = fname;
            Lname = lname;
            Dob = dob;
        }

        // Name cannot be null and will be "Unknown" if it is not provided by the user
        public string Name
        {
            get
            {
                return string.IsNullOrWhiteSpace(fname) && string.IsNullOrWhiteSpace(lname)
                    ? "Unknown"
                    : $"{fname} {lname}";
            }
        }

        // Dob should not be in the future and not more than 125 years ago.

        public string Age
        {
            get
            {
                DateTime parsedDate; // DateTime is the datatype, parsedDate is the declared variable

                // Try to parse the date

                // For my own understanding, dob is the input string, out indicates that it is an output parameter, if parsing is successfull, it is stored in (OUT TO) parsedDate which NEEDs to be declared previously, as on line 61
                //Interesting how everything needs to be declared =/


                if (DateTime.TryParse(dob, out parsedDate))
                {
                    // check if the date is in the future
                    if (parsedDate > DateTime.Now)
                    {
                        return "The birthdate cannot be in the future";
                    }
                    // Check to see if the date is over 125 years old
                    else if (parsedDate < DateTime.Now.AddYears(-125))
                    {
                        return "The birthdate is over 125 years old";
                    }
                    else
                    {
                        // Calculate age
                        int age = DateTime.Now.Year - parsedDate.Year;
                        if (DateTime.Now < parsedDate.AddYears(age)) age--; // Adjust for birthday
                        return age.ToString();
                    }
                }
                else
                {
                    return "Invalid date format.";
                }
            }

        }


        //Override ToString Method
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }


    }
}