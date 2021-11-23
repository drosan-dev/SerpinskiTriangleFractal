using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SerpinskiTriangleFractal.Elements;

namespace SerpinskiTriangleFractal
{
    public class Window : RenderWindow
    {
        
        public Window() : base(new VideoMode(1000, 1000), "123")
        {
            Triangle = new Triangle();

            Closed += new EventHandler(OnClose);
            KeyPressed += OnKeyPressed;
        }

        public Triangle Triangle { get; set; }

        public void Run()
        {
            while (IsOpen)
            {
                DispatchEvents();

                Clear();
                Draw(Triangle);
                Draw(Triangle.Points);
                Display();
            }
        }

        private void OnKeyPressed(object sender, KeyEventArgs e)
        {
            Window window = (Window)sender;

            if (e.Code == Keyboard.Key.Space)
            {
                window.Triangle.AddRandomPoint();
            }
        }
        private void OnClose(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Close();
        }
    }
}
