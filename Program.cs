using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDelegateExcercise
{
    public delegate void SpinVal(int a,int b);
    public class Program
    {
        public static int energy;public static int winprob;
        static void Main(string[] args)
        {
            Spin obj = new Spin();
            SpinVal spinval = new SpinVal(obj.InitialSpin);
            string name; int LuckyNum;
            Console.WriteLine("Enter you Name");
            name = Console.ReadLine();
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Lucky Number between 1-10");
                LuckyNum = int.Parse(Console.ReadLine());
                switch (LuckyNum)
                {
                    case 1: spinval += obj.FirstSpin;break;
                    case 2: spinval += obj.SecondSpin;break;
                    case 3: spinval += obj.ThirdSpin;break;
                    case 4: spinval += obj.FourthSpin;break;
                    case 5: spinval += obj.FifthSpin;break;
                    case 6: spinval += obj.SixthSpin;break;
                    case 7: spinval += obj.SeventhSpin;break;
                    case 8: spinval += obj.EighthSpin;break;
                    case 9: spinval += obj.NinthSpin;break;
                    case 10: spinval += obj.TenthSpin;break;
                        default: Console.WriteLine("Invalid Lucky number !!!");break;
                }
            }
            spinval(energy, winprob);
            Console.WriteLine("Final energy is = "+energy + " and Final Winning Probability is = " + winprob);
            if (energy>=4 && winprob > 60)
            {
                Console.WriteLine("YOU WIN !!!");
            }
            else
            {
                Console.WriteLine("You Lost !!!");
            }
            Console.ReadKey();
        

        }
    }
}
