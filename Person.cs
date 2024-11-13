using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public string HomeState { get; set; }

    public Person(string name, DateTime birthDate, string homeState)
    {
        Name = name;
        BirthDate = birthDate;
        HomeState = homeState;
    }

    // Method to calculate age in years based on BirthDate
    public int GetAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - BirthDate.Year;

        // Adjust if the birthday hasn't occurred yet this year
        if (BirthDate > today.AddYears(-age))
        {
            age--;
        }

        return age;
    }

    public override string ToString()
    {
        return $"{Name}, Age: {GetAge()}";
    }
}
