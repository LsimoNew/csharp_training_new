using System;
using System.Collections.Generic;
using System.Text;

namespace addition
{

    class Circle : Figure
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
    }
}
