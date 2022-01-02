using System;
using System.Collections.Generic;
using System.Text;

namespace addition
{
    class Square : Figure
    {
        private int size;

        public Square(int size)
        {
            this.size = size;
        }

        public int Size
        {
            get { return size; }
            set { this.size = value; }
        }
    }

}
