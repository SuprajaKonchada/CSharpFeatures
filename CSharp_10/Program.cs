//Parameter less struct constructor
Point point = new Point();
Console.WriteLine($"X: {point.X}, Y: {point.Y}");

//Constant interpolated strings
const string languageReleasePrefix = "C# 10";
const string languageRelease = $"{languageReleasePrefix} " + $"to be released in November 2021.";

Console.WriteLine(languageRelease);

//Assignment and declaration in the same deconstruction
var person = new Person("John Lee", 31);
int age = 34;
(string fullname, age) = person;
Console.WriteLine(fullname);
Console.WriteLine(age);


