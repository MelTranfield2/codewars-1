using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService
{

    public class Cube
    {
        private int Side;

        //This cube needs your help. 
        //Define a constructor which takes one integer and assigns its value to 'Side'

        public Cube(int side) => Side = Math.Abs(side);

        public Cube()
        {
            Side = 0;
        }

        public int GetSide()
        {
            return this.Side;
        }

        public void SetSide(int s)
        {
            this.Side = Math.Abs(s);
        }
    }
}


// Create a public class called Cube without a constructor which gets 
//one single private integer variable Side, a getter GetSide() and a 
//setter SetSide(int num) method for this property. Actually, getter 
//and setter methods are not the common way to write this code in C#. 
//In the next kata of this series, we gonna refactor the code and make it a bit more professional...

// Notes:

// There's no need to check for negative values!
// initialise the side to 0.
