using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IsNumber
{
    internal class Program
    {
        static bool IsNumber()
        {
            bool is_number = true;
            bool plusorminus = false;
            bool isfirst = true;
            bool beforedecimal = true;
            bool zerobeforedecimalandnum = false;
            bool firstnumber = false;
            ConsoleKeyInfo key = Console.ReadKey();
            bool saveisnum = true;
            bool afterdecimalnum =false;
            while (key.Key != ConsoleKey.Enter)
            {
                char ch = key.KeyChar;
                if (zerobeforedecimalandnum && ch != '.')
                {
                    is_number = false;
                }
                else
                {
                    zerobeforedecimalandnum = false;
                }
                if (beforedecimal && ch == '0' && !firstnumber)
                {
                    zerobeforedecimalandnum = true;
                }
                if (ch == '.' && !beforedecimal)
                {
                    is_number = false;
                }
                if (!beforedecimal && !afterdecimalnum)
                {
                    afterdecimalnum = true;
                    is_number = saveisnum;
                }
                if (ch == '.')
                {
                    beforedecimal = false;
                    saveisnum = is_number;
                    is_number = false;
                }

                if (plusorminus && (!Char.IsNumber(ch) ||ch =='.'))
                {
                    is_number = false;
                    saveisnum = is_number;
                }
                else
                {
                    plusorminus = false;
                }
                if (!firstnumber && Char.IsNumber(ch))
                {
                    firstnumber = true;
                }
                if (isfirst)
                {
                    isfirst = false;
                    if (ch == '+' || ch == '-')
                    {
                        plusorminus = true;
                    }
                    if (ch == '.')
                    {
                        is_number = false;
                        saveisnum = is_number;
                    }
                }
                else if (ch == '+' || ch == '-')
                {
                    is_number = false;
                }
                if (!char.IsNumber(ch) && ch != '+' && ch != '.' && ch != '-')
                {
                    is_number = false;
                }
                key = Console.ReadKey();
            }
            Console.WriteLine();
            if (!firstnumber)
            {
                is_number = false;
            }
            return is_number;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(IsNumber());
            }
            
        }
    }
}
