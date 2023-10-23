using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//(1)We can call a method in three way.
//-->If the function is non static ,then it will be call through his class referance /objec.
//-->If the function is static,then it will be called by using his class name
//-->we can also call a method by Deligate.
//(2)Delegate return type and paramiter is always same as the function return type and function paramiter.Because of that deligate is also known as type safe function pointer.
//(3)Delegate is a type safe function pointer.
//(4)Delegate is a userdefind type. like class,structure,enum etc.
//(5)we can define a delegate under namespace or under a class.

//Steps for use a deligate
//-------------------------
//step-1
//--------
//Declare a deligate
//step-2
//------
//Instanciate a deligate  (at the time of instanciate we need to pass a method name as a paramiter to the deligate).
//step-3
//------
//
namespace Deligate
{
    public delegate void addnum(int a, int b);
    public delegate void subnum(int a, int b);
    class Program
    {





        //public delegate void addnum(int a, int b);
        //public delegate void subnum(int a, int b);
        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }

        // method "subtract"
        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            addnum del_obj1 = new addnum(obj.sum);
            del_obj1(12, 66);
            //del_obj1.Invoke(12, 66);
            subnum del_obj2 = new subnum(obj.subtract);
            del_obj2(12, 66);
        }
    }
}
