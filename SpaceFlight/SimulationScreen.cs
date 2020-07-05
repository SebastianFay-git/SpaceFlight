﻿using System;
using SpaceFlight.Screen;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using SpaceFlight.Objects.Rocket;
using SpaceFlight.Objects.Terrain;
using SpaceFlight.Physics;
using SpaceFlight.Physics.Other;
using SpaceFlight.Game;
using SpaceFlight.Physics.Units;
using SpaceFlight.Screen.Calculator;
using Timer = System.Windows.Forms.Timer;

namespace SpaceFlight
{
    public partial class SimulationScreen : Form
    {
        public SimulationScreen()
        {
            InitializeComponent();
            new Game.Game(SimulationPanel, "atlas-V-401-earth");
        }
    }
}
