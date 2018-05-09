using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Classes
{
    class Staff : Person
    {
        #region Data Members
        private string school;
        private double pay;
        #endregion

        #region Properties
        public string School
        {
            get { return school; }
            set { school = value; }
        }
   
        public double Pay
        {
            get { return pay; }
            set { pay = value; }
        }
        #endregion

        #region Default Constructor
        public Staff()
        {

        }
        #endregion

        #region Method Overload
        public Staff(string personName, string personAddress, string sch, double staffPay) : base (personName, personAddress)
        {
            School = sch;
            Pay = staffPay;
        }
        #endregion

        //method
        #region 
        public override string ToString()
        {
            return "Name = " + Name + "Address = " + Address + "School = " + School + "Pay = " + Pay;
        }
        #endregion

    }
}
