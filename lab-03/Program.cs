using System.IO;
using System.Transactions;

namespace lab_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine(average());
                //Console.WriteLine(Product());
                //Drawing();
                //Console.WriteLine(mostRebited(new int[] {5,5,6,7,8 }));
                //Console.WriteLine(largerNumber(new int[] { 5, 5, 6, 7, 8 }));
                //writeTofile("hello");
                //readFromfile();
                //deleteFromfile(Console.ReadLine());

                string[] x = senteneslength();
                foreach (string s in x) { Console.WriteLine(s); }
                    

            }
            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);
            }


        }

        public static int Product()
        {
            int product = 1;
            try
            {
                Console.WriteLine("Please enter 3 numbers:");
                string num = Console.ReadLine();

                if (string.IsNullOrEmpty(num))
                {
                    return 1;
                }

                string[] numArray = num.Trim().Split(' ');

                int[] nums = new int[numArray.Length];
                for (int i = 0; i < numArray.Length; i++)
                {
                    if (!int.TryParse(numArray[i], out nums[i]))
                    {
                        nums[i] = 1;
                    }
                }

                if (nums.Length == 3)
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] < 0)
                        {
                            nums[i] *= -1;
                        }
                        product *= nums[i];
                    }
                    return product;
                }
                else if (nums.Length > 3)
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        if (nums[i] < 0)
                        {
                            nums[i] *= -1;
                        }
                        product *= nums[i];
                    }
                    return product;
                }
                else if (numArray.Length < 3)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input");
                return 1;
            }
        }

        public static double average()
        {
            double ave = 0;
            try
            {
                Console.Write("input number between 2 and 10: ");
                int size = Convert.ToInt32(Console.ReadLine());
                if (size <= 2 || size >= 10)
                {
                    Console.Write("please enter number in the range!\n ");
                    Console.WriteLine(average());
                    return -1;
                }

                double[] array = new double[size];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($" {i + 1} of {size} Enter a number:\t ");
                    array[i] = Convert.ToDouble(Console.ReadLine());

                    while (array[i] < 0)
                    {
                        array[i] *= -1;
                    }
                    ave += array[i];

                }
                ave /= size;

                return Math.Floor(ave);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("please enter valid input");
                average();
                return 0;

            }

        }

        static void Drawing()
        {
            int n = 5;


            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n - i; k++)
                {
                    Console.Write(" ");
                }

                for (int x = 1; x <= 2 * i - 1; x++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            for (int i = n - 1; i >= 1; i--)
            {
                for (int k = 1; k <= n - i; k++) { Console.Write(" "); }


                for (int x = 1; x <= 2 * i - 1; x++) { Console.Write("*"); }


                Console.WriteLine();
            }
        }

        public static int mostRebited(int[] array)
        {
            try
            {
                int most = 0;
                int k = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    int x = 0;

                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            x++;
                        }
                    }

                    if (x > k)
                    {
                        k = x;
                        most = array[i];
                    }
                }

                return most;
            }
            catch (Exception e)
            {
                return 1;
            }
        }

        public static int largerNumber(int[] num)
        {
            int max = num[0];
            for (int i = 0; i < num.Length; i++)
            {

                if (num[i] > max)
                {
                    max = num[i];
                }
            }
            return max;
        }

        public static void writeTofile(string sentences)
        {
            string path = "../../../words.txt";
            File.AppendAllText(path, sentences);


        }


        public static void readFromfile()
        {
            string path = "../../../words.txt";
            Console.WriteLine(File.ReadAllText(path));
        }

        public static void deleteFromfile(string sentences)
        {
            string path = "../../../words.txt";
            string[] word = File.ReadAllLines(path);
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == sentences)
                {
                    word[i] = string.Empty;
                }
            }
            File.WriteAllLines(path, word);
        }

        public static string[] senteneslength()
        {
            Console.WriteLine("Enter sentence: ");
            string input = Console.ReadLine();
            string[] words = input.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = $"{words[i]}: {words[i].Length}";
            }
            return words;
        }




    }







}








