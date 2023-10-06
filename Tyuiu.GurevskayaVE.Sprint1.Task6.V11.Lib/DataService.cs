using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GurevskayaVE.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            bool res = true;
            char a = value[0];
            if (a == value[1] || a == value[2] || a == value[3] || a == value[4] || a == value[5] || a == value[6] || a == value[7] || a == value[8] || a == value[9] || a == value[10] || a == value[11] || a == value[12] || a == value[13])
            {
                return res;
            }
            else
            {
                return !res;
            }
     

            
            
            
        }
    }
}
