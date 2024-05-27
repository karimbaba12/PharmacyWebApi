using System;
using System.Collections.Generic;

namespace UMS_DAL.Models;

public partial class User
{
    public int UserId { get; set; }

    public int RoleId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
