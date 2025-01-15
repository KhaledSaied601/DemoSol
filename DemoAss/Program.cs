using DemoAss.AccessModifiers;
using DemoAss.Inheritance;
using DemoAss.Polymorphism;

namespace DemoAss
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Inheritance

            //Console.WriteLine("---------Parent-------------");
            //Parent p = new Parent(5, 2);
            //Console.WriteLine(p);
            //Console.WriteLine(p.product());
            //Console.WriteLine(p.Sum());




            //Console.WriteLine("-----------Child1---------");

            //Child c1 = new Child(10, 5, 2);
            //Console.WriteLine(c1);
            //Console.WriteLine(c1.product());
            //Console.WriteLine(c1.Sum());




            //Console.WriteLine("-----------Child2---------");

            //Parent c2 = new Child(10, 5, 2);
            //Console.WriteLine(c2);
            //Console.WriteLine(c2.product());
            //Console.WriteLine(c2.Sum());

            #endregion


            #region AccessModifiers


            //Console.WriteLine("---------- Type A --------------------");
            //TypeA typeA = new TypeA(1, 2, 5, 8, 6, 7, 8);


            //typeA.A = 1; //Default Private 
            //typeA.B = 1; //private
            //typeA.C = 1; //internal
            //typeA.D = 1; // public
            //typeA.E = 1; //Protected
            //typeA.F = 1; //Private Protected
            //typeA.G = 1; //Internal Protected

            //Console.WriteLine(typeA);


            //Console.WriteLine("---------- Type B --------------------");
            //TypeB typeB = new TypeB(1, 2, 5, 8, 6, 7, 8, 200);


            //typeB.A = 1; //Default Private 
            //typeB.B = 1; //private
            //typeB.C = 1; //internal (Inherit inside Assembly)
            //typeB.D = 1; // public (Inherit inside and outSide Assembly)
            //typeB.E = 1; //Protected (Inherit inside and outSide Assembly as Private) it means Can Use Only Inside Class
            //typeB.F = 1; //Private Protected (Inherit inside  Assembly as Private and can't be inherit Outside Assembly) It Means Can Only Use Inside a class
            //typeB.G = 1; //Internal Protected (Inherit inside Assembly as Internal and outSide Assembly as Private)

            //typeB.H = 1; //

            //Console.WriteLine(typeB);







            #endregion



            #region Polymorphism

            //Complex complex01 = new Complex(5, 2);
            //Console.WriteLine(complex01);  


            //Complex complex02 = new Complex(10, 1);
            //Console.WriteLine(complex02);

            //Console.WriteLine(complex01+complex02);
            //Console.WriteLine(complex01+5);
            //Console.WriteLine(5+complex02);

            //Console.WriteLine(complex01>complex02);
            //Console.WriteLine(complex01<complex02);






            #endregion



        }
    }
}
