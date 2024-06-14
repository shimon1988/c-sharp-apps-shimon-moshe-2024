﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace c_sharp_apps_shimon_moshe_2024.bank_app
{
    public class Owner
    {
        private string firstName;
        private string lastName;

        public Owner(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

      
        public string GetFirstName()
        {
             return firstName; 
        }

        public string GetLastName ()
        {
            return lastName; 
        }

        public void PrintOwnerDetails()
        {
            Console.WriteLine($"Owner: {firstName} {lastName}");
        }
       
    }
}

