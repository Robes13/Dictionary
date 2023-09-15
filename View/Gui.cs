using Dictionary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.View
{
    /// <summary>
    /// This class is responsible for handling everything gui related.
    /// </summary>
    internal class Gui
    {
        /// <summary>
        /// This method writes from a dictionary to console. If the choice is true only the first key will be 
        /// written to console. If it is false it will write everything from the dictionary.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="choice"></param>
        public void WritePerson(Dictionary<string, int> person, bool choice)
        {
            if (choice)
            {
                foreach (var item in person)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
            else
            {
                foreach (var item in person)
                {
                    Console.WriteLine($"Name: {item.Key}, Age: {item.Value}");
                }
            }
        }
        /// <summary>
        /// This method just writes to consol.e
        /// </summary>
        public void GoNext()
        {
            Console.WriteLine("Press enter to show next assignment");
        }

        public void End() 
        {
            Console.WriteLine("Press enter to exit program.");
        }
    }
}
