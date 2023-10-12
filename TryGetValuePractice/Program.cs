


Dictionary<string, string> fruits = new Dictionary<string, string>()
{
    {"apple", "red" },
    {"banana", "yellow" },
    {"orange", "orange" },
    {"grape", "purple" },
    {"kiwi", "brown" },
    {"pear", "green" },
    {"strawberry", "red" },
    {"watermelon", "green" },
    {"pineapple", "yellow" },
    {"mango", "orange" },
};

//create string to be used for TryGetValue out
string color = "";

//search Dictionary for key "banana" and out the value onto the color string
fruits.TryGetValue("banana", out color);

Console.WriteLine(color);

//create string inside of TryGetValue statement
fruits.TryGetValue("watermelon", out string watermeloncolor);
Console.WriteLine(watermeloncolor);

//search dictionary and if key "strawberry" is found, write "Found Value: " + color"
if (fruits.TryGetValue("strawberry", out color))
{
    Console.WriteLine("Found Value: " + color);
}
else
{
    Console.WriteLine("Value not found");
};
   