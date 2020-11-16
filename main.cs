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

public interface ILight
{
    void SwitchOn();
    void SwitchOff();
    bool IsOn();
}

public class OverheadLight : ILight
{
    private bool isOn;
    public bool IsOn() => isOn;
    public void SwitchOff() => isOn = false;
    public void SwitchOn() => isOn = true;

    public override string ToString() => $"The light is {(isOn ? "on" : "off")}";
}

public interface ITimerLight : ILight
{
    Task TurnOnFor(int duration);
}

public interface ITimerLight : ILight
{
    public async Task TurnOnFor(int duration)
    {
        Console.WriteLine("Using the default interface method for the ITimerLight.TurnOnFor.");
        SwitchOn();
        await Task.Delay(duration);
        SwitchOff();
        Console.WriteLine("Completed ITimerLight.TurnOnFor sequence.");
    }
}