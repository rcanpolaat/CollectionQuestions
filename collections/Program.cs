using System;
using System.Collections;

namespace collections
{
     class Program
    {
        static void Main(string[] args)
        {
            Questions questions = new Questions();

            questions.question1();
            //questions.question2();
            //questions.question3();

        }
    }

    class Questions
    {
        public void question1()
        {
            ArrayList PrimeNum = new ArrayList();
            ArrayList NonPrimeNum = new ArrayList();
            int count = 0;

            for (int i = 0; i < 20; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                    Console.WriteLine("Please enter positive number");
                else
                {
                    for (int j = 2; j <= num - 1; j++)
                    {
                        if (num % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 0 && num !=1)
                    {
                        PrimeNum.Add(num);
                    }
                    else
                    {
                        NonPrimeNum.Add(num);
                    }
                    count = 0;
                }
                
            }
            Console.WriteLine("Prime Numbers : ");

            PrimeNum.Sort();
            PrimeNum.Reverse();
            float PrimeNumAvg = 0;

            foreach (var n in PrimeNum)
            {
                Console.Write(n + ", ");
                PrimeNumAvg += Convert.ToInt32(n);
            }
            PrimeNumAvg = PrimeNumAvg / PrimeNum.Count;
            Console.WriteLine("Number of Prime Numbers : {0} Average of Prime Numbers : {1} ", PrimeNum.Count, PrimeNumAvg);


            Console.WriteLine("NonPrime Numbers : ");

            NonPrimeNum.Sort();
            NonPrimeNum.Reverse();
            float NonPrimeNumAvg = 0;

            foreach (var m in NonPrimeNum)
            {
                Console.Write(m + ", ");
                NonPrimeNumAvg += Convert.ToInt32(m);
            }
            NonPrimeNumAvg = NonPrimeNumAvg / NonPrimeNum.Count;

            Console.WriteLine("Number of Non-Prime Numbers : {0} Average of Non-Prime Numbers : {1} ", NonPrimeNum.Count, NonPrimeNumAvg);

        }

        public void question2()
        {
            int[] List = new int[20];
            int[] BigNums = new int[3];
            int[] SmallNums = new int[3];
            float BigNumsAvg = 0;
            float SmallNumsAvg = 0;
            float TotalAvg = 0;

            for (int i = 0; i < 20; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                List[i] = num;
            }

            Array.Sort(List);
            for(int x=0; x<3; x++)
            {
                SmallNums[x] = List[x];
                SmallNumsAvg += Convert.ToInt32(SmallNums[x]);
            }
            SmallNumsAvg /= SmallNums.Length;

            Array.Reverse(List);
            for (int y = 0; y < 3; y++)
            {
                BigNums[y] = List[y];
                BigNumsAvg += Convert.ToInt32(BigNums[y]);
            }
            BigNumsAvg /= BigNums.Length;
            TotalAvg = BigNumsAvg + SmallNumsAvg;

            Console.WriteLine("Big Numbers Average : {0}", BigNumsAvg);
            Console.WriteLine("Small Numbers Average : {0}", SmallNumsAvg);
            Console.WriteLine("Sum of Small and Big Numbers Averages : {0}", TotalAvg);

        }

        public void question3()
        {
            ArrayList vowelList = new ArrayList();

            Console.WriteLine("Please Enter a Sentence");
            string sentence = Console.ReadLine();
            string vowels = "aeıioöuü";

            sentence = sentence.ToLower();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    vowelList.Add(sentence[i]);
                }
            }

            vowelList.Sort();
            foreach (var letter in vowelList)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
