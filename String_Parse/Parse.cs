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

            char[] delimChars1 = { ',', ';', '-', '=', '/', '+',':',';',' ' };
            delimChars1 = delimChars1.ToArray();
            char[] letters = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();

            char[] final = letters.Concat(delimChars1).ToArray();
            
            string phrase = "svs gs hg15.6sg saz 4 5,6dhsj5 6h45:45,49bnz3.53afh";

            string[] numbers = phrase.Split(final,StringSplitOptions.RemoveEmptyEntries);
                     

            foreach (string number in numbers)
            {
                Console.WriteLine($"<{number}>");
            }


            

            //string fin = numbers.ToString();
            //string[] final  = numbers.ToString().Split(delimChars1, StringSplitOptions.RemoveEmptyEntries);






            /*string phrase = "gsgbls4134ddn1515gslgsg484646";
            int result = Convert.ToInt32(new String(phrase.Where(x => char.IsNumber(x)).ToArray()));

            Console.WriteLine(result);*/
            Console.ReadLine();
        }
    }
}
