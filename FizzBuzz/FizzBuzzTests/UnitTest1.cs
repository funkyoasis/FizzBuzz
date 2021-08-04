using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzTests
{
	[TestFixture]
	public class FizzBuzzShould
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase(1,"1")]
		[TestCase(2, "2")]
		//[TestCase(20, "20")]
		public void GivenOne_Return_OneString(int input, string output)
		{
			Assert.That(Program.FizzBuzz(input), Is.EqualTo(output));
		}

		[TestCase(3,"Fizz")]
		[TestCase(6, "Fizz")]
		[TestCase(27, "Fizz")]
		public void GivenANumberDivisibleByThree_Return_Fizz(int input, string output)
		{
			var result = output;
			Assert.That(Program.FizzBuzz(input), Is.EqualTo(output));
		}

		[TestCase(5, "Buzz")]
		[TestCase(10, "Buzz")]
		[TestCase(25, "Buzz")]

		public void GivenANumberDivisibleByFive_Return_Buzz(int input, string output)
		{
			var result = output;
			Assert.That(Program.FizzBuzz(input), Is.EqualTo(output));
		}

		[TestCase(15,"FizzBuzz")]
		[TestCase(30, "FizzBuzz")]
		public void GivenANumberDivisibleByFifteen_Return_FizzBuzz(int input, string output)
		{
			//var result = output;
			Assert.That(Program.FizzBuzz(input), Is.EqualTo(output));
		}

	}

}