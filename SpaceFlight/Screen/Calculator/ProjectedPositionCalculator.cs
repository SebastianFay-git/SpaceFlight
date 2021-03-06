﻿using System;
using System.Drawing;

namespace SpaceFlight.Screen.Calculator
{
    class ProjectedPositionCalculator
    {
        private readonly PointF _rMP;
        private readonly Point _pMP;
        private readonly float _factor;

        public ProjectedPositionCalculator(PointF realMainPosition, Point projectedMainPosition, float scalingFactor)
        {
            _rMP = realMainPosition;
            _pMP = projectedMainPosition;
            _factor = scalingFactor;
        }

        public Point ProjectPoint(Point p) => ProjectPoint((PointF)p);
        public Point ProjectPoint(PointF p) => new Point(ProjectXCoordinate(p.X), ProjectYCoordinate(p.Y));

        public int ProjectXCoordinate(float x) => RoundToInt((_pMP.X + (x - _rMP.X)) * _factor);
        public int ProjectXCoordinate(int x) => ProjectXCoordinate((float)x);

        public int ProjectYCoordinate(int y) => ProjectYCoordinate((float)y);
        public int ProjectYCoordinate(float y) => RoundToInt((_pMP.Y + (y - _rMP.Y) * -1) * _factor);

        public PointF ReversPoint(Point p) => new PointF(ReverseProjectXCoordinate(p.X), ReverseProjectYCoordinate(p.Y));

        public float ReverseProjectXCoordinate(int reverseX) => reverseX / _factor - _pMP.X + _rMP.X;
        public float ReverseProjectYCoordinate(int reverseY) => -1 * (reverseY / _factor - _pMP.Y - _rMP.Y);

        public int RoundToInt(float f) => (int)Math.Round(f);
    }
}