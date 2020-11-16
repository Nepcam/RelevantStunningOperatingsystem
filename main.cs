using System;

class MainClass 
{
  //public static void Main (string[] args) {
    //Console.WriteLine ("Hello World");

  public static void Main()
  {
    List<int> numbers = new List<int>{10,4,8,11,24,0,-1};

    Console.WriteLine(Mystery(numbers, 8));
  }

  public static int Mystery(List<int> numbers, int num)
  {
    if (numbers.Count == 1) {
        if (numbers[0] > num) return 1;
          return 0; 
    }
    int first_num = numbers[0];
    numbers.RemoveAt(0);
    
    if(first_num > num) return 1 + Mystery(numbers, num);
        else return Mystery(numbers, num); 
  }
}

