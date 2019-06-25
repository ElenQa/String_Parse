using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Parse
{
    class Parse
    {
        static void Main(string[] args)
        {


            char[] delimChars = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
          
            string phrase = "svsgshg156sgsaz456dhsj56h4545";

            string[] numbers = phrase.Split(delimChars,StringSplitOptions.RemoveEmptyEntries);

                    

            foreach (string number in numbers)
            {
                Console.WriteLine($"<{number}>");
            }


            char[] delimChars1 = { ',', ';', '-', '=', '/', '+' };

            //string fin = numbers.ToString();
            //string[] final  = numbers.ToString().Split(delimChars1, StringSplitOptions.RemoveEmptyEntries);






            /*string phrase = "gsgbls4134ddn1515gslgsg484646";
            int result = Convert.ToInt32(new String(phrase.Where(x => char.IsNumber(x)).ToArray()));

            Console.WriteLine(result);*/
            Console.ReadLine();
        }
    }
}
