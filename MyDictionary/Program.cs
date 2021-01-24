using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

            myDictionary.Add("iyi", 16);
            myDictionary.Add("kötü", 34);
            myDictionary.Add("çirkin", 48);
            myDictionary.Add("kızgın", 72);



            Console.WriteLine("not :" + myDictionary.Key[0] + "  sayfa no : " + myDictionary.Value[0]);
            Console.WriteLine("not :" + myDictionary.Key[1] + "  sayfa no : " + myDictionary.Value[1]);
            Console.WriteLine("not :" + myDictionary.Key[2] + "  sayfa no : " + myDictionary.Value[2]);
            Console.WriteLine("not :" + myDictionary.Key[3] + "  sayfa no : " + myDictionary.Value[3]);
            Console.ReadLine();
        }
    }
}
