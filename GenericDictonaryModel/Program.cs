using System;

namespace GenericDictonaryModel
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> myDict = new MyDictonary<int, string>();
            myDict.Add(1, "Yazılım");
            myDict.Add(2, "Kodlama");

            myDict.printAll();
            Console.WriteLine("******Printed******");
            myDict.Add(4, "Eğitimi");
            myDict.Add(5, "Teşekkürler <3");
            myDict.printAll();




        }
    }
}
