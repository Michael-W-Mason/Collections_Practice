int[] myInts = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
string[] names = { "Tim", "Martin", "Nikki", "Sara" };
bool[] myBools = new Boolean[10];
for (int i = 0; i < myBools.Length; i++)
{
    if (i % 2 != 1)
    {
        myBools[i] = true;
    }
}

List<string> flavors = new List<string>();
flavors.Add("Vanilla");
flavors.Add("Chocolate");
flavors.Add("Mint");
flavors.Add("Cookies n' Cream");
flavors.Add("Rocky Road");
Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);
flavors.RemoveAt(2);
Console.WriteLine(flavors.Count);


Dictionary<string, string> users = new Dictionary<string, string>();
Random rand = new Random();
users.Add("Name", names[rand.Next(0, names.Length)]);
users.Add("Flavor", flavors[rand.Next(0, flavors.Count)]);

foreach (var entry in users)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}