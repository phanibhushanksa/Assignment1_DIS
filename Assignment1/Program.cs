using System;
using System.Linq;
using System.Collections.Generic;

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
           // UsfNumbers(n3, k);

            string[] words = new string[] {"abcd", "dcba", "lls", "s", "sssll"};
            //PalindromePairs(words);

            int n4 = 31;
            Stones(n4);
        }


        private static void PrintPattern(int n)
        {
            try
            {
                 
                //checking for n,because n cannot be less than or equal to 0.                
                    if (n == 0)
                        return;
                    //calling Printn method.
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
               
                for(int i = 1; i<=n3; i++)
                {
                    //Here we are checking for the 3 and 5 condition first so that it will not print for i%3==0 or i%5==0
                    if (i % 3 == 0 && i % 5 == 0)
                        Console.Write("US ");
                    //Here we are checking for the 5 and 7 condition first so that it will not print for i%5==0 or i%7==0
                    else if (i % 5 == 0 && i % 7 == 0)
                        Console.Write("SF ");
                    //checking for multiples of 3
                    else if (i % 3 == 0)
                        Console.Write("U ");
                    //checking for multiples of 5
                    else if (i % 5 == 0)
                        Console.Write("S ");
                    //checking for multiples of 7
                    else if (i % 7 == 0)
                        Console.Write("F ");
                    //printing the number itself if it not a multiple of any of the above.
                    else
                        Console.Write(i+" ");

                    //Starting a new line after k elements.
                    if(i%k==0)
                        Console.WriteLine();
                }
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
                //initiating an empty list of type integer array to store the index values of palindrome strings.
                List<int[]> result = new List<int[]>();
                //initiating an empty string to print the result in required format. 
                string s = "";
                //used nested for loop to try all the possible combinations in the input string array.
                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = 0; j < words.Length; j++)
                    {
                        //checking for i!=j so to remove combinations of same array.
                        if(i!=j)
                        {
                            //forming a temporary string for each combination
                            string temp = words[i] + words[j];
                            //flag variable to check for palindrome
                            int pal = 1;
                            //checking for palindrome condition.
                            for (int k = 0;  k < temp.Length/2; k++)
                            {
                                if (temp[k] != temp[temp.Length - k - 1])
                                {
                                    //making flag variable 0 if the string is not a palindrom and breaking from the loop.
                                    pal = 0;
                                    break;
                                }
                                
                            }
                            //if value of flag is 1, then the temp string is a palindrom, as it did not become 0.
                            if (pal == 1)
                            {
                                //storing the values of i and j in a list of type of int array.
                                int[] temparray = {i,j};
                                result.Add(temparray);
                                //adding value of i and j to the string 
                                s = s + "[" + i + "," + j + "]" + ",";
                            }
                        }


                    }
                }
                //printing the output in the required format.
                Console.Write("[");
                // removing the comma at the end of the string.
                for (int l = 0; l < s.Length-1; l++)
                {
                    Console.Write(s[l]);
                }
                Console.Write("]");
                     
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
                if (n4 >= 4)
                {
                    string stonesResult = "[";
                    if (n4 % 4 == 0)
                        Console.WriteLine("false"); 
                    else 
                    {
                            stonesResult = stonesResult + n4 % 4;
                        for (int i = 0; i < n4/4; i++)
                        {
                            stonesResult = stonesResult+ " 1 3";
                        }
                        stonesResult = stonesResult + "]";
                            Console.WriteLine(stonesResult);
                    }
                }
                else
                {
                    Console.WriteLine("Number of stones should be greater than or equal to 4");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured while computing Stones() with message " + e.Message);
            }
        }


    }
}
