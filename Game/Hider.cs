using System;
using System.Collections.Generic;


namespace Unit03.Game 
{
    /// <summary>
    /// <para>The person hiding from the Seeker.</para>
    /// <para>
    /// The responsibility of Hider is to keep track of its location and distance from the seeker.
    /// </para>
    /// </summary>
    public class Hider
    {
        private List<char> letters = new List<char>();

        /// <summary>
        /// Constructs a new instance of Hider. 
        /// </summary>
        public Hider()
        {
            
        }

        /// <summary>
        /// Converts the word into a list of characters.
        /// </summary>
        public void SetWord(string word)
        {
            letters.AddRange(word);
        }
         /// <summary>
        /// Creates a list of underscores acording to the length of the word.
        /// </summary>
        public void SetBlanks(string word)
        {
            List<char> blank = new List<char>();
            blank.AddRange(word);
            int num = blank.Count;
            for (int i = 0; i < num; i++)
            {
                letters.Add('_');
            }
        }

        public List<char> GetList()
        {
            return letters;
        }
        
        public void nother(char character, Hider word)
        {
            int index = 0;
            foreach (char y in word.GetList())
            {
                if (y == character)
                {
                this.letters[index] = y;
                }
                index = index + 1;
            }
        }
        
    }
}