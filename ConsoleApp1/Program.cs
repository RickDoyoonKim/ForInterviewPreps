using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ForInterview1
            //Variables used for testing purpose
            //string forTest = "zf3kabxcde224lkzf3mabxc51+crsdtzf3nab=";
            //int testPatternLength = 3;
            
            //Variables for user input
            string userInputPattern = "";
            int patternLength = 0;

            var readOp = new Func<string>(() => Console.ReadLine());

            Console.Write("Please input pattern to check: ");
            userInputPattern = readOp();

            bool valid = false;
            Console.Write("Please input pattern length[1-9]: ");
            while(valid == false)
            {
                string input = readOp();
                int n;
                //This part was also not working on .Net Fiddle
                if (int.TryParse(input, out int num) && num > 0 && num < 10)
                {
                    patternLength = num;
                    valid = true;
                }
                else
                {
                    Console.Write("Wrong Number. Please input pattern length[1-9]: ");
                }
            }

            Dictionary<string, int> PatternCount = new Dictionary<string, int>();

            for(int i = 0; i < userInputPattern.Length - patternLength + 1; i++)
            {
                string temp = userInputPattern.Substring(i, patternLength);

                if(PatternCount.ContainsKey(temp))
                {
                    //PatternCount.TryGetValue(temp, out var currentCount);
                    //PatternCount[temp] = currentCount + 1;

                    int tempValue = PatternCount[temp];
                    PatternCount[temp] = tempValue + 1;
                }
                else
                {
                    PatternCount.Add(temp, 1);
                }
            }

            Console.WriteLine("With a specified pattern length of: " + patternLength );
            foreach (var c in PatternCount)
            {                
                if(c.Value > 1)
                {
                    Console.WriteLine("Pattern \"" + c.Key + "\" has an occurence value of " + c.Value);
                }
            }
            #endregion

            #region ForInterview#2 (Usage of TimeSpan)
            //DateTime writeBlog = new DateTime(2018, 9, 1, 18, 16, 0);            
            //DateTime now = DateTime.Now;

            //TimeSpan diff = now.Subtract(writeBlog);

            //if((int)diff.TotalMinutes == 0)
            //{
            //    Console.WriteLine("now");
            //}

            //int days = (int)diff.TotalDays;

            //if(days != 0)
            //{
            //    Console.WriteLine(days + " day(s) ago");
            //}

            //int hours = (int)diff.TotalHours;

            //if(hours != 0 && hours < 23)
            //{
            //    Console.WriteLine(hours + " hour(s) ago");
            //}

            //int minutes = (int)diff.TotalMinutes;

            //if(minutes != 0 && minutes < 60)
            //{
            //    Console.WriteLine(minutes + " minute(s) ago");
            //}

            //Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
            #endregion
        }
    }
}
