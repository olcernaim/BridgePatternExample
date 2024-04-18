using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternExample1
{
    public abstract class Shape
    {
        public string _type { get; set; }
        public Color _color { get; set; }

        public Shape(Color color, string type)
        {
            _type = type;
            _color = color;
        }

        public override string ToString()
        {
            return $"I am a {_color.Log() } {_type}";
        }
    }
}
