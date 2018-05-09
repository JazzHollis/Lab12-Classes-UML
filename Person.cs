using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Classes
{
    class Person
    {
        #region Data Members
        private string name;
        private string address;
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        #endregion

        #region Default Constructor
        public Person ()
        {
         Address = "999 FineLine St.";
        
        }
        #endregion

        #region Method Overload
        public Person(string personName, string personAddress)
        {
            Name = personName;
            Address = personAddress;
        }
        #endregion

        //method
        #region 
        public override string ToString()
        {
            return "Name = " + Name + "Address = " + Address;
        }
        #endregion



    }
}
