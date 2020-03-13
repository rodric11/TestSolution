using System;

namespace ClassTask_1
{
    class Program
    {
        class User 
        { 
            public bool HaveSoda { get; set; }
            public string Name { get; set; }

            public User(string name)
            {
                Name = name;
            }
        }


        class SodaAutomat
        {
            public int SodaBottles { get; set; } = 3;

            public void GiveSoda(User user)
            {
                if (SodaBottles == 0)
                {
                    Console.WriteLine("Нет содовой =(");
                    Console.WriteLine($"{user.Name} не получил свою содовую (((");
                }
                else
                {
                    //user.HaveSoda = true;
                    SodaBottles -= 1;
                    Console.WriteLine($"{user.Name} получил свою содовую! )))");
                    
                }
            }
        }

        delegate void SodaDelegate (User user);

        public delegate int MyDelegate(int a, int b, int c);

        public delegate double FirstDelegate(int a);


        static void Main(string[] args)
        {
            // Task_1

            User sasha = new User("Саша");
            User masha = new User("Маша");
            User petya = new User("Петя");
            User vasya = new User("Вася");

            SodaAutomat sodaAutomat = new SodaAutomat();

            SodaDelegate sodadelegate = new SodaDelegate(sodaAutomat.GiveSoda);
            Console.WriteLine();
            sodadelegate.Invoke(sasha);
            sodadelegate.Invoke(masha);
            sodadelegate.Invoke(petya);
            sodadelegate.Invoke(vasya);

            // Task_2
            //MyDelegate @delegate = delegate (int a, int b, int c) { return 2 * (a * b + b * c + a * c); };

            //int s = @delegate.Invoke(3, 5, 7);

            //Console.WriteLine($"Площадь - {s}");

            //// Task_3

            //FirstDelegate sqrt = x => x * x;
            //FirstDelegate triple = x => x * x * x;
            //FirstDelegate square = x => Math.PI * (x * x);

            //double f1 = sqrt.Invoke(5);
            //double f2 = triple.Invoke(3);
            //double f3 = square.Invoke(4);

            //Console.WriteLine($"первое - {f1}, второе - {f2}, третье - {f3}");
            Console.ReadKey();

        }
    }
}
