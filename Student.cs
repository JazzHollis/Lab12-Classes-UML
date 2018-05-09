using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Classes
{
    class Student : Person
    {
        #region Data Members
        private string program;
        private int year;
        private double fee;
        #endregion


        #region Properties
        public string Program
        {
            get { return program; }
            set { program = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Fee
        {
            get { return fee;}
            set { fee = value;}
        }
        #endregion

        #region Default Constructor
        public Student()
        {
            Program = "Javascript";

        }
        #endregion

        #region Method Overload
        public Student (string personName, string personAddress, string pro, int yr, double studentFee ) : base( personName,personAddress)
        {
            Program = pro;
            Year = yr;
            Fee = studentFee;

        }
        #endregion

        //method
        #region 
        public override string ToString()
        {
            return "Name = " + Name + "Address = " + Address + "Program =" + Program + "Fee =" + Fee;
        }
        #endregion





    }
}
