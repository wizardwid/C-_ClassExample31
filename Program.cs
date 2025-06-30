using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample31
{
    internal class Program
    {
        private static bool number;

        class Parent
        {
            public static int counter = 0;
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
            public virtual void MethodO()
            {
                Console.WriteLine("부모의 메서드");
            }

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

            public new String variable = "Hiding";
            public new void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
            public override void MethodO()
            {
                Console.WriteLine("자식의 메서드");
            }
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

            // 섀도잉
            int number = 20; 
            Console.WriteLine(number); // 클래스 변수 이름이 가려짐(shadowing)
            Console.WriteLine(Program.number); // 호출하고 싶으면 클래스 변수명으로 사용

            Child childA = new Child("abc");
            Child childB = new Child(3L);

            Parent parent = new Parent();
            Child child = new Child();

            parent.CountParent();
            child.CountChild();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);

            // 변수 하이딩
            Child child3 = new Child();
            Console.WriteLine(child3.variable); // 문자열 variable을 출력
            Console.WriteLine(((Parent)child3).variable); // 숫자 variable 출력

            // 메서드 하이딩
            child3.Method(); // 자식 메서드 출력
            ((Parent)child3).Method(); // 부모 메서드 출력

            // 메서드 오버라이딩
            child3.MethodO(); // 자식 메서드 출력
            ((Parent)child3).MethodO(); // 부모 메서드 출력

            // 메서드 하이딩, 오버라이딩 비교 구현
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };
            foreach(var item in Animals)
            {
                item.Eat();
            }
        }
    }
}