using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {

    [HttpGet("/Client/{id}")]
    public ActionResult Client(int stylistId)
    {
      Stylist stylist = ThoseWhoStyle.GetStylistById(stylistId);
      if (stylist == null)
        return NotFound();

      return View("Client/Index", stylist);
    }

    [HttpGet("Stylist/{stylistId}/AddClient")]
    public ActionResult ShowAddClientForm(int stylistId)
    {
      Stylist stylist = ThoseWhoStyle.GetStylistById(stylistId);
      if (stylist == null)
        return NotFound();

      return View("~/Views/Client/New.cshtml", stylist);
    }

    [HttpPost("Stylist/{stylistId}/NewClient")]
    public ActionResult AddClient(int stylistId, string clientName)
    {
      Client newClient = new Client
      {
        ClientName = clientName
      };
      ThoseWhoStyle.AddClient(stylistId, newClient);
      return RedirectToAction("Clients", "Stylist", new { id = stylistId });
    }

    [HttpPost("Stylist/NewClient")]
    public ActionResult AddClient(string clientName, int stylistId)
    {
      Client newClient = new Client
      {
        ClientName = clientName
      };
      ThoseWhoStyle.AddClient(stylistId, newClient);
      return RedirectToAction("Menu", "Home");
    }


    [HttpGet("/clients/new")]
    public ActionResult NewClient()
    {
      List<Stylist> stylists = ThoseWhoStyle.GetStylists();
      ViewBag.Stylists = stylists;
      return View("~/Views/Client/New.cshtml");
    }

  }
}