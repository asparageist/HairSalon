using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {
    [HttpGet("/stylist")]
    public ActionResult Index()
    {
      List<Stylist> stylists = ThoseWhoStyle.GetStylists();
      return View(stylists);
    }

    [HttpGet("stylist/{id}")]
    public ActionResult Clients(int id)
    {
      Stylist stylist = ThoseWhoStyle.GetStylistById(id);

      if (stylist == null)
        return NotFound();
      return View("~/Views/Client/Index.cshtml", stylist);
    }

    [HttpPost("/stylist/add")]
    public ActionResult Add(string Name, string Desc, int ID)
    {
      Stylist newStylist = new Stylist
      {
        StylistName = Name,
        StylistDescription = Desc,
        StylistID = ID
      };

      ThoseWhoStyle.AddStylist(newStylist);
      return RedirectToAction("Index");
    }

    [HttpGet("/stylist/new")]
    public ActionResult AddStylist()
    {
      return View("New");
    }


  }
}