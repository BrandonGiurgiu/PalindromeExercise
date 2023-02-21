using System;
using System.Linq;

namespace PalindromeExercise
{
	public class WordSmith
	{
		public bool IsAPalindrome (string word)
		{
			var reversedWord = word.Reverse();

			return word.SequenceEqual(reversedWord);
			
        }   
		    
				
	}
}

