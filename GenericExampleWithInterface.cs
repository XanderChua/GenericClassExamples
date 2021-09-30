using System;
using System.Collections.Generic;

namespace GenericExample
{
    class Parent
    {

    }

    class Child : Parent
    {

    }

    class GrandChild : Child
    {

    }

    class Something
    {

    }
    class Device<T>//properties
    {
        public T name { get; set; }
        public T category { get; set; }
    }
    class Program
    {      
        public class SampleClass<T> where T : struct
        {
            T[] arrObj = new T[5];
            int count = 0;

            public void Add(T item)
            {
                if(count < 5)
                {
                    arrObj[count] = item;
                }
                count++;
            }

            public T this[int index]
            {
                get { return arrObj[index]; }
                set { arrObj[index] = value; }
            }
        }
        static void Main(string[] args)
        {
            //genericMethodLevel(); 
            //genericClassLevel(); 
            genericAtFunctionInsideClass();
        }

        private static void genericAtFunctionInsideClass()
        {
            SampleClass<float> floatClass = new SampleClass<float>();
            floatClass.Add(3.4f);
            floatClass.Add(1.4f);
            floatClass.Add(2.4f);
            floatClass.Add(4.4f);
            floatClass.Add(5.4f);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(floatClass[i]);
            }

            SampleClass<int> intClass = new SampleClass<int>();
            intClass.Add(3);
            intClass.Add(1);
            intClass.Add(2);
            intClass.Add(4);
            intClass.Add(5);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intClass[i]);
            }

            SampleClass<bool> boolClass = new SampleClass<bool>();
            boolClass.Add(true);
            boolClass.Add(true);
            boolClass.Add(true);
            boolClass.Add(false);
            boolClass.Add(false);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(boolClass[i]);
            }
        }
        private static void genericClassLevel()
        {
            //Device<Parent> intObj = new Device<Parent>();
            //Device<Child> intObj = new Device<Child>();
            //Device<GrandChild> intObj = new Device<GrandChild>();
            //Device<Something> intObj = new Device<Something>(); //not in parent class
            Device<int> intObj = new Device<int>();
            Device<float> floatObj = new Device<float>();
            Device<string> stringObj = new Device<string>();

            intObj.name = 1;
            intObj.category = 2;

            floatObj.name = 5.1f;
            floatObj.category = 3.4f;

            stringObj.name = "Somename";
            stringObj.category = "Somecategory";

            Console.WriteLine("The name is: " + intObj.name + " in " + intObj.category);
            Console.WriteLine("The name is: " + floatObj.name + " in " + floatObj.category);
            Console.WriteLine("The name is: " + stringObj.name + " in " + stringObj.category);
        }
        private static void genericMethodLevel()
        {
            int a = 3;
            int b = 4;
            Console.WriteLine("Before swapping");
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            swap<int>(ref a, ref b);
            Console.WriteLine("After swapping");
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            float c = 1.5f;
            float d = 5.5f;
            Console.WriteLine("Before swapping");
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);
            swap<float>(ref c, ref d);
            Console.WriteLine("After swapping");
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);


            string s1 = "Something";
            string s2 = "Someone";
            Console.WriteLine("Before swapping");
            Console.WriteLine("s1: " + s1);
            Console.WriteLine("s2: " + s2);
            swap<string>(ref s1, ref s2);
            Console.WriteLine("After swapping");
            Console.WriteLine("s1: " + s1);
            Console.WriteLine("s2: " + s2);
        }
        //public static void swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        public static void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }//just boxing unboxing
    }
}
