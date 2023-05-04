using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Dice
    {
        private int upperTotal;
        private int lowerTotal;
        private int grandTotal;
        private int firstDice;
        private int secondDice;
        private int thirdDice;
        private int fourthDice;
        private int fifthDice;

        public Dice()
        {
            var randNum1 = new Random();

            upperTotal = 0;
            lowerTotal = 0;
            grandTotal = 0;
            firstDice = randNum1.Next(1,7);
            secondDice = randNum1.Next(1,7);
            thirdDice = randNum1.Next(1,7);
            fourthDice = randNum1.Next(1,7);
            fifthDice = randNum1.Next(1,7);
        }
        //Below are methods for Yahtzee scoring based off the challenges
        public int Aces()
        {
            int count = 0;
            int[] array1 = new int[] { firstDice, secondDice, thirdDice, fourthDice, fifthDice };
            foreach(int i in array1)
            {
                if(i == 1)
                {
                    count = count + 1;
                }
            }
            return count;
        }
        public int Twos()
        {
            int count = 0;
            int[] array1 = new int[] { firstDice, secondDice, thirdDice, fourthDice, fifthDice };
            foreach(int i in array1)
            {
                if (i == 2)
                {
                    count = count + 2;
                }
            }
            return count;
        }
        public int Threes()
        {
            int count = 0;
            int[] array1 = new int[] { firstDice, secondDice, thirdDice, fourthDice, fifthDice };
            foreach(int i in array1)
            {
                if (i == 3)
                {
                    count = count + 3;
                }
            }
            return count;
        }
        public int Fours()
        {
            int count = 0;
            int[] array1 = new int[] { firstDice, secondDice, thirdDice, fourthDice, fifthDice };
            foreach(int i in array1)
            {
                if (i == 4)
                {
                    count = count + 4;
                }
            }
            return count;
        }
        public int Fives()
        {
            int count = 0;
            int[] array1 = new int[] { firstDice, secondDice, thirdDice, fourthDice, fifthDice };
            foreach(int i in array1)
            {
                if (i == 5)
                {
                    count = count + 5;
                }
            }
            return count;
        }
        public int Sixes()
        {
            int count = 0;
            int[] array1 = new int[] { firstDice, secondDice, thirdDice, fourthDice, fifthDice };
            foreach(int i in array1)
            {
                if (i == 6)
                {
                    count = count + 6;
                }
            }
            return count;
        }
        public int ThreeOfAKind()
        {
            List<int> list = new List<int>() { firstDice, secondDice, thirdDice, fourthDice, fifthDice };

            Dictionary<int, int> freqMap = list.GroupBy(x => x)
                                                .Where(g => g.Count() > 1)
                                                .ToDictionary(x => x.Key, x => x.Count());
            if (freqMap.ContainsValue(3))
            {
                return firstDice + secondDice + thirdDice + fourthDice + fifthDice;
            }
            else
            {
                return 0;
            }

        }
        public int FourOfAKind()
        {
            List<int> list = new List<int>() { firstDice, secondDice, thirdDice, fourthDice, fifthDice };

            Dictionary<int, int> freqMap = list.GroupBy(x => x)
                                                .Where(g => g.Count() > 1)
                                                .ToDictionary(x => x.Key, x => x.Count());
            if (freqMap.ContainsValue(4))
            {
                return firstDice + secondDice + thirdDice + fourthDice + fifthDice;
            }
            else
            {
                return 0;
            }
        }
        public int FullHouse()
        {
            List<int> list = new List<int>() { firstDice, secondDice, thirdDice, fourthDice, fifthDice };

            Dictionary<int, int> freqMap = list.GroupBy(x => x)
                                                .Where(g => g.Count() > 1)
                                                .ToDictionary(x => x.Key, x => x.Count());
            if (freqMap.ContainsValue(3) && freqMap.ContainsValue(2))
            {
                return 25;
            }
            else
            {
                return 0;
            }
        }
        public int SmallStraight()
        {
            List<int> list = new List<int>() { firstDice, secondDice, thirdDice, fourthDice, fifthDice };

            Dictionary<int, int> freqMap = list.GroupBy(x => x)
                                                .Where(g => g.Count() > 1)
                                                .ToDictionary(x => x.Key, x => x.Count());
            if ((freqMap.ContainsKey(1) && freqMap.ContainsKey(2) && freqMap.ContainsKey(3) && freqMap.ContainsKey(4)) || 
                (freqMap.ContainsKey(2) && freqMap.ContainsKey(3) && freqMap.ContainsKey(4) && freqMap.ContainsKey(5)) ||
                (freqMap.ContainsKey(3) && freqMap.ContainsKey(4) && freqMap.ContainsKey(5) && freqMap.ContainsKey(6)))
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }
        public int LargeStraight()
        {
            //Boolean verification = false;

            List<int> list = new List<int>() { firstDice, secondDice, thirdDice, fourthDice, fifthDice };

            Dictionary<int, int> freqMap = list.GroupBy(x => x)
                                                .Where(g => g.Count() > 1)
                                                .ToDictionary(x => x.Key, x => x.Count());
            if (freqMap.ContainsKey(1) && freqMap.ContainsKey(2) && freqMap.ContainsKey(3) && freqMap.ContainsKey(4) && freqMap.ContainsKey(5) || 
                (freqMap.ContainsKey(2) && freqMap.ContainsKey(3) && freqMap.ContainsKey(4) && freqMap.ContainsKey(5) && freqMap.ContainsKey(6)))
            {
                return 40;
            }
            else
            {
                return 0;
            }
        }
        public int Yahtzee()
        {
            if(firstDice == secondDice && firstDice == thirdDice && firstDice == fourthDice && firstDice == fifthDice)
            {
                return 50;
            }
            else
            {
                return 0;
            }
        }
        public int Chance()
        {
            int count = firstDice + secondDice + thirdDice + fourthDice + fifthDice;
            return count;
        }
        public int UpperTotal()
        {
            return upperTotal += upperTotal + Aces() + Twos() + Threes() + Fours() + Fives() + Sixes();
        }
        public int LowerTotal()
        {
            return lowerTotal += lowerTotal + ThreeOfAKind() + FourOfAKind() +
                FullHouse() + SmallStraight() + LargeStraight() + Yahtzee() + Chance();
        }
        public int GrandTotal()
        {
            return grandTotal += grandTotal + Aces() + Twos() + Threes() + Fours() + Fives() + Sixes() + ThreeOfAKind() + FourOfAKind() +
                FullHouse() + SmallStraight() + LargeStraight() + Yahtzee() + Chance(); 
        }
        public String Rolls()
        {
            String guide = "You rolled a " + firstDice + ", " + secondDice + ", " + thirdDice + ", " + fourthDice + ", and " + fifthDice
                + "\n\nYour choices are:";
            if (Aces() != 0)
            {
                guide += "\nAces: " + Aces() + "pts";
            }
            if(Twos() != 0)
            {
                guide += "\nTwos: " + Twos() + "pts";
            }
            if(Threes() != 0)
            {
                guide += "\nThrees: " + Threes() + "pts";
            }
            if(Fours() != 0)
            {
                guide += "\nFours: " + Fours() + "pts";
            }
            if(Fives() != 0)
            {
                guide += "\nFives: " + Fives() + "pts";
            }
            if(Sixes() != 0)
            {
                guide += "\nSixes: " + Sixes() + "pts";
            }
            if(ThreeOfAKind() != 0)
            {
                guide += "\nThree of a kind: " + ThreeOfAKind() + "pts";
            }
            if(FourOfAKind() != 0)
            {
                guide += "\nFour of a kind: " + FourOfAKind() + "pts";
            }
            if(FullHouse() != 0)
            {
                guide += "\nFull House: " + FullHouse() + "pts";
            }
            if(SmallStraight() != 0)
            {
                guide += "\nSmall Straight: " + SmallStraight() + "pts";
            }
            if(LargeStraight() != 0)
            {
                guide += "\nLarge Straight: " + LargeStraight() + "pts";
            }
            if(Yahtzee() != 0)
            {
                guide += "\nYahtzee: " + Yahtzee() + "pts";
            }
            if(Chance() != 0)
            {
                guide += "\nChance: " + Chance() + "pts";
            }
            return guide;
        }
        
    }
}
