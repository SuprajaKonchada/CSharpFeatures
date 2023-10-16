namespace CSharp_10;
public class Person
{
    public string FullName { get; set; }
    public int Age { get; set; }
    public Person(string fullName, int age)
    {
        FullName = fullName;
        Age = age;
    }
    public void Deconstruct(out string fullname, out int age)
    {
        fullname = FullName;
        age = Age;
    }
}
