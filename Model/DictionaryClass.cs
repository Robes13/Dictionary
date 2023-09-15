using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Model
{
    /// <summary>
    /// This class is responsible for handling our dictionary.
    /// </summary>
    internal class DictionaryClass
    {
        #region Fields

        private Dictionary<string, int> _people = new Dictionary<string, int>();

        #endregion Fields

        #region Constructors
        public DictionaryClass()
        {

        }

        #endregion Constructors

        #region Properties

        public Dictionary<string, int> People 
        { 
            get {  return _people; } 
            set { _people = value; }
        }

        #endregion Properties
    }
}
