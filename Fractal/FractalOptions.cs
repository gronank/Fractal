using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    public class FractalOptions
    {
        float minScale;
        float smallScale;//length of the smallest features of the map in tiles
        float largeScale;//length of the largest features of the map in tiles

        public FractalOptions(float smallScale, float largeScale, float minScale = 0.0001f)
        {
            this.smallScale = smallScale;
            this.largeScale = largeScale;
            this.minScale = minScale;

        }
        public float getScale(float generation)
        {
            var c = -(largeScale - smallScale) * (smallScale - largeScale) / 4;
            var f = (generation - smallScale) * (generation - largeScale) / c;
            return (float)(Math.Exp(-f) * (1 / (1 + Math.Exp(-2 * (generation - minScale) / minScale))));
        }

    }

}
