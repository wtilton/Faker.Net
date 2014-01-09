using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Faker.Tests
{
	[TestFixture]
	public class LoremTests
	{		
		[Test]
		public void TestSentence()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.GetSentence(), @"[ a-z]+"));
		}
		
		[Test]
		public void TestWord()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.GetWord(), @"[ a-z]+"));
		}
		
		[Test]
		public void TestParagraphs()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.GetParagraphs(), @"[ a-z]+"));
		}
		
		public void TestSentences()
		{
			Assert.IsTrue(Regex.IsMatch(Lorem.GetSentences(), @"[ a-z]+"));
		}
	}
}