using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigLatin
{
    class Translation
    {
        public bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            //checks for vowels
            return vowels.Contains(c);
        }

        public string ToPigLatin(string word)
        {
            

            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            foreach (char c in specialChars)
            {
                foreach (char w in word.ToLower())
                {
                    if (w == c)
                    {
                        Console.WriteLine("That word has special characters, we will return it as is");
                        return word.ToLower();
                        //still does not account for the rest of the input, only searches for special characters and does not apply rest of the code to the output.
                    }
                }

            }

            bool noVowels = true;
            foreach (char letter in word.ToLower())
            {
                if (IsVowel(letter))
                {
                    noVowels = false;
                }
            }

            if (noVowels)
            {
                return word.ToLower();
            }

            char firstLetter = word.ToLower()[0];
            string output = "placeholder";
            if (IsVowel(firstLetter) == true)
            {
                output = word.ToLower() + "ay";
            }
            else
            {
                //should be looking for the first vowel
                int vowelIndex = -1;
                //Handle going through all the consonants
                for (int i = 0; i <= word.ToLower().Length; i++)
                {
                    if (IsVowel(word.ToLower()[i]) == true)
                    {
                        vowelIndex = i;
                        break;
                    }
                }

                string sub = word.ToLower().Substring(vowelIndex); //should be finding the first vowel and then is followed by the next line witj what was left behind
                string postFix = word.ToLower().Substring(0, vowelIndex);

                output = sub + postFix + "ay";
            }

            return output; //still does not seem to change the word correctly
        }
        
    }
}
