using ValueAndReferenceTypes;

var p1 = new ReferenceType
{
    X = 1,
    Y = 2
};
var p2 = p1;
p2.X = 3;
Console.WriteLine($"p1: {p1.X} - {p1.Y}");
Console.WriteLine($"p2: {p2.X} - {p2.Y}");

var p3 = new ValueAndReferenceTypes.ValueType
{
    X = 1,
    Y = 2
};
var p4 = p1;
p4.X = 3;
Console.WriteLine($"p3: {p3.X} - {p3.Y}");
Console.WriteLine($"p4: {p4.X} - {p4.Y}");
Console.ReadLine();