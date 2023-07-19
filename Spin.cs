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
            energy = 1;winprob = 100;
        }
        public void FirstSpin(int energy, int winprob)
        {
            energy += 1;winprob += 10;
        }
        public void SecondSpin(int energy, int winprob)
        {
            energy += 2; winprob += 20;
        }
        public void ThirdSpin(int energy, int winprob)
        {
            energy -= 3; winprob -= 30;
        }
        public void FourthSpin(int energy, int winprob)
        {
            energy += 4; winprob += 40;
        }
        public void FifthSpin(int energy, int winprob)
        {
            energy -= 5; winprob -= 50;
        }
        public void SixthSpin(int energy, int winprob)
        {
            energy -= 1; winprob -= 60;
        }
        public void SeventhSpin(int energy, int winprob)
        {
            energy += 1; winprob += 70;
        }
        public void EighthSpin(int energy, int winprob)
        {
            energy -= 2; winprob -= 20;
        }
        public void NinthSpin(int energy, int winprob)
        {
            energy -= 3; winprob -= 30;
        }
        public void TenthSpin(int energy, int winprob)
        {
            energy += 10; winprob += 100;
        }
    }
}
