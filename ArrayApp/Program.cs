var arr = Array.CreateInstance(typeof(int), 4);
arr.SetValue(23, 0);
arr.SetValue(13, 1);
arr.SetValue(14, 2);
arr.SetValue(15, 3);

Console.WriteLine(arr.GetValue(3));
try
{
    Console.WriteLine(arr.GetValue(5));
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
foreach (var item in arr)
{
    Console.WriteLine(item);
}
//Console.WriteLine(arr.GetValue(5)); olmayan bi elemanı isteyemeyiz fixed size
var _arr = new Datastructures.Array.Array(1, 2, 3, 4, 5);
foreach (var item in _arr)
{
    Console.WriteLine(item);
}

Console.ReadLine();