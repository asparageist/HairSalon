using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet("/stylist")]
    public ActionResult Index()
    {
      List<Stylist> stylists = _db.Stylist.ToList();
      ViewBag.Stylists = stylists;
      return View(stylists);
    }

    [HttpGet("stylist/{id}")]
    public ActionResult Clients(int id)
    {
      Stylist stylist = _db.Stylist.FirstOrDefault(s => s.StylistID == id);

      if (stylist == null)
        return NotFound();
      return View("~/Views/Client/Index.cshtml", stylist);
    }

    [HttpPost("/stylist/add")]
    public ActionResult Add(string Name, string Desc, int ID)
    {
      Stylist newStylist = new Stylist
      {
        StylistID = ID,
        StylistName = Name,
        StylistDescription = Desc
      };

      _db.Stylist.Add(newStylist);
      _db.SaveChanges();

      return RedirectToAction("Index");
    }

    [HttpGet("/stylist/new")]
    public ActionResult AddStylist()
    {
      return View("New");
    }
  }
}