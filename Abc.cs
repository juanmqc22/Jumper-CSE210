using System;
///Here we have the list of words of our game. 
namespace Jumper
{
    public class Abc {

        public Abc()
        {            
        }
        public string Words()
        {
            string[] words = {
                "boat",
                "home",
                "hand",
                "show",
                "alex",
                "ring"
            };          

            ///Here we will take just one word of our list and return that word.          
            int numberWord = 0;
            Random random = new Random();
            numberWord = random.Next(words.Length);
            string word = words[numberWord];
            return word;
        }
    }
}
