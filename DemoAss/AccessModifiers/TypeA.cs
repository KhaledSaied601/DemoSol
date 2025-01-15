using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAss.AccessModifiers
{
    internal class TypeA
    {



        int A { get; set; }

        private int B { get; set; }

        internal int C { get; set; }

        public int D { get; set; }

        protected int E { get; set; }

        private protected int F { get; set; }

        internal protected int G { get; set; }

        public TypeA(int a,int b , int c,int d,int e,int f, int g)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
            F = f;
            G = g;
            
        }


        public override string ToString()
        {
            return $"A:{A} , B : {B} , C:{C} , D : {D} , F : {F} , G : {G} ";
        }









    }
}
