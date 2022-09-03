// See https://aka.ms/new-console-template for more information
using Onellect_test;
using Onellect_test.Interface;
Random rnd = new Random();
IGenerate arrayGenerator = new ArrayGenerator();
var classToSort = new RandomSort();
ISorting sort = classToSort.Random();
int[] result = arrayGenerator.Generate(-100, 100);
Console.WriteLine($"array: {string.Join(", ", result)}");
int[] sortedArray = sort.Sort(result);
Console.WriteLine($"SortedArray: {string.Join(", ", sortedArray)}");
DataObject obj = new DataObject();
obj.Numbers = sortedArray;
HttpSend send = new HttpSend(obj);
send.Main();