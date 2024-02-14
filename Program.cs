string [] givenArray1 = new string[4] {"Hello", "2", "world", ":-)"};
string [] givenArray2 = new string[4] {"1234", "1567", "-2", "computer science"};
string [] givenArray3 = new string[3] {"Russia", "Denmark", "Kazan"};

string [] ArrayFilter(string [] strings)
{
  int count = 0;  
  for (int i = 0; i<strings.Length; i++)
  {
    if(strings[i].Length <=3)
    count++;
  }
  string [] result = new string [count];
  int j = 0;
  for (int i = 0; i<strings.Length; i++)
  {
    if(strings[i].Length <=3)
    {
        result[j] = strings[i];
        j++;
    }
  }
  return result;
}

void PrintArray(string [] strings)
{
    Console.Write("[");
    for (int i = 0; i < strings.Length; i++)
    {
    if(i < strings.Length - 1) Console.Write($"“{strings[i]}”, ");
    else Console.Write($"“{strings[i]}”");
    }
     Console.Write("]");   
}

void RunFilter(string [] strings)
{
    PrintArray(strings);
    Console.Write(" → ");
    PrintArray(ArrayFilter(strings));
    Console.WriteLine();
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Test Array 1:");
RunFilter(givenArray1);

Console.WriteLine("Test Array 2:");
RunFilter(givenArray2);

Console.WriteLine("Test Array 3:");
RunFilter(givenArray3);