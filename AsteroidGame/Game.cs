using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using AsteroidGame.VisualObjects;

namespace AsteroidGame
{
    internal static class Game
    {
        private static BufferedGraphicsContext __Context;
        private static BufferedGraphics __Buffer;

        private static VisualObject[] __GameObjects;
        private static SunStar __SunStar;
        private static SpaceShip __SpaceShip;
        private static int DirX, DirY;


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

            //обработчик нажатия клавиши

            form.KeyDown += new KeyEventHandler(Game_form_KeyDown);

        }

        //задаем клавиши для управления кораблем
        private static void Game_form_KeyDown(object sender, KeyEventArgs e)
        {

            MessageBox.Show(e.KeyCode.ToString());
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    DirX = 1;
                    break;

                case "Left":
                    DirX = -1;
                    break;

                case "Up":
                    DirY = -1;
                    break;

                case "Down":
                    DirY = 1;
                    break;
            }
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

            __SpaceShip.Draw(g);

            __Buffer.Render();
        }

        public static void Load()
        {
            List<VisualObject> game_object = new List<VisualObject>();

            var rnd = new Random();

            for (var i = 0; i < 10; i++)
            {

                //делаем движение звезд в произвольном направлении
                game_object.Add(new Star(
                    new Point(rnd.Next(0, Width), rnd.Next(0, Height)),
                    new Point(rnd.Next(-10, 10), rnd.Next(-10, 10)),
                    10));

            }

            __SunStar = new SunStar(new Point(325, 225), 125);

            const int _ship_speed = 10;

            __SpaceShip = new SpaceShip(
                new Point(100,100),
                new Point(),
                50);

            __GameObjects = game_object.ToArray();
        }

        public static void Update()

        {
            foreach (var game_object in __GameObjects)
                game_object.Update();
            __SunStar.Update();
            __SpaceShip.Update();
        }

    }
}
