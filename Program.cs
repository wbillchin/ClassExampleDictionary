using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        // List of Person objects with birthdates
        List<Person> people = new List<Person>
        {
            new Student("Alice", new DateTime(2002, 5, 15), "Virginia", Standing.Freshman, true),
            new Student("Bob", new DateTime(2000, 11, 22), "California", Standing.Senior, true),
            new Person("Charlie", new DateTime(2001, 3, 10), "Maryland"),
            new Student("Steve", new DateTime(2002, 5, 10), "Maryland", Standing.Sophomore, true),
            new Person("David", new DateTime(1999, 7, 18), "Virginia"),
            new Person("Eve", new DateTime(2000, 1, 25), "New York")
        };


        Dictionary<int, int> countOfPeopleByAge = new Dictionary<int, int>();

        // Populate the dictionary based on each person's HomeState
        foreach (var person in people)
        {
            int age = person.GetAge();

            if( !countOfPeopleByAge.ContainsKey(age)) {
                countOfPeopleByAge.Add(age, 1);
            } else
            {
                countOfPeopleByAge[age]++;
            }
        }

        Console.WriteLine("Count of people that are 22: " + countOfPeopleByAge[22]);


        // Dictionary to organize people by their HomeState
        Dictionary<string, List<Person>> peopleByState = new Dictionary<string, List<Person>>();

        // Populate the dictionary based on each person's HomeState
        foreach (var person in people)
        {
            if (!peopleByState.ContainsKey(person.HomeState))
            {
                peopleByState[person.HomeState] = new List<Person>();
            }
            peopleByState[person.HomeState].Add(person);
        }

        // Display people in each state
        foreach (var state in peopleByState)
        {
            Console.WriteLine("State: " + state.Key);
            foreach (var person in state.Value)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
        }
    }
}
