using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {

    [HttpGet("Stylist/{stylistId}/AddClient")]
    public ActionResult Client(int stylistId)
    {
      Stylist stylist = ThoseWhoStyle.GetStylistById(stylistId);
      if (stylist == null)
        return NotFound();

      return View("~/Views/New/Clients.cshtml", stylist);
    }

    [HttpPost("Stylist/{stylistId}/AddClient")]
    public ActionResult AddClient(int stylistId, string clientName)
    {
      Client newClient = new Client
      {
        ClientName = clientName
      };
      ThoseWhoStyle.AddClient(stylistId, newClient);
      return RedirectToAction("Clients", "Stylists", new { id = stylistId });
    }

  }
}