using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample31
{
    internal class Program
    {
        class Parent
        {
            public static int counter = 0;

            public void CountParent()
            {
                Parent.counter++;
            }
            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(string name) { Console.WriteLine("Parent(string name)"); }
            public Parent(float param) { Console.WriteLine("Parent(double param)"); }
        }
        class Child : Parent
        {
            public void CountChild()
            {
                Child.counter++;
            }
            public Child() : base("child")
            {
                Console.WriteLine("Child()");
            }
            public Child(string name) : base(name)
            {
                Console.WriteLine("Child(name)");
            }
            public Child(float param) : base(param)
            {
                Console.WriteLine("Child(dobule param)");
            }
        }
        static void Main(string[] args)
        {
            Child childA = new Child("abc");
            Child childB = new Child(3L);
            // int < long < float < double 
            //  4     8      4      8

            Parent parent = new Parent();
            Child child = new Child();

            parent.CountParent();
            child.CountChild();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);

        }
    }
}