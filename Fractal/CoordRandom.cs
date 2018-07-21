using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    class CoordRandom
    {
        private uint InternalSeed;
        int width, height;
        public CoordRandom(uint seed=620475)
        {
            InternalSeed = seed;
        }
        public float randFloat(int x, int y){
            x %= width;
            y %= height;
            return (float)(getXYNoise(x, y, 1028)) / 1028f;
        }

        private static uint bitRotate(uint x)
        {
            const int bits = 16;
            return (x << bits) | (x >> (32 - bits));
        }

        public uint getXYNoise(int x, int y, uint MaxN)
        {
            UInt32 num = InternalSeed;
            for (uint i = 0; i < 4; i++)
            {
                num = num * 541 + (uint)x;
                num = bitRotate(num);
                num = num * 809 + (uint)y;
                num = bitRotate(num);
                num = num * 673 + (uint)i;
                num = bitRotate(num);
            }
            return num % MaxN;
        }
        public void setWrapLimit(int width,int height){
            this.width = width;
            this.height = height;
        }
    }
}
