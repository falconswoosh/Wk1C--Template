using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    private string _cityName;
    private string _cityImageURL;
    private int _id;
    private static List<Place> _placesList = new List<Place> {};

    public Place (string cityName, string cityImageURL)
    {
      _cityName = cityName;
      _cityImageURL = cityImageURL;
      _placesList.Add(this);
      _id = _placesList.Count;
    }
    public string GetCityName()
    {
      return _cityName;
    }
    public string GetCityImageURL()
    {
      return _cityImageURL;
    }
    public void SetCityName(string newCityName)
    {
      _cityName = newCityName;
    }
    public void SetCityImageURL(string newCityImageURL)
    {
      _cityImageURL = newCityImageURL;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Place> GetAll()
    {
      return _placesList;
    }
    public static void ClearAll()
    {
      _placesList.Clear();
    }
    public static Place Find(int searchId)
    {
      return _placesList[searchId-1];
    }
  }
}
