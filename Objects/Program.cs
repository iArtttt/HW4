namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();
            //list.Insert(2,"njnj");

            MyList myList = new MyList(-5);

            myList.Add(1);
            ////int indexOf1 = myList.IndexOf(1);
            myList.Add("sds");
            myList.Add("aa");
            myList.Insert(2, 0b1010);
            myList.Add('s');
            myList.Add(55.156m);

            int c = myList.Count;

            int indexOf = myList.IndexOf('s');
            myList.RemoveAt(0);

            myList.Add(7789.66f);
            myList.Add("qdw");
            myList.Add("bmkkkf");
            myList.Add(23);

            bool b = myList.Contains(1);
            myList.Add(83);
            myList.Insert(4, "xq2");
            myList.Add(546);
            int s = myList.Count;
            myList.Reverse();
            uint cap = myList.Capasity;

            var lol = myList.ToArray();
            myList.Clear();
            myList.Add(4.48m);
        }
    }
}