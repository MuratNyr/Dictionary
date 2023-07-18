using Dictionary1;

MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

myDictionary.Add(3, "C");
myDictionary.Add(1, "A");
myDictionary.Add(2, "B");

for (int i = 0; i < myDictionary.Count; i++)
{
    Console.WriteLine(myDictionary.keys[i] + ": " + myDictionary.values[i]);
}