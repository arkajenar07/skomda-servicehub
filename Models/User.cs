using System;
using System.Collections.Generic;

namespace SkomdaServiceHubApi.Models;

public partial class User
{
    public int Userid { get; set; }

    public string Fullname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Passwordhash { get; set; } = null!;

    public string Role { get; set; } = null!;

    public ulong Isactive { get; set; }
}
