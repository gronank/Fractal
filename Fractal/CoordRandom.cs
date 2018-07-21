using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    internal class CoordRandom
    {
        private uint InternalSeed;
        int width, height;
        internal CoordRandom(uint seed=620475)
        {
            InternalSeed = seed;
        }
        internal float RandFloat(int x, int y){
            x %= width;
            y %= height;
            return (float)(GetXYNoise(x, y, 1028)) / 1028f;
        }

        private static uint BitRotate(uint x)
        {
            const int bits = 16;
            return (x << bits) | (x >> (32 - bits));
        }

        private uint GetXYNoise(int x, int y, uint MaxN)
        {
            UInt32 num = InternalSeed;
            for (uint i = 0; i < 4; i++)
            {
                num = num * 541 + (uint)x;
                num = BitRotate(num);
                num = num * 809 + (uint)y;
                num = BitRotate(num);
                num = num * 673 + (uint)i;
                num = BitRotate(num);
            }
            return num % MaxN;
        }
        internal void SetWrapLimit(int width,int height){
            this.width = width;
            this.height = height;
        }
    }
}
