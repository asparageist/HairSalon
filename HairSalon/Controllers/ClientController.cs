using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;


namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {

    private readonly HairSalonContext _db;

    public ClientController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet("/Client/{id}")]
    public ActionResult Client(int stylistId)
    {
      Stylist stylist = _db.Stylist.FirstOrDefault(s => s.StylistID == stylistId);
      if (stylist == null)
        return NotFound();

      return View("Client/Index", stylist);
    }

    [HttpGet("Stylist/{stylistId}/AddClient")]
    public ActionResult ShowAddClientForm(int stylistId)
    {
      Stylist stylist = _db.Stylist.FirstOrDefault(s => s.StylistID == stylistId);
      if (stylist == null)
        return NotFound();

      return View("~/Views/Client/New.cshtml", stylist);
    }

    [HttpPost("Stylist/{stylistId}/NewClient")]
    public ActionResult AddClientFromStylist(int stylistId, string clientName)
    {
      Client newClient = new Client
      {
        ClientName = clientName,
        StylistID = stylistId
      };
      _db.Client.Add(newClient);
      _db.SaveChanges();

      return RedirectToAction("Clients", "Stylist", new { id = stylistId });
    }

    [HttpPost("Stylist/NewClient")]
    public ActionResult AddClientFromMenu(string clientName, int stylistId)
    {
      Client newClient = new Client
      {
        ClientName = clientName,
        StylistID = stylistId
      };
      _db.Client.Add(newClient);
      _db.SaveChanges();

      return RedirectToAction("Menu", "Home");
    }


    [HttpGet("/clients/new")]
    public ActionResult NewClient()
    {
      List<Stylist> stylists = _db.Stylist.ToList();
      ViewBag.Stylists = stylists;
      return View("~/Views/Client/New.cshtml");
    }

  }
}