using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using static System.Console; // C# 6.0 버전 이후부터 사용가능

namespace HelloWorld
{
    internal class Program
    {
        static string abc;

        delegate void KiaOra();

        //static async Task Main(string[] args)
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5 };

        //    int num = numbers.Sum();

        //    WriteLine($"{nameof(numbers)}: {numbers.Count()}");

        //    WriteLine(string.Equals(abc, string.Empty));

        //    ABC aBC = new ABC();
        //    aBC.foo();


        //    //GC.Collect();

        //    KiaOra b = ABCD;
        //    b();

        //    b += DCBA;

        //    b();

        //    b.Invoke();
        //    //kokodas(CoCodas);

        //    Func<int, int, int> a = (x, y) =>
        //    {
        //        Console.WriteLine(x + y);
        //        return x + y;
        //    };

        //    a += (x, y) =>
        //    {
        //        Console.WriteLine(x - y);
        //        return x - y;
        //    };


        //    a.Invoke(5, 3);

        //    Child ora = new Child();
        //    ora.y = 3;

        //    Pet pet = new Pet();

        //    Sum(1, 2, 3);

        //    dynamic x = 1234;
        //    WriteLine(x);

        //    dynamic y;

        //    y = ReadLine();
        //    WriteLine(y);

        //    await DoAsync();
        //}

        static async Task DoAsync()
        {
            using (var client = new HttpClient())
            {
                var r = await client.GetAsync("https://dotnetnote.azurewebsites.net/api/WebApiDemo");

                var c = await r.Content.ReadAsStringAsync();

                Console.WriteLine(c);
            }
        }

        static void ABCD()
        {
            WriteLine("ABCD");
        }

        static void DCBA()
        {
            WriteLine("DCBA");
        }

        static void CoCodas()
        {
            WriteLine("CoCodas");
        }

        static void kokodas()
        {

        }

        /// <summary>
        /// 두 수를 더하여 그 결괏값을 반환시켜 주는 함수
        /// </summary>
        ///<param name="a">첫 번째 매개변수</param>
        ///<param name="b">두 번째 매개변수</param>
        ///<returns>a + b 결과</returns>
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        /// 
        [Obsolete("Very Good Job")]
        static void Sum(int a, int b, int c)
        {
            WriteLine($"a: {a}");
            WriteLine($"b: {b}");
            WriteLine($"c: {c}");

            void foo()
            {
                WriteLine("KiaOra");
            }

            foo();
        }

        
        
    }

    public class Parent 
    {
        protected int x;
        public int y;

        public Parent(string msg)
        {
            WriteLine($"부모 생성자: {msg}");
        }
    }

    public class Child : Parent
    {
        public Child() : this("자식에서 넘겨요") { }
        public Child(string msg) : base(msg) { }
    }

    public interface ICat
    {
        public void Eat();
    }

    public interface IDog
    {
        public void Eat();
    }

    public class Pet : ICat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Animal
    {
        public abstract void Eat();
        public void Bark()
        {
            WriteLine("Helo");
        }
    }


    public class ABC : IEnumerable<int>
    {

        static ABC()
        {
            WriteLine("정적인 생성자");

        }

        public ABC()
        {
            WriteLine("생성자");
        }

        public ABC(int a) : this()
        {
            WriteLine("int 생성자");
        }

        public void foo()
        {
            WriteLine("메서드");
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; ++i)
            {
                yield return i;
            }
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        ~ABC()
        {
            WriteLine("소멸자");
        }
    }
}