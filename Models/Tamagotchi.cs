using System.Collections.Generic;
using System.Collections;

namespace Tamagotchi.Models
{
  public class Tama
  {
    private string _name;
    private int _hunger;
    private int _attention;
    private int _sleep;
    private int _id;

    private static List<Tama> _instances = new List<Tama> {};

    public Tama (string name)
    {
      _name = name;
      _sleep = 10;
      _hunger = 15;
      _attention = 16;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string input)
    {
      _name = input;
    }
    public int GetHunger()
    {
      return _hunger;
    }
    public void SetHunger(int amount)
    {
      _hunger = amount;
    }
    public void Feed()
    {
      _sleep -= 5;
      _attention -= 5;
      _hunger += 10;
      if (_hunger > 100)
      {
        _hunger = 100;
      }
    }
    public void SetAttention(int amount)
    {
      _attention = amount;
    }
    public int GetAttention()
    {
      return _attention;
    }
    public void Play()
    {
      _sleep -= 5;
      _hunger -= 5;
      _attention += 10;
      if (_attention > 100)
      {
        _attention = 100;
      }
    }
    public void SetSleep(int amount)
    {
      _sleep = amount;
    }
    public int GetSleep()
    {
      return _sleep;
    }

    public void Rest()
    {
      _hunger -= 2;
      _attention -= 2;
      _sleep += 10;
      if(_sleep > 100)
      {
        _sleep = 100;

      }
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Tama> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Tama Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static void Time()
    {
      foreach(Tama x in _instances)
      {
        x._hunger -= 20;
        x._attention -= 20;
        x._sleep -= 20;
      }
    }
  }
}
