using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpinskiTriangleFractal.Elements
{
    public class Points : VertexArray
    {
        public Points() : base(PrimitiveType.Points)
        {
            this.Append(
                new Vertex(new Vector2f(500, 500))
            );
        }

        public Vertex LastPoint { 
            get
            {
                this[this.VertexCount - 1] = new Vertex(this[this.VertexCount - 1].Position, Color.White);
                return this[this.VertexCount - 1]; 
            }
        }
    }
}
