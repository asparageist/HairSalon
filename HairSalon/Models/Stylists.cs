using System.Collections.Generic;
using System;
using HairSalon.Controllers;

namespace HairSalon.Models
{
  public class Stylist
  {
    public string StylistName { get; set; }
    public string StylistDescription { get; set; }
    public int StylistID { get; set; }
    public List<Client> StylistClient { get; set; } = new List<Client>();

  }

  // public class ThoseWhoVend
  // {
  //   private static List<Vendor> _instances = new List<Vendor> { };
  //   private static int _vendorID = 0;
  //   public static void AddVendor(Vendor vendor)
  //   {
  //     _instances.Add(vendor);
  //     vendor.ID = _vendorID++;
  //   }


  //   public static List<Vendor> GetVendors()
  //   {
  //     return _instances;
  //   }

  //   public static Vendor GetVendorById(int id)
  //   {
  //     return _instances.Find(v => v.ID == id);
  //   }

  //   public static void AddOrder(int vendorID, Order order)
  //   {
  //     Vendor vendor = _instances.Find(v => v.ID == vendorID);
  //     if (vendor != null)
  //     {
  //       vendor.VendorOrder.Add(order);
  //     }
  //   }
  // 
  // }
}