using System.Collections.Generic;
using System.Collections;

namespace Tamagotchi.Models
{
  public class Tama
  {
    private string _name;
    private int _food = 1;
    private int _id;
    private static List<Tama> _instances = new List<Tama> {};

    public Tama (string name)
    {
      _name = name;
      _food = 1;
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
    public int GetFood()
    {
      return _food;
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
  }
}
