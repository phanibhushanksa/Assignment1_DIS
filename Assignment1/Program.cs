using System;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
          // PrintPattern(n);

            int n2 = 6;
           //PrintSeries(n2);

            string s = "09:15:35PM";
            //string t = UsfTime(s);
            //Console.WriteLine(t);

            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
           // PalindromePairs(words);


        }


        private static void PrintPattern(int n)
        {
            try
            {
                 
                //checking for n,because n cannot be less than or equal to 0.               
                // base case 
                    if (n == 0)
                        return;
                    Printn(n);
                    Console.WriteLine();

                    // recursively calling PrintPattern() 
                    PrintPattern(n - 1);
                
            }
            catch(Exception e)
            {
                // handling exceptions and printing the error message.
                Console.WriteLine("Exception occured while computing PrintPattern() with message " + e.Message);
            }
        }

        private static void Printn(int n)
        {
            if (n == 0)
                return;
            Console.Write(n);
            //recursively calling Printn
            Printn(n - 1);
        }

        private static void PrintSeries(int n2)
        {
            try
            {
                int sum = 0;
                for (int i = 1; i <= n2; i++)
                {
                    //adding the sum to the next integer.
                    sum = sum + i;
                    if (i != n2)
                        Console.Write(sum + ",");
                    //removing coma for the last number.
                    else
                        Console.Write(sum);
                }
            }
            //Handling exception and printing the error message.
            catch(Exception e)
            {
                Console.WriteLine("Exception occured while computing PrintSeries() with message "+e.Message);
            }
        }


        public static string UsfTime(string s)
        {
            try
            {
                //converting the input string into type DateTime.
                if(DateTime.TryParse(s, out DateTime dt))
                {
                    //calculating the total seconds in the input time.
                    int sec = dt.Hour * 3600 + dt.Minute * 60 + dt.Second;
                    int UsfHr, UsfMin, UsfSec;
                    //1 U has 2700 F.
                    UsfHr = sec / 2700;
                    //Dividing the remainder with 45 to get the minutes.
                    UsfMin = (sec % 2700) / 45;
                    //Finding the number of seconds by finding the remainder.
                    UsfSec = (sec % 2700) % 45;
                    Console.WriteLine(UsfHr+":"+UsfMin+":"+UsfSec);
                }
                else
                    Console.WriteLine("Invalid time format");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception occured while computing UsfNumbers() with message "+e.Message);
            }
        }



        public static void PalindromePairs(string[] words)
        {
            try
            {
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured while computing PalindromePairs() with message " + e.Message);
            }
        }

        public static void Stones(int n4)
        {
            try
            {
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured while computing Stones() with message " + e.Message);
            }
        }


    }
}
