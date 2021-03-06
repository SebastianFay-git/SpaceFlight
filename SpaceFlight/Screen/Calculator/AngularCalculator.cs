﻿using System;
using System.Drawing;

namespace SpaceFlight.Screen.Calculator
{
    class AngularCalculator
    {
        private readonly double _angle;
        private readonly PointF _center;

        public AngularCalculator(float angle, PointF center)
        {
            _angle = angle * Math.PI / 180;
            _center = center;
        }

        // Changed code from Fraser Chapman: https://stackoverflow.com/a/13695630
        public PointF Turn(PointF p)
        {
            var cosTheta = Math.Cos(_angle);
            var sinTheta = Math.Sin(_angle);
            return new PointF(
                (float)
                (cosTheta * (p.X - _center.X) -
                sinTheta * (p.Y - _center.Y) + _center.X),
                (float)
                (sinTheta * (p.X - _center.X) +
                cosTheta * (p.Y - _center.Y) + _center.Y)
           );
        }
    }
}
