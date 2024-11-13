using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define an enum for Student standing levels
enum Standing
{
    Freshman,
    Sophomore,
    Junior,
    Senior
}

// Define the Student subclass that inherits from Person
class Student : Person
{
    public Standing StudentStanding { get; set; }
    public bool LivesOnCampus { get; set; }

    public Student(string name, DateTime birthDate, string homeState, Standing studentStanding, bool livesOnCampus)
        : base(name, birthDate, homeState)
    {
        StudentStanding = studentStanding;
        LivesOnCampus = livesOnCampus;
    }

    public override string ToString()
    {
        string campusStatus = LivesOnCampus ? "Lives on campus" : "Lives off campus";
        return $"{Name}, Age: {GetAge()}, Standing: {StudentStanding}, {campusStatus}";
    }
}
