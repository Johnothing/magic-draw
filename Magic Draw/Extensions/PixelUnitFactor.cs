﻿namespace Johnothing.MagicDraw.Extensions
{
    public static class PixelUnitFactor
    {
        public const double Px = 1.0;
        public const double Inch = 96.0;
        public const double Cm = 37.7952755905512;
        public const double Pt = 1.33333333333333;

        public static double CmToPx(this double cm)
        {
            return cm * Cm;
        }

        public static double PxToCm(this double px)
        {
            return px / Cm;
        }
    }
}
