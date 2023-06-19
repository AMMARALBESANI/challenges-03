namespace lab_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine(product());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }

        public static int product()
        {
            int product = 1;
            try
            {

                Console.WriteLine("please ener 3 numbers :");
                string num = Console.ReadLine();

                if (string.IsNullOrEmpty(num))
                {
                    return 1;
                }

                string[] numArray = num.Trim().Split(' ');
                int[] nums = Array.ConvertAll(numArray, int.Parse);




                if (nums.Length == 3)
                {

                    for (int i = 0; i < nums.Length; i++)

                    {
                        if (nums[i] < 0)
                        {
                            nums[i] *= -1;
                        }
                        product *= (nums[i]);
                    }

                    return product;

                }
                else if (nums.Length > 3)

                {
                    for (int i = 0; i <= 2; i++)
                    {
                        if ((nums[i]) < 0)
                        {
                            nums[i] *= -1;
                        }
                        product *= (nums[i]);
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
            catch (FormatException ex)
            {

                Console.WriteLine("invaild input");
                return 1;
            }

        }
    }
}