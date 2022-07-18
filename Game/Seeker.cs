using System;
using System.IO;
using System.Text;


namespace Unit03.Game
{
    // TODO: Implement the Seeker class as follows...

    // 1) Add the class declaration. Use the following class comment.

        /// <summary>
        /// <para>The person looking for the Hider.</para>
        /// <para>
        /// The responsibility of a Seeker is to keep track of its location.
        /// </para>
        /// </summary>
    public class Seeker
    {
        

    // 2) Create the class constructor. Use the following method comment.
        
        /// <summary>
        /// Constructs a new instance of Seeker.
        /// </summary>
        public Seeker()
        {

        }

    // 3) Create the GetLocation() method. Use the following method comment.
        
        /// <summary>
        /// Gets the current location.
        /// </summary>
        /// <returns>The current location as an int.</returns>
        public bool LetterCheck(char character, Hider word)
        {
            bool run = false;
            foreach(char y in word.GetList())
            {
                if (character == y)
                {
                run = true;
                }
            }
            return run;
        }
    }
}