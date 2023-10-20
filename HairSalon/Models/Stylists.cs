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

  public class ThoseWhoStyle
  {
    private static List<Stylist> _instances = new List<Stylist> { };
    private static int _stylistID = 0;
    public static void AddStylist(Stylist stylist)
    {
      _stylistID++;
      stylist.StylistID = _stylistID;
      _instances.Add(stylist);
    }


    public static List<Stylist> GetStylists()
    {
      return _instances;
    }

    public static Stylist GetStylistById(int id)
    {
      return _instances.Find(v => v.StylistID == id);
    }

    public static void AddClient(int stylistID, Client client)
    {
      Stylist stylist = _instances.Find(v => v.StylistID == stylistID);
      if (stylist != null)
      {
        stylist.StylistClient.Add(client);
      }
    }

  }
}