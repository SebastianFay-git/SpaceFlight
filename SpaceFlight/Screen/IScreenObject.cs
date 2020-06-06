﻿using SpaceFlight.Screen.Calculator;
using System.Drawing;

namespace SpaceFlight.Screen
{
    interface IScreenObject
    {
        RectangleF GetBounds();
        void Draw(Graphics g, ProjectedPositionCalculator ppCalc, RectangleF screen, bool information);
        PointF GetMiddle();
        int GetPriority();
    }
}