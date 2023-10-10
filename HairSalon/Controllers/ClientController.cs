using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {

    // [HttpGet("Stylist/{stylistId}/AddClient")]
    // public ActionResult Client(int stylistId)
    // {
    // Stylist stylist = ThoseWhoVend.GetVendorById(vendorId);
    // if (vendor == null)
    //   return NotFound();

    // return View("~/Views/New/Orders.cshtml", vendor);
    // }

    // [HttpPost("Vendor/{vendorId}/AddOrder")]
    // public ActionResult AddOrder(int vendorId, string itemName)
    // {
    //   Order newOrder = new Order
    //   {
    //     ItemName = itemName
    //   };
    //   ThoseWhoVend.AddOrder(vendorId, newOrder);
    //   return RedirectToAction("Orders", "Vendors", new { id = vendorId });
    // }

  }
}