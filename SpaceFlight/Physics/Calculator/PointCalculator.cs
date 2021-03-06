﻿using System;
using System.Drawing;
using SpaceFlight.Physics.Units;

namespace SpaceFlight.Physics.Calculator
{
    public class PointCalculator
    {
        public static float Distance(PointF p1, PointF p2) =>
            (float) Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));

        public static Angle CalculateAngle(PointF p1, PointF p2) =>
            Angle.FromDegrees((Math.Atan2(p2.Y - p1.Y, p2.X - p1.X) * -180 / Math.PI) + 90 );

        public static double GetVectorX(Vector v) => v.Value * Math.Sin(v.Angle.Radian);
        public static double GetVectorY(Vector v) => v.Value * Math.Cos(v.Angle.Radian);

    }
}
