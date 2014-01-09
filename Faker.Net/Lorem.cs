using System;
using System.Collections.Generic;
using System.Linq;

namespace Faker
{
	public static class Lorem
	{
		public static string GetWord()
		{
			return WORDS.Rand();
		}

		public static string GetWords(int number)
		{
			return 1.To(number).Select(w => GetWord()).Join(" ");
		}

		public static string Words(this int number)
		{
			return GetWords(number);
		}

		private static IEnumerable<string> getWords(int maxWords = 3)
		{
			return WORDS.RandPick(maxWords);
		}

		public static string GetSentence(int wordCount = 4)
		{
			var s = getWords(wordCount);
			var sentence = s.Join(" ") + ".";
			return char.ToUpper(sentence[0]) + sentence.Substring(1);
		}

		/// <summary>
		/// Here so you can get a random number between two numbers and pair it with a Lorem extension method. The same as calling Number.Between.
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int GetBetween(int min, int max)
		{
			return Number.Between(min, max);
		}

		/// <summary>
		/// Usage 3.Sentences()
		/// </summary>
		/// <param name="number"></param>
		/// <returns>Number of sentences specified</returns>
		public static string Sentences(this int number)
		{
			return GetSentences(number);
		}

		/// <summary>
		/// Usage 3.Paragraphs()
		/// </summary>
		/// <param name="number"></param>
		/// <returns>Number of paragraphs specified</returns>
		public static string Paragraphs(this int number)
		{
			return GetParagraphs(number);
		}

		private static IEnumerable<string> getSentences(int sentenceCount = 3)
		{
			return 1.To(sentenceCount).Select(item => GetSentence());
		}

		public static string GetSentences(int min, int max)
		{
			return getSentences(min + Number.Between(min, max - min)).Join(" ");
		}

		public static string GetSentences(int sentenceCount = 3)
		{
			return getSentences(sentenceCount).Join(" ");
		}

		public static string GetParagraphs(int paragraphCount = 3)
		{
			return "<p>" + 1.To(paragraphCount).Select(item => GetSentences()).Join("</p><p>") + "</p>";
		}

		public static string GetParagraphs(int min, int max)
		{
			return "<p>" + 1.To(min + Number.Between(min, max - min)).Select(item => GetSentences()).Join("</p><p>") + "</p>";
		}

		static readonly string[] WORDS = new[] {"alias", "consequatur", "aut", "perferendis", "sit", "voluptatem", "accusantium",
"doloremque", "aperiam", "eaque", "ipsa", "quae", "ab", "illo", "inventore", "veritatis",
"et", "quasi", "architecto", "beatae", "vitae", "dicta", "sunt", "explicabo", "aspernatur",
"aut", "odit", "aut", "fugit", "sed", "quia", "consequuntur", "magni", "dolores", "eos", "qui",
"ratione", "voluptatem", "sequi", "nesciunt", "neque", "dolorem", "ipsum", "quia", "dolor",
"sit", "amet", "consectetur", "adipisci", "velit", "sed", "quia", "non", "numquam", "eius",
"modi", "tempora", "incidunt", "ut", "labore", "et", "dolore", "magnam", "aliquam", "quaerat",
"voluptatem", "ut", "enim", "ad", "minima", "veniam", "quis", "nostrum", "exercitationem",
"ullam", "corporis", "nemo", "enim", "ipsam", "voluptatem", "quia", "voluptas", "sit",
"suscipit", "laboriosam", "nisi", "ut", "aliquid", "ex", "ea", "commodi", "consequatur",
"quis", "autem", "vel", "eum", "iure", "reprehenderit", "qui", "in", "ea", "voluptate", "velit",
"esse", "quam", "nihil", "molestiae", "et", "iusto", "odio", "dignissimos", "ducimus", "qui",
"blanditiis", "praesentium", "laudantium", "totam", "rem", "voluptatum", "deleniti",
"atque", "corrupti", "quos", "dolores", "et", "quas", "molestias", "excepturi", "sint",
"occaecati", "cupiditate", "non", "provident", "sed", "ut", "perspiciatis", "unde",
"omnis", "iste", "natus", "error", "similique", "sunt", "in", "culpa", "qui", "officia",
"deserunt", "mollitia", "animi", "id", "est", "laborum", "et", "dolorum", "fuga", "et", "harum",
"quidem", "rerum", "facilis", "est", "et", "expedita", "distinctio", "nam", "libero",
"tempore", "cum", "soluta", "nobis", "est", "eligendi", "optio", "cumque", "nihil", "impedit",
"quo", "porro", "quisquam", "est", "qui", "minus", "id", "quod", "maxime", "placeat", "facere",
"possimus", "omnis", "voluptas", "assumenda", "est", "omnis", "dolor", "repellendus",
"temporibus", "autem", "quibusdam", "et", "aut", "consequatur", "vel", "illum", "qui",
"dolorem", "eum", "fugiat", "quo", "voluptas", "nulla", "pariatur", "at", "vero", "eos", "et",
"accusamus", "officiis", "debitis", "aut", "rerum", "necessitatibus", "saepe",
"eveniet", "ut", "et", "voluptates", "repudiandae", "sint", "et", "molestiae", "non",
"recusandae", "itaque", "earum", "rerum", "hic", "tenetur", "a", "sapiente", "delectus", "ut",
"aut", "reiciendis", "voluptatibus", "maiores", "doloribus", "asperiores",
"repellat" };
	}
}
