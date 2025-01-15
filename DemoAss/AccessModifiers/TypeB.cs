using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAss.AccessModifiers
{
    internal class TypeB:TypeA
    {

        public int H {  get; set; }



        public TypeB(int a, int b, int c, int d, int e, int f, int g,int h):base(a,b, c, d, e, f,g)
        {
            H = h;
            
        }

        public override string ToString()
        {
            return  $" C:{C} , D : {D} , F : {F} , G : {G} , H:{H} ";
        }
    }
}
