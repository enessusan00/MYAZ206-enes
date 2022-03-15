﻿using ValueAndReferenceTypes;

var p1 = new ReferenceType
{
    X = 1,
    Y = 2
};
var p2 = p1;
p2.X = 3;
Console.WriteLine($"p1: {p1.X} - {p1.Y}");
Console.WriteLine($"p2: {p2.X} - {p2.Y}");
Console.ReadLine();