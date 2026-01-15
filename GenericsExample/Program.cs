// See https://aka.ms/new-console-template for more information
using GenericsExample;
using GenericsExample.Models;

Console.WriteLine("Hello, World!");

JsonLoader<Person> loader = new JsonLoader<Person>();
Person? person = loader.LoadData();
if (person is not null)
{
    Console.WriteLine($"Person Loaded: {person.Name}, Age: {person.Age}");
}

JsonLoader<PersonProfile> profileLoader = new JsonLoader<PersonProfile>();
PersonProfile? profile = profileLoader.LoadData();
if (profile is not null)
{
    Console.WriteLine($"Profile Loaded: {profile.Name}, Email: {profile.Email}");
}
