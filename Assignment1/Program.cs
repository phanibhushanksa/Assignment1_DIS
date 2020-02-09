using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution 1");
            int n = 5;
            PrintPattern(n);

            Console.WriteLine("\n");
            Console.WriteLine("Solution 2");
            int n2 = 6;
            PrintSeries(n2);

            Console.WriteLine("\n");
            Console.WriteLine("Solution 3");
            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);

            Console.WriteLine("\n");
            Console.WriteLine("Solution 4");
            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            Console.WriteLine("\n");
            Console.WriteLine("Solution 5");   
            string[] words = new string[] {"abcd", "dcba", "lls", "s", "sssll"};
            PalindromePairs(words);

            Console.WriteLine("\n");
            Console.WriteLine("Solution 6");
            int n4 = 14;
            Stones(n4);
        }


        private static void PrintPattern(int n)
        {
            try
            {
                if (n > 0)
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
                else
                {
                    Console.WriteLine("Input should be greater than 0, please enter a valid input");
                }
            }
            catch(Exception e)
            {
                // handling exceptions and printing the error message.
                Console.WriteLine("Exception occured while computing PrintPattern() with message " + e.Message);
            }
        }

        //second recursive function for printing elements in a row.
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
                if (n2 > 0)
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
                else
                {
                    Console.WriteLine("Input should be greater than 0");
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
                if (n3 != 0 && k != 0)
                {
                    for (int i = 1; i <= n3; i++)
                    {
                        //Here we are checking for the 3 and 5 condition first so that it will not print for i%3==0 or i%5==0
                        if (i % 3 == 0 && i % 5 == 0)
                            Console.Write("US ");
                        //Here we are checking for the 5 and 7 condition first so that it will not print for i%5==0 or i%7==0
                        else if (i % 5 == 0 && i % 7 == 0)
                            Console.Write("SF ");
                        else if (i % 3 == 0 && i % 7 == 0)
                            Console.Write("UF ");
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
                            Console.Write(i + " ");

                        //Starting a new line after k elements.
                        if (i % k == 0)
                            Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid input so that n3 and k should be greater than 0");
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
                //checking for number of strings in the strings array.
                if (words.Length > 1)
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
                            if (i != j)
                            {
                                //forming a temporary string for each combination
                                string temp = words[i] + words[j];
                                //flag variable to check for palindrome
                                int pal = 1;
                                //checking for palindrome condition.
                                for (int k = 0; k < temp.Length / 2; k++)
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
                                    int[] tempArray = { i, j };
                                    result.Add(tempArray);
                                    //adding value of i and j to the string 
                                    s = s + "[" + i + "," + j + "]" + ",";
                                }
                            }


                        }
                    }
                    //printing the output in the required format.
                    Console.Write("[");
                    //removing the comma at the end of the string.
                    for (int l = 0; l < s.Length - 1; l++)
                    {
                        Console.Write(s[l]);
                    }
                    Console.Write("]");
                }
                else
                {
                    Console.WriteLine("Minimum number of strings should be 2, please enter a valid input.");
                }
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
                //for a game to happen, both the players should get a chance, so minimum number of stones should be 4.
                if (n4 >= 4)
                {
                    string stonesResult = "[";
                    //Player 2 will win when the number of stones is 4 because if player 1 takes 1 or 2 or 3 stones
                    // player 2 will take out the reamining balls and he will win. Similary if the number of balls is a multiple
                    // of 4, player 2 will win, so we are printing false.
                
                    if (n4 % 4 == 0)
                        Console.WriteLine("false");
                //if the number of stones is 5, player 1 will take out 1 stone, so that player2 is left with 4 stones to pick from, so Player 1 will win.
                //if the number of stones is 6, player 1 will take out 2 stones, so that Player2 is left with 4 stones to pick from, so Player 1 will win.
                //if the number of stones is 7, player 1 will take out 3 stones, so that Player2 is left with 4 stones to pick from, so Player 1 will win.
                //so similary for a large number of stones, player 1 will pick n%4 number of stones, so Player 2 will be left with stones that is a multiple of 4 and player1 will win.

                    else
                    {
                        //player 1 will pick n4%4 stones first to win.
                        stonesResult = stonesResult + n4 % 4;
                        for (int i = 0; i < n4/4; i++)
                        {
                            //1,3 is one of the combination, it can be 2,2 or 3,1. We are printing the 1,3 combination here.
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
