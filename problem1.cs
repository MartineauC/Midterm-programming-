public class Professor
{
    public string Lnumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }

    public Professor(string lnumber, string firstName, string lastName, string department)
    {
        Lnumber = lnumber;
        FirstName = firstName;
        LastName = lastName;
        Department = department;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} ({Lnumber}), {Department}";
    }
}