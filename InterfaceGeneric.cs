using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExample
{
    public interface IMyGenericInterface<T>
    {
        void doSomething(T a, T b);
        T doSomethingElse(T a, T b);      
    }
    //First way to create a class of generic interface
    public class MyGenericClass : IMyGenericInterface<int>
    {
        public void doSomething(int a, int b)
        {
            throw new NotImplementedException(); 
        }
        public int doSomethingElse(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
    //Second way to create a class of generic interface
    public class MyGenericClass1<T> : IMyGenericInterface<T>
    {
        public void doSomething(T a, T b)
        {
            throw new NotImplementedException();
        }
        public T doSomethingElse(T a, T b)
        {
            throw new NotImplementedException();
        }
    }
    class Class1
    {
        public void createGenericTypes()
        {
            MyGenericClass myGenericClass = new MyGenericClass();
            myGenericClass.doSomething(1, 1);

            MyGenericClass1<int> intMyGenericClass1 = new MyGenericClass1<int>();
            intMyGenericClass1.doSomething(1, 1);

            MyGenericClass1<float> floatMyGenericClass1 = new MyGenericClass1<float>();
            floatMyGenericClass1.doSomething(1.3f, 3.4f);
        }
    }
}
