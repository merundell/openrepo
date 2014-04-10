using System;

namespace Utilities
{
    public static class Dice
    {
        public static int Roll(int dieCount, int dieSideCount)
        {
            int seed = (int)DateTime.Now.Ticks;
            return new Random(seed).Next(dieCount, dieCount * dieSideCount);
        }

        public static int Roll1d6()
        {
            return Roll(1, 6);
        }

        public static int Roll2d6()
        {
            return Roll(2, 6);
        }
    }
}
