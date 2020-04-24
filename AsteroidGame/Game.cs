﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsteroidGame
{
    internal static class Game
    {
        private static BufferedGraphicsContext __Context;
        private static BufferedGraphics __Buffer;

        private static VisualObject[] __GameObjects;
        private static SunStar __SunStar;
        //private static Ship __Ship;

        public static int Width { get; set; }

        public static int Height { get; set; }

        public static void Initialize(Form form)
        {
            Width = form.Width;
            Height = form.Height;

            __Context = BufferedGraphicsManager.Current;
            Graphics g = form.CreateGraphics();
            __Buffer = __Context.Allocate(g, new Rectangle(0, 0, Width, Height));

            Timer timer = new Timer { Interval = 100 };
            timer.Tick += OnVimerTick;
            timer.Start();

        }

        private static void OnVimerTick(object sender, EventArgs e)
        {
            Update();
            Draw();
        }

        public static void Draw()
        {
            Graphics g = __Buffer.Graphics;

            g.Clear(Color.Black);
            //g.DrawRectangle(Pens.White, new Rectangle(50,50, 200,200));
            //g.FillEllipse(Brushes.Red, new Rectangle(100,50, 70,120));

            foreach (var game_object in __GameObjects)

                game_object.Draw(g);
            __SunStar.Draw(g);
            __Buffer.Render();
        }

        public static void Load()
        {
            List<VisualObject> game_object = new List<VisualObject>();

            for (var i = 0; i < 10; i++)
            {
                game_object.Add(new Star(
                    new Point(400, (int)(i / 2.0 * 20)),
                    new Point(-i, 0),
                    10));
            }

            __SunStar = new SunStar(new Point(350, 200), 100);

            __GameObjects = game_object.ToArray();
        }

        public static void Update()
        {
            foreach (var game_object in __GameObjects)
                game_object.Update();
            __SunStar.Update();
        }
    }
}
