using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();

            dictionary.Add(1,"Engin");
            dictionary.Add(2, "Burak");
            dictionary.showElements();
            

        }
    }
}
