using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Cooking
    {
        // 동기 방식의 밥 만들기 메서드
        public Rice MakeRice()
        {
            Console.WriteLine("밥 생성 중...");
            Thread.Sleep(1001);
            return new Rice();
        }

        // 비동기 방식의 밥 만들기 메서드
        public async Task<Rice> MakeRiceAsync()
        {
            Console.WriteLine("밥 생성 중...");
            await Task.Delay(1001);
            return new Rice();
        }

        // 동기 방식의 국 만들기 메서드
        public Soup MakeSoup()
        {
            Console.WriteLine("국 생성 중...");
            Thread.Sleep(1001);
            return new Soup();
        }

        // 비동기 방식의 국 만들기 메서드
        public async Task<Soup> MakeSoupAsync()
        {
            Console.WriteLine("국 생성 중...");
            await Task.Delay(1001);
            return new Soup();
        }

        // 동기 방식의 달걀 만들기 메서드
        public Egg MakeEgg()
        {
            Console.WriteLine("달걀 생성 중...");
            Thread.Sleep(1001);
            return new Egg();
        }

        // 비동기 방식의 달걀 만들기 메서드
        public async Task<Egg> MakeEggAsync()
        {
            Console.WriteLine("달걀 생성 중...");
            await Task.Delay(TimeSpan.FromMilliseconds(1001));
            return await Task.FromResult<Egg>(new Egg());
        }
    }

    public class Rice
    {
        // Pass
    }

    public class Soup
    {
        // Pass
    }

    public class Egg
    {
        // Pass
    }
}
