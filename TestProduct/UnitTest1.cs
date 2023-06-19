
using lab_03;
using System;

namespace TestProduct
{
    public class UnitTest1
    {


        [Fact]
        public void Test1()
        {
            //arrang
            string num = "1 4 5";

            var numreader = new StringReader(num);
            Console.SetIn(numreader);

            //act
            int result = Program.product();

            // assert
            Assert.Equal(20, result);
        }

        [Theory]
        [InlineData(20, "1 4 5")]
        [InlineData(0, "1 4")]
        [InlineData(20, "1 4 5 6")]
        [InlineData(1, "")]
        [InlineData(20, "1 -4 5")]
        [InlineData(1, "kk")]

        public void Test2(int expected, string actual)
        {
            var numreader = new StringReader(actual);
            Console.SetIn(numreader);

            //act
            int result = Program.product();

            //assert
            Assert.Equal(expected, result);

        }


    }
}