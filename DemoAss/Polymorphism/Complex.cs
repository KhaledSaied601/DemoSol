using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAss.Polymorphism
{
    internal class Complex
    {
        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }


        public int Real { get; set; }
        public int Imaginary { get; set; }




        public override string ToString()
        {
            return $"{Real} + {Imaginary} i";
        }


        public static Complex operator + (Complex left, Complex right)
        {

            return new Complex(

                left?.Real ?? 0 + right?.Real ?? 0,
                left?.Imaginary ?? 0 + right?.Imaginary ?? 0


                );

        }

        public static Complex operator +(int left, Complex right)
        {

            return new Complex(

                left + right?.Real ?? 0,

                right?.Imaginary??0


                );

        }

        public static Complex operator +( Complex left, int right)
        {

            return new Complex(

                right + left?.Real ?? 0,

                left?.Imaginary ?? 0


                );

        }

        public static bool operator > (Complex left, Complex right)
        {
            if (left.Real == right.Real)
            {
                return left.Imaginary > right.Imaginary;
            }
            else
            {
              return  left.Imaginary > right.Imaginary;
            }
        }

        public static bool operator < (Complex left, Complex right)
        {
            if (left.Real == right.Real)
            {
                return left.Imaginary < right.Imaginary;
            }
            else
            {
              return  left.Imaginary < right.Imaginary;
            }

        }

    }
}
