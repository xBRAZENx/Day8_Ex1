using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDelegateExcercise
{
    public class Spin
    {
        public void InitialSpin(int energy,int winprob)
        {
            Program.energy = 1;Program.winprob = 100;
        }
        public void FirstSpin(int energy, int winprob)
        {
            Program.energy += 1;Program.winprob += 10;
        }
        public void SecondSpin(int energy, int winprob)
        {
            Program.energy += 2; Program.winprob += 20;
        }
        public void ThirdSpin(int energy, int winprob)
        {
            Program.energy -= 3; Program.winprob -= 30;
        }
        public void FourthSpin(int energy, int winprob)
        {
            Program.energy += 4; Program.winprob += 40;
        }
        public void FifthSpin(int energy, int winprob)
        {
            Program.energy -= 5; Program.winprob -= 50;
        }
        public void SixthSpin(int energy, int winprob)
        {
            Program.energy -= 1; Program.winprob -= 60;
        }
        public void SeventhSpin(int energy, int winprob)
        {
            Program.energy += 1; Program.winprob += 70;
        }
        public void EighthSpin(int energy, int winprob)
        {
            Program.energy -= 2; Program.winprob -= 20;
        }
        public void NinthSpin(int energy, int winprob)
        {
            Program.energy -= 3; Program.winprob -= 30;
        }
        public void TenthSpin(int energy, int winprob)
        {
            Program.energy += 10; Program.winprob += 100;
        }
    }
}
