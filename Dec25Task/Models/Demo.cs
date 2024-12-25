using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec25Task.Models
{
    internal class Demo
    {
        private string vUsername;

        public string Username
        {
            get { return vUsername; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    vUsername = value;

                }
                else
                {
                    Console.WriteLine("Please enter username");

                }
            }
        }
        
        public void GetUsername()
        {
            Console.WriteLine("My username is " + vUsername);
        }
       
        
        
        private int vSalary;
        public int Salary
        {
            get
            {
                return vSalary;
            }
            set
            {
                if (Salary >= 350 && Salary <= 900)
                {
                    vSalary = value;
                }
                else
                {
                    Console.WriteLine("Salary is out of range");
                }
            }

        }
    }
}


