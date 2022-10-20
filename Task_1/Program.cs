Console.WriteLine("Input your 5-digit number");
string n = Console.ReadLine();
int length = n.Length;
if (length != 5)
{
    Console.WriteLine("Wrong number!");
}

if (n[0] == n[4] && n[1] == n[3])
{
    Console.WriteLine("Your number is a palindrome!");
}
else
{
    Console.WriteLine("Your number is not a palindrome!");
}