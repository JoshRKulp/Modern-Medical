using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernMedical
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 1 ;i < 101; i++)
            {
                string strOutput = "";
                bool bShowNumber = true;
                if (i % 3 == 0)
                {
                    strOutput = "Modern";
                    bShowNumber = false;
                }
                if (i % 5 == 0)
                {
                    strOutput += "Medical";
                    bShowNumber = false;
                }
                if(bShowNumber)
                    strOutput = i.ToString();
                Console.WriteLine(strOutput);
            }
           Console.ReadLine();
        }
    }
}
