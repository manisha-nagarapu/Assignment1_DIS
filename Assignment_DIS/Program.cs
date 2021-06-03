using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1 : Enter the Moves of Robot:");
            string moves = Console.ReadLine();
            bool pos = Question1.JudgeCircle(moves);
            if (pos)
            {
                Console.WriteLine("The Robot return’s to initial Position (0,0)");
            }
            else
            {
                Console.WriteLine("The Robot doesn’t return to the Initial Postion (0,0)");
            }
            Console.WriteLine();

            // Question2
            Console.WriteLine(" Q2: Enter the string to check for pangram:");
            string str = Console.ReadLine();
            bool flag = Question2.CheckIfPangram(str);
            if (flag)
            {
                Console.WriteLine("Yes, the given string is a pangram");
            }
            else
            {
                Console.WriteLine("No, the given string is not a pangram");
            }
            Console.WriteLine();

            //Question 3
            int[] nums = { 1, 2, 3, 1, 1, 3 };
            int gp = Question3.NumIdenticalPairs(nums);
            Console.WriteLine("Q3:");
            Console.WriteLine("The number of IdenticalPairs in the array are {0}:", gp);

            //Question 4
            int[] arr1 = { 3, 1, 4, 1, 5 };
            Console.WriteLine("Q4:");
            int pivot = Question4.PivotIndex(arr1);
            if (pivot > 0)
            {
                Console.WriteLine("The Pivot index for the given array is {0}", pivot);
            }
            else
            {
                Console.WriteLine("The given array has no Pivot index");
            }
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Q5:");
            Console.WriteLine("Enter the First Word:");
            String word1 = Console.ReadLine();
            Console.WriteLine("Enter the Second Word:");
            String word2 = Console.ReadLine();
            String merged = Program5.merge(word1, word2);
            Console.WriteLine("The Merged Sentence fromed by both words is {0}", merged);

            //Question 6
            Console.WriteLine("Q6: Enter the sentence to convert:");
            string sentence = Console.ReadLine();
            string goatLatin = Program6.ToGoatLatin(sentence);
            Console.WriteLine("Goat Latin for the Given Sentence is {0}", goatLatin);
            Console.WriteLine();

        }
    }
    class Question1
    //Logic:
    //Here,we have to increase the Y by 1 when it moves upward(U) and -1 when it moves downward(D)
    //we have to increase the X value by 1 when it moves to Right(R) and -1 when it moves left(L)
    {
        public static bool JudgeCircle(string moves)
        {
            try
            {
                int i, j;
                i = 0;
                j = 0;

                char[] chars = moves.ToCharArray();

                for (int k = 0; k < chars.Length; k++)
                {
                    if (chars[k] == 'R')
                        i = i + 1;
                    else if (chars[k] == 'L')
                        i = i - 1;
                    else if (chars[k] == 'U')
                        j = j + 1;
                    else if (chars[k] == 'D')
                        j = j - 1;
                }
                return (i == 0 && j == 0);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }

    //self Reflection:
    // Time complexity is O(N)
    //I have learnt the basic program of the robot moves in a two dimensional plane.
    public class Question2
    //Logic:Here,we take the all characters of the given string and count the char's used single time.
    //If total is 26,then we have to return true and if not we have to return false
    {
        public static bool CheckIfPangram(string str)
        {
            try
            {
                bool[] stored = new bool[26];
                int x = (int)'a';
                int sum = 0;

                for (CharEnumerator en = str.ToLower().GetEnumerator(); en.MoveNext();)
                {
                    int v = (int)en.Current - x;
                    if (v >= 0 && v < 26)
                        if (!stored[v])
                        {
                            stored[v] = true;
                            sum++;
                        }
                }
                return (sum == 26);
            }

            catch (Exception)
            {
                throw;
            }

        }
    }
    //Self Reflection:
    //Time complexity is O(Nsquare)
    //I have learnt the fundamentals of using the string functions.
    class Question3
    //Logic:Here,we will double iterate over the given array indices and verify whether any element matches the pair of indices in the array.
    {
        public static int NumIdenticalPairs(int[] nums)
        {
            try
            {
                int sol = 0;

                for (int j = 0; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[j] == nums[k])
                        {
                            sol++;
                        }
                    }
                }
                return sol;
            }
            catch (Exception)
            {
                throw;
            }
        }
        // self reflection:
        // Time complexity is O(Nsquare)
        //Here,I have learnt looping,working with the arrays and index of an array.

        class Question4
        //Logic:
        //here we will check the overall sum of the array and check the pivot index 
    public static int PivotIndex(int[] integers)
        {
            try
            {
                int array_size = integers.Length;
                int total = 0;
                int[] Left = new int[array_size];
                for (int i = 0; i < array_size; i++)
                {
                    Left[i] = total;
                    total = total + integers[i];
                }


                for (int index = 0; index < array_size; index++)
                {
                    if (Left[index] == Left[array_size - 1] - Left[index] - integers[index] + integers[array_size - 1])
                    {
                        return index;
                    }
                }

                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;

            }
        }
        //self reflection:
        // Time complexity is O(N)
        //I have learnt some methods of working with arrays and its indexes.
        class program5
        //Logic:
        // here  We iterate the  strings with characters and merge alternatively the characters.
        // If there are additional characters then we will append at the end of the result.
        {
            public static string merge(string str1, string str2)
            {
                try
                {
                    string Merged_String = "";


                    for (int i = 0; i < str1.Length || i < str2.Length; i++)
                    {


                        if (i < str1.Length)
                            Merged_String = Merged_String + str1[i];


                        if (i < str2.Length)
                            Merged_String = Merged_String + str2[i];
                    }
                    return Merged_String;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;

                }
            }
        }
        // Self Reflection:
        //
        // Time complexity is O(N)
        // Here I  learnt  working  with the concatination of arrays and how to work with multiple char arrays.
        class program6
        // Logic:
        // here we  will divide the sentence on the white spaces and iterate over all the words.
        // we will Change the words in the string as per the conditions given for "Goat Latin" language and finally combine all the words.
        {
            public static string ToGoatLatin(string sentence)
            {
                try
                {
                    var split_words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string add_letter = "a", final_sentence = "";
                    var vowels = new List<char>() { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
                    foreach (var each_word in split_words)
                    {
                        if (vowels.Any(x => x == each_word[0]))
                        {
                            final_sentence += each_word + "ma" + add_letter + " ";
                        }
                        else
                        {
                            final_sentence += each_word.Substring(1) + each_word[0] + "ma" + add_letter + " ";
                        }

                        add_letter += "a";

                    }

                    return final_sentence.Substring(0, final_sentence.Length - 1);
                }
                catch (Exception)
                {
                    throw;
                }
            } // Self Reflection:
              //
              // Time complexity is O(N)
              // here We have learnt minimum level of string manipulation on string arrays. 
              // We have seen filtering of words according to it's first letter and also concatination of strings.
              //

        }