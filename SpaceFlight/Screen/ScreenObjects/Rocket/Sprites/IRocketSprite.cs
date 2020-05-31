﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceFlight.Screen.ScreenObjects.Rocket.Sprites
{
    interface IRocketSprite
    {
        List<PointF> GetPointList(PointF position, int height);

        RectangleF GetBounds(PointF position, int height);
    }
}
