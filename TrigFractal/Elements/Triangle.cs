using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpinskiTriangleFractal.Elements
{
    public class Triangle : VertexArray
    {
        public Triangle() : base(PrimitiveType.LineStrip, 4)
        {
            Points = new Points();

            this[0] = new Vertex(
                new Vector2f(500f, 10f),
                Color.Red
            );

            this[1] = new Vertex(
                new Vector2f(10f, 990f),
                Color.Red
            );

            this[2] = new Vertex(
                new Vector2f(990f, 990f),
                Color.Red
            );

            this[3] = new Vertex(
                new Vector2f(500f, 10f),
                Color.Red
            );
        }

        public Points Points { get; set; }

        public void AddRandomPoint()
        {
            var random = new Random();
            var rand = random.Next(0, 3);
            Console.WriteLine(rand);
            var randomTriangleVertex = this[(uint)rand];
            var lastPoint = Points.LastPoint;

            var newPoint = new Vertex(
                new Vector2f(
                    (randomTriangleVertex.Position.X + lastPoint.Position.X) / 2,
                    (randomTriangleVertex.Position.Y + lastPoint.Position.Y) / 2
                ),
                Color.Green
            );

            this.Points.Append(newPoint);
        }
    }
}
