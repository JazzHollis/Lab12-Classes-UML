using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("James", "444 Lodge Dr.", "Art history", 2019, 500);
            Console.WriteLine(student);

        }
    }
}
