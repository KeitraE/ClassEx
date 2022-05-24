using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    public class Car
    {

        public Car()
        {

        }

        public Car(string makeInput, string modelInput, int year)
        {
            Make = makeInput;
            Model = modelInput;
            Year = year;
        }

         public string Make { get; set; }
         public string Model { get; set; }
         public int Year { get; set; }
    }
}
