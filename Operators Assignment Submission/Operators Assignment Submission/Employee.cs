using System;

// Define the Employee class
public class Employee
{
    // Properties for Id, FirstName, and LastName
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the == operator to compare two Employee objects by Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        if (ReferenceEquals(emp1, emp2)) return true;
        if (emp1 is null || emp2 is null) return false;
        return emp1.Id == emp2.Id;
    }

    // Overload the != operator to provide opposite functionality of the == operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    public override bool Equals(object obj)
    {
        if (obj is Employee employee)
        {
            return Id == employee.Id;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
