﻿using System;
using System.Collections.Generic;

namespace gyak11.Models;

public partial class Room
{
    public int RoomSk { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Lesson> Lessons { get; } = new List<Lesson>();
}
