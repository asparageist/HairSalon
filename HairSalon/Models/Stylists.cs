using System.Collections.Generic;
using System;
using HairSalon.Controllers;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistID { get; set; }
    public string StylistName { get; set; }
    public string StylistDescription { get; set; }
    public List<Client> StylistClient { get; set; } = new List<Client>();
  }
}