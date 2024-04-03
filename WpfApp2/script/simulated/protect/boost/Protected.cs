using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WpfApp2.script.simulated.protect.boost
{
    public class Protected
    {
        static int min=0;
        static int max=3;

        static int minVirus=1;
        static int maxVirus=3;

        static int minTrojan = 1;
        static int maxTojan = 5;

        static int minRansomware = 3;
        static int maxRansomware = 8;

        static int minErrors = 5;
        static int maxErrors = 15;
        static Random rnd = new Random();

        public static int slowDownVirusTime() {
            return rnd.Next(minVirus*10,maxVirus*10);
        }
        public static int slowDownTrojanTime()
        {
            return rnd.Next(minTrojan * 2, maxTojan * 2);
        }
        public static int slowDownRansomwareTime()
        {
            return rnd.Next(minRansomware * 3, maxRansomware * 3);
        }
        public static int slowDownErrorsTime()
        {
            return rnd.Next(minErrors * 10, maxErrors * 10);
        }
        public static int WaitForSecond() {
            return rnd.Next(min,max);

        }
        public static bool FireWall()
        {
            return true;
        }
        public static void boostUpdateTime()
        {
            min -= (int)Math.Sqrt(min);
            max -= (int)Math.Sqrt(max);
        }
    }
}
