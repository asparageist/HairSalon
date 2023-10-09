using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Models
{
  public class Client
  {
    public string ClientName { get; set; }
    public int ClientID { get; set; }
    public string ClientPhone { get; set; }

  }
}