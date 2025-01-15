using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAss.Inheritance
{
    internal class Parent
    {


        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Parent(int _x, int _y)
        {
            x = _x;
            y = _y;
        }


        public override string ToString()
        {
            return $"X : {X} , Y : {Y}";
        }


        public virtual int product()
        {

            return X * Y;

        }

        public int Sum()
        {
            return X + Y;

        }







    }
}
