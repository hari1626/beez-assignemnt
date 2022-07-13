string input;
Console.WriteLine("These are the grades ");
Console.WriteLine("Excellent");
Console.WriteLine("VeryGood");
Console.WriteLine("Good");
Console.WriteLine("Average");
Console.WriteLine("Fail");
Console.WriteLine("INPUT THE FIRSTLETTER OF THE GRADE=");

input = Console.ReadLine();
if(input == "E" || input=="e")
{   
    Console.WriteLine("Excellent");
}
else if (input == "V" || input=="v")
{
    Console.WriteLine("VeryGood");
}
else if(input == "G" || input=="g")
{
    Console.WriteLine("Good");
}
else if(input == "A" || input=="a")
{
    Console.WriteLine("Average");
}
else if(input=="F" || input=="f")
{
    Console.WriteLine("Fail");
}
else
{
    Console.WriteLine("invalid input");
}
Console.ReadLine();