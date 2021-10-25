Console.Write("Enter user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "mary")
{
    Console.WriteLine("Yay, it's MARY!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}