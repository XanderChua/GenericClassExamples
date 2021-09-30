using System;

namespace GenericTest
{
    class Program
    {
        public class ArrayGeneric<T>
        {
            T[] arrObj = new T[5];
            int count = 0;
            public void doSomething(T something)
            {
                if(count < arrObj.Length)
                {
                    arrObj[count] = something;
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
            Console.WriteLine("Hello World!");
            someMethod();
        }

        private static void someMethod()
        {
            ArrayGeneric<int> arrayGenericInt = new ArrayGeneric<int>();
            arrayGenericInt.doSomething(1);
            arrayGenericInt.doSomething(2);
            arrayGenericInt.doSomething(3);
            arrayGenericInt.doSomething(4);
            arrayGenericInt.doSomething(5);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arrayGenericInt[i]);
            }

            ArrayGeneric<float> arrayGenericFloat = new ArrayGeneric<float>();
            arrayGenericFloat.doSomething(1.1f);
            arrayGenericFloat.doSomething(2.1f);
            arrayGenericFloat.doSomething(3.1f);
            arrayGenericFloat.doSomething(4.1f);
            arrayGenericFloat.doSomething(5.1f);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arrayGenericFloat[i]);
            }
        }
    }
}
