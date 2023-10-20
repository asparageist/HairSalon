using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientID { get; set; }
    public string ClientName { get; set; }
    public int StylistID { get; set; }

  }
}