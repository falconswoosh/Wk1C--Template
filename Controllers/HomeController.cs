using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Places.Models;

namespace Places.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpGet("/places")]
    public ActionResult Places()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }
    [HttpGet ("/places/new")]
    public ActionResult PlaceForm()
    {
      return View();
    }
    [HttpPost("/places")]
    public ActionResult AddPlace()
    {
      Place newPlace = new Place(Request.Form["cityName"], Request.Form["cityImage"]);
      List<Place> allPlaces = Place.GetAll();
      return View("Places", allPlaces);
    }
    [HttpGet("/places/{id}")]
    public ActionResult PlaceDetail(int id)
    {
      Place place = Place.Find(id);
      return View(place);
    }
  }
}
