using System;
using System.Collections.Generic;


namespace try_catch 
{
    public class Contact 
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string FullName {
            get {return string.Format($"{FirstName} {LastName}");}
        }
        public string Email {get; set;}
        public string Address {get; set;}
    }
}