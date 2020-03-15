using System;
using System.Collections.Generic;

namespace csharp_lists
{
    public class CardClass
    {
        public string name;
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // start of arrays
            string[] myNewStringArray;
            myNewStringArray = new string[] { "Will", "Fave", "Infinity Works" };
            // Console.WriteLine(myNewStringArray[1]);
            for (int i = 0; i < myNewStringArray.Length; i++)
            {
                // Console.WriteLine(myNewStringArray[i]);
            }

            int[] myNewIntegerArray = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < myNewIntegerArray.Length; i++)
            {
                // Console.WriteLine(myNewIntegerArray[i]);
            }
            // end of arrays

            // start of Lists
            List<CardClass> cards = new List<CardClass>();
            List<CardClass> secondPlayerCards = new List<CardClass>();
            cards.Add(new CardClass { name = "Trevor", age = 20 });
            cards.Add(new CardClass { name = "Pedro", age = 17 });
            cards.Add(new CardClass { name = "Dean", age = 20 });
            cards.Add(new CardClass { name = "Ash", age = 21 });
            cards.Add(new CardClass { name = "Joe", age = 22 });
            cards.Add(new CardClass { name = "Mizan", age = 24 });
            // end of list

            // twoPlayerDeck
            secondPlayerCards.Add(new CardClass { name = "DannyNoTats", age = 31 });
            secondPlayerCards.Add(new CardClass { name = "NotTrading", age = 1 });

            if (cards[0].age < secondPlayerCards[0].age)
            {
                secondPlayerCards.Add(cards[0]);
                cards.RemoveAt(0);
            }


            // for loop to look through the cards list.
            // for (int i = 0; i < cards.Count; i++)
            // {
            //     System.Console.WriteLine(cards[i].name);
            // }
            // System.Console.WriteLine(cards.Count);
            // cards.RemoveAt(0);
            // System.Console.WriteLine(cards.Count);


        }
    }
}
