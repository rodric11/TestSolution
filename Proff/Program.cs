using System;
class Program
{
    public static int[] Add(int[] oldarray, int newitem)
    {
        int[] newarray = new int[oldarray.Length + 1];

        for (int i = 0; i < oldarray.Length; i++)
        {
            newarray[i] = oldarray[i];
        }

        newarray[newarray.Length - 1] = newitem;

        return newarray;
    }

    class MyClass
    {
        int[] vs;

        public int[] VS { get; set; }

        public MyClass(int[] vs)
        {
            VS = vs;
        }

        public int[] ReturnArray()
        {
            Console.WriteLine("Возврат");
            return VS;
        }
    }
    static void Main(string[] args)
    {

        MyClass myClass = new MyClass(new int[10]);

        // берем поле/свойство класса и присваеваем его значение новому массиву.
        int[] newarray = myClass.VS;

        // либо опять же через метод но уже с класса.
        newarray = myClass.ReturnArray();

        Console.WriteLine("Это мой тестовый комит №2");


        Console.ReadLine();
    }
}

