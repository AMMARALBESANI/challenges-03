
using lab_03;
using System;

namespace TestProduct
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(20, "1 4 5")]
        [InlineData(0, "1 4")]
        [InlineData(20, "1 4 5 6")]
        [InlineData(1, "")]
        [InlineData(20, "1 -4 5")]
        [InlineData(1, "1 k 1")]

        public void Testprodect(int expected, string actual)
        {
            var numreader = new StringReader(actual);
            Console.SetIn(numreader);

            //act
            int result = Program.Product();

            //assert
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(4, "4\n4\n4\n4\n4 ")]
        [InlineData(4, "4\n4\n4\n4.5\n4 ")]
        [InlineData(4, "5\n4\n4\n3\n6\n5 ")]

        public void Testaverage(double expected, string actual)
        {
            var numreader = new StringReader(actual);
            Console.SetIn(numreader);

            //act
            double result = Program.average();

            //assert
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(  1,new int[]  { 1, 1, 1, 1, 1, 1, 1 })]
        [InlineData(   2,new int[] {1,2,2,4,5 })]
        [InlineData(2, new int[] {2,2 ,4,4,5})]
        [InlineData(2, new int[] { 2, 4, 5 })]
        public void mostrebited(int expected,int[] actual )
        {

            //act
            double result = Program.mostRebited( actual);

            //assert
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(-3, new int[] { -3,-4,-5,-6 })]
        [InlineData(5, new int[] { 1, 2, -2, 4, 5 })]
        [InlineData(99, new int[] { 2, 2, 4, 4, 99 })]

        public void largerNumber(int expected, int[] actual)
        {


            //act
            double result = Program.largerNumber(actual);

            //assert
            Assert.Equal(expected, result);

        }

        

        [Theory]
        [InlineData("hello world", new string[] { "hello: 5", "world: 5" })]
        [InlineData("yes i did it", new string[] { "yes: 3", "i: 1", "did: 3", "it: 2" })]
        public void WordLengthArrayTest(string input, string[] expected)
        {
            // Arrange
            Console.SetIn(new StringReader(input));

            // Act
            string[] result = Program.senteneslength();

            // Assert
            Assert.Equal(expected, result);
            Assert.IsType<string[]>(result);
        }





    }
}