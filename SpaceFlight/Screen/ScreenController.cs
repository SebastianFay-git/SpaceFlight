﻿using SpaceFlight.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceFlight.Screen
{
    class ScreenController
    {
        private readonly Panel _panel;
        private readonly Graphics _graphics;

        private FrameRateCounter actualFramerate;
        private Color color;

        private readonly List<IScreenObject> _panelObjects;
        private readonly Timer _drawTimer;

        public ScreenController(Panel panel, Color color)
        {
            _panel = panel;
            this.color = color;

            _graphics = panel.CreateGraphics();
            _panelObjects = new List<IScreenObject>();
            actualFramerate = new FrameRateCounter();

            _drawTimer = new Timer();
            _drawTimer.Interval = 10;
            _drawTimer.Tick += Redraw;
            _drawTimer.Start();
        }

        public void Redraw(object sender, EventArgs e)
        {
            _graphics.
            _graphics.Clear(color);
            _panelObjects.ForEach(x => DrawObject(x, _panel.Bounds));
            actualFramerate.FrameDrawn();
        }

        private void DrawObject(IScreenObject o, Rectangle panelBounds)
        {
            if (!panelBounds.IntersectsWith(o.GetBounds()))
                return;

            o.Draw(_graphics);
        }

        public void AddPanelObject(IScreenObject o) => _panelObjects.Add(o);

        public void RemovePanelObject(IScreenObject o) => _panelObjects.RemoveAll(x => x == o);

        public int GetActualFramerate() => actualFramerate.Framerate;

    }
}
