using Dictionary.Model;
using Dictionary.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Controller
{
    /// <summary>
    /// This controller runs the entire program.
    /// </summary>
    internal class RunDictionaryClass
    {
        public void StartDictionary()
        {
            // Creating new dictionaryClass object
            DictionaryClass dictionaryClass = new DictionaryClass();

            // Adding T-key and T-Value(string and byte)
            dictionaryClass.People.Add("Robert", 22);
            // Adding using the index method
            dictionaryClass.People["Nicklas"] = 18;
            dictionaryClass.People.Add("SnapChat Jonas", 18);

            // Creating new Gui Object
            Gui gui = new Gui();

            // Writing first T-key to the console.
            gui.WritePerson(dictionaryClass.People, true);

            Read read = new Read();
            gui.GoNext();
            read.ReadKey();

            // Removing Robert from the dictionary.
            dictionaryClass.People.Remove("Robert");
            gui.WritePerson(dictionaryClass.People, true);

            gui.GoNext();
            read.ReadKey();

            gui.WritePerson(dictionaryClass.People, false);

            gui.End();
            read.ReadKey();
        }
    }
}
