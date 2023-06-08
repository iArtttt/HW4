namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MyList myList = new MyList();

            myList.Add(1);
            myList.Add("sds");
            myList.Add("aa");
            myList.Add('s');
            myList.Add(55.156m);
            
            int c = myList.Count;

            int indexOf = myList.IndexOf('s');
            int indexOf1 = myList.IndexOf(1);
            //myList.RemoveAt(indexOf);

            myList.Add(7789.66f);
            myList.Add("qdw");
            myList.Add("bmkkkf");
            myList.Add(23);

            bool b = myList.Contains(1);
            myList.Add(83);
            myList.Add(546);    
            int s = myList.Count;
        }
    }
}