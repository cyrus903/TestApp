using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TestApp
{
    class Test
    {
        public Test()
        {
            Delegate1 concreteD = new Delegate1(Delegates.d2);

            concreteD();

        }
    }


 
}
