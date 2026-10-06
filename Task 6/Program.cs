List<string> fruits = new() {"Watermelon", "Banana", "Pineapple"};
fruits.Add("Apple");
fruits.Remove("Pineapple");

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Dictionary<int, string> fal = new Dictionary<int, string>
{
    { 1, "Watermelon" },
    { 2, "Banana" },
    { 3, "Pineapple" },
};

fal.Add(4, "Apple");

foreach (KeyValuePair<int, string> item in fal)
{
    Console.WriteLine($"ID : {item.Key}, Fruit : {item.Value}");
}