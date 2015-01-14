using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Declare_Variables
{
    class Problem_1_Declare_Variables
    {
        static void Main()
        {
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, 
//ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4 825 932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
//Submit the source code of your Visual Studio project as part of your homework submission.

            ushort number1 = 52130;
            sbyte number2 = -115;
            int number3 = 4825932;
            sbyte number4=97;
            short number5=-10000;

            Console.WriteLine("{0} is ushort, {1} is sbyte, {2} is int, {3},", number1, number2, number3);
            Console.Write("{0} is ushort, {1} is sbyte.",number4, number5);

        }
    }
}
