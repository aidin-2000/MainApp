using Models;
using Utilities;

Person person = new Person("Aidin","Askerbekov");
string fullName =PersonUtilities.GetFullName(person);
Console.WriteLine($"Fullname: {fullName}");

