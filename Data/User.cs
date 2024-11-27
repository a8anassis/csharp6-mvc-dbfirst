﻿using System;
using System.Collections.Generic;

namespace SchoolApp.Data;

public partial class User
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Firstname { get; set; } = null!;
    public string Lastname { get; set; } = null!;
    public string UserRole { get; set; } = null!;   // ToDo create enum

    public virtual Student? Student { get; set; }
    public virtual Teacher? Teacher { get; set; }
}