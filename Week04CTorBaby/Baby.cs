using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04CTorBaby
{
   class Baby // Class name 
    {
        public string Name { get; set; } // Property for baby's name
        public string Surname { get; set; } // Property for baby's surname
        public DateTime DateOfBirth { get; set; } // Property for baby's date of birth

        // Constructor without parameters
        public Baby() // Default constructor
        {
            Name = "Sue";      // Default name
            Surname = "Vardar";  // Default surname 
            DateOfBirth = DateTime.Now;   // Default date of birth
            Console.WriteLine("Ingaaaaaaa...");  // Output message when the default constructor is called
        }

        // Constructor with parameters
        public Baby(string name, string surname) // Parameterized constructor
        { 
            Name = name;  // Assigning the name parameter to the Name property
            Surname = surname;  // Assigning the surname parameter to the Surname property
            DateOfBirth = DateTime.Now;   // Assigning the current date and time to the DateOfBirth property
            Console.WriteLine("Ingaaaaaa...");   // Output message when the parameterized constructor is called
        }

    }

}
