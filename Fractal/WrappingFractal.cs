using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    public class WrappingFractal
    {
        private static uint initSeed = 0;
        private static CoordRandom random;
        public static void Initialize(int seed)
        {
            initSeed = (uint)seed;

        }
        /// <summary>
        /// Constructs a fractal with options for wrapping
        /// </summary>
        /// <param name="n">The largest fractal distance, must be a factor of 2. Good size is 128 or 256</param>
        /// <param name="h">The number of vertical factals. Total height of the fractal is h*n</param>
        /// <param name="w">The number of horizontal factals. Total height of the fractal is w*n</param>
        /// <param name="options">Options for the lenth scale of the fractal</param>
        /// <param name="wrapMode">Options for fractal wraping</param>
        /// <returns></returns>
        public static float[,] fractal(int n, int h, int w, FractalOptions options,FractalWrapMode wrapMode, uint seed = 0)
        {
            
            if(initSeed != 0)
            {
                random = new CoordRandom(initSeed);
            }
            else if (seed != 0)
            {
                random = new CoordRandom(seed);
            }
            else
            {
                random = new CoordRandom();
            }

            float[,] output = new float[n * w + 1, n * h + 1];
            for (var i = 0; i < n * w + 1; i++)
            {
                for (var j = 0; j < n * h + 1; j++)
                {
                    output[i, j] = Single.NaN;
                }
            }

            int width = n * w;
            if (wrapMode == FractalWrapMode.NoWrap) width = n * w+1;
            int height = n * h + 1;
            if (wrapMode == FractalWrapMode.Doughnut) height = n * h;
            random.setWrapLimit(width, height);

            

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    fractal(w, h, n, i, j, options, ref output);
                }
            }
            return output;
        }
        private static void fractal(int w, int h,int n,int i,int j, FractalOptions options,ref float[,] map)
        {
            int length = n >> 1;
            float scale = options.getScale(length);
            //System.UnityEngine.Random UnityEngine.RandomNumber = new System.UnityEngine.Random();
            int x0 = i * n;
            int y0 = j * n;
            int width = (i + 1) * n;
            int height = (j + 1) * n;
            map[i * n, j * n] = scale * (randomFloat(i * n, j * n) - 0.5f);
            map[i * n, (j + 1) * n] = scale * (randomFloat(i * n, (j + 1) * n) - 0.5f);
            map[(i + 1) * n, j * n] = scale * (randomFloat((i + 1) * n, j * n) - 0.5f);
            map[(i + 1) * n, (j + 1) * n] = scale * (randomFloat((i + 1) * n, (j + 1) * n) - 0.5f);
            while (length > 0)
            {

                //Debug.Log(length);
                //diamond phase
                //float lengthScale = length;//length*Terrain.activeTerrain.terrainData.heightmapScale.x;
                scale = options.getScale(length);
                int x = x0+length;
                while (x < width)
                {
                    int y = y0+length;
                    while (y < height)
                    {

                        if (Single.IsNaN(map[x, y]))
                        {
                            map[x, y] = (map[x - length, y - length] +
                                map[x + length, y - length] +
                                map[x + length, y + length] +
                                map[x - length, y + length]) / 4f +
                                scale * (randomFloat(x,y) - 0.5f);

                        }
                        y += 2 * length;
                    }
                    x += 2 * length;
                }
                //h =getScaleFactor(generation+0.5f);
                //square phase
                x = x0;
                while (x <= width)
                {
                    int y = y0;
                    while (y <= height)
                    {
                        if (Single.IsNaN(map[x, y]))
                        {

                            if (y == 0)
                            {
                                map[x, y] = (map[x, y + length] +
                                    map[x + length, y] +
                                    map[x - length, y]) / 3f +
                                    scale * (randomFloat(x,y) - 0.5f);
                            }
                            else if (y == height)
                            {
                                map[x, y] = (map[x, y - length] +
                                    map[x + length, y] +
                                    map[x - length, y]) / 3f +
                                    scale * (randomFloat(x,y) - 0.5f);
                            }
                            else if (x == 0)
                            {
                                map[x, y] = (map[x, y - length] +
                                    map[x, y + length] +
                                    map[x + length, y]) / 3f +
                                    scale * (randomFloat(x,y) - 0.5f);
                            }
                            else if (x == width)
                            {
                                map[x, y] = (map[x, y - length] +
                                    map[x, y + length] +
                                    map[x - length, y]) / 3f +
                                    scale * (randomFloat(x,y) - 0.5f);
                            }
                            else
                            {

                                /*if(Single.IsNaN(map[x][ y - length])){
                                    trace(x+", "+(y - length)+" has not been assigned");
                                }
                                if(Math.isNaN(map[x][ y + length])){
                                    trace(x+", "+(y + length)+" has not been assigned");
                                }
                                if(Math.isNaN(map[x + length][ y])){
                                    trace("a");
                                }
                                if(Math.isNaN(map[x - length][ y])){
                                    trace("b");
                                }*/


                                map[x, y] = (map[x, y - length] +
                                    map[x, y + length] +
                                    map[x + length, y] +
                                    map[x - length, y]) / 4f +
                                    scale * (randomFloat(x,y) - 0.5f);
                            }
                        }
                        y += length;
                    }
                    x += length;
                }
                length = length >> 1;
            }
        }
        public static void shaveEdges(ref float[,] map)
        {
            float minVal=float.PositiveInfinity;
            for(int i=0;i<map.GetLength(0);i++){
                for(int j=0;j<map.GetLength(1);j++){
                    if(map[i,j]<minVal)minVal=map[i,j];
                }
            }
            for(int i=0;i<map.GetLength(0);i++){
                for(int j=0;j<map.GetLength(1);j++){
                    var d=2*(float)j/(map.GetLength(1))-1f;
                    var factor=(float)Math.Sqrt(1-d*d);
                    map[i,j]=factor*(map[i,j]-minVal);
                }
            }
            
        }
        /*
            for (int i = 0; i < 2*w; i++)
            {
                for (int j = 0; j < 2*h; j++)
                {
                    fractals.Add(Fractal.fractal(n, n, options));
                    /*for (int x = 0; x < n; x++)
                    {
                        for (int y = 0; y < n; y++)
                        {
                            var globalX = i * n/2 + x;
                            if (globalX >= n * w) globalX -= n * w;
                            var globalY = i * n / 2 + x;
                            if (globalY >= n * h) globalY -= n * h;
                            var factor=
                        }
                    }
                }
            }
            for (int i = 0; i < n * w; i++)
            {
                for (int j = 0; j < n * h; j++)
                {
                }
            }
            return output;
        }
         
    */
        private static float randomFloat(int x, int y)
        {
            return random.randFloat(x, y);
        }
    }
    public enum FractalWrapMode
    {
        NoWrap,
        Horizontal,
        Doughnut
    }
}
