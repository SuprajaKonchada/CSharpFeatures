//Required Members
//for class person
//Person person1 = new Person(); //Required fields must be initialize
Person person2 = new Person()
{
    FirstName = "Tommy",
    MiddleName = "Lee",
    LastName = "Jones"
};

Person person3 = new Person
{
    FirstName = "Tommy",
    LastName = "Jones"
};
//for struct employee
Employee employee = new Employee
{
    FirstName = "John",
    MiddleName = "Doe",
    LastName = "Smith"
};
//FOR record customer
Customer customer = new Customer
{
    FirstName = "John",
    MiddleName = "Doe",
    LastName = "Smith"
};

JobSeeker candidate = new JobSeeker();
//Console.WriteLine(candidate.Name);

//UTF-8 string literals C# 11
byte[] U8_StringLiteral = Encoding.UTF8.GetBytes("Hello World");
String byteArrayAsString = string.Join("", U8_StringLiteral);
Console.WriteLine($"StringLiteral: {byteArrayAsString}");

byte[] U8StringLiteral = "Hello World"u8.ToArray();
string byteArrayasString = string.Join("", U8StringLiteral);
Console.WriteLine($"StringLiteral: {byteArrayasString}");

//Auto-Default Struct
Point point = new Point();
Console.WriteLine($"X: {point.X}, Y: {point.Y}");

//newlines in string interpolation
int age = 44;
Console.WriteLine($"The User is {age} years old, which is {age switch
{
    > 80 => "old",
    > 60 => "getting old",
    > 20 => "a good age",
    _ => "young"
}}");

//raw string literals
string rawString;
string level = "Warning";
rawString = $$$""""
            {
                "Logging":{
                    "LogLevel":{
                        "Default":"{{{level}}}",
                        "Microsoft.AspNetCore":"""Warning"""
                    }
                },
                "AllowedHosts":"*"
            }
            """";

//file access modifier
var userProvider = new UserProvider();
Console.WriteLine(userProvider.Name);


//NewLine in Non-verbatim Interpolation 
var item = new
{
    Name = "fooBar",
    Price = 50
};
var str = $"Item Price: {item.Name
    .ToUpper()}";

//Pattern match Span<char> on a constant string
var number = Random.Shared.Next(1, 4);
ReadOnlySpan<char> span = $"string {number}";
if (span is "string 1")
    Console.WriteLine("Yes, it's String 1");
else
    Console.WriteLine("No!...");
switch (span)
{
    case "string 1":
        Console.WriteLine("1");
        break;
    case "string 2":
        Console.WriteLine("2");
        break;
    case "string 3":
        Console.WriteLine("3");
        break;
    case "string 4":
        Console.WriteLine("4");
        break;
}

var type = typeof(User);
var CustomAttributes = type.GetCustomAttributes(false);
foreach (var customAttribute in CustomAttributes)
{
    if(customAttribute is CustomAttribute<string>)
    {
        Console.WriteLine(((CustomAttribute<string>)customAttribute).CurrentType.Name);
    }
}

//Numeric IntPtr
//IntPtr => nint, UIntPtr => nuint
nint pointer = nint.Zero;
nuint uIntPtr = nuint.Zero;
Console.WriteLine(pointer);
Console.WriteLine(uIntPtr);