using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Year
{
    public static bool IsLeap(int yearNumber)
    {
        if (yearNumber % 400 == 0)
        {
            return true;
        }

        if (yearNumber % 100 == 0)
        {
            return false;
        }

        return yearNumber % 4 == 0;
    }
}
