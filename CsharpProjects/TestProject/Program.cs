string permission = "User";
int level = 19;

if (permission.Contains("Manager"))
{
    Console.WriteLine(level >= 20 ? "Contact an Admin for access" : "You do not have sufficient privileges.");
}
else if (permission.Contains("Admin"))
{
    Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user");
}
else
    Console.WriteLine("You do not have sufficient privileges.");

