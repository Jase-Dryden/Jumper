using System;
namespace Unit03.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private Hider word = new Hider();
        private Hider blank = new Hider();
        private bool isPlaying = true;
        private Seeker seeker = new Seeker();
        private char character;
        private int problem = 0;
        private TerminalService terminalService = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Moves the seeker to a new location.
        /// </summary>
        private void GetInputs()
        {
            string[] words = {"their","which","these","years","because","place","might","large","story","today"};
            Random random = new Random();
            int num = random.Next(10);
            num = num - 1;
            word.SetWord(words[num]);
            blank.SetBlanks(words[num]);
            character = terminalService.ReadCharacter("Guess a letter.[a-z] ");

        }

        /// <summary>
        /// Keeps watch on where the seeker is moving.
        /// </summary>
        private void DoUpdates()
        {
            if (seeker.LetterCheck(character, word) == true)
            {
                blank.nother(character, word);
            }
            else
            {
                problem += 1;
            }
        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            if (word.GetList() == blank.GetList())
            {
                isPlaying = false;
            }
            
        }

    }
}