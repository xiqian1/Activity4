using System;

namespace MyNamespace
{
    class MyClass
    {
        interface MyInterface
        {
            string StudentName { get; set; }
        }


        class User<T>
        {
            private T[] arr = new T[100];
            public T this[int i]
            {
                get { return arr[i]; }
                set { arr[i] = value; }
            }
        }

        class Program
        {
            static void Main()
            {
                var stringCollection = new User<string>();
                stringCollection[0] = "Xiqian";
                Console.WriteLine(stringCollection[0]);
            }
        }
    }
}