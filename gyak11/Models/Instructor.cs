using System;
using System.Collections.Generic;

namespace gyak11.Models;

public partial class Instructor
{
    public int InstructorSk { get; set; }

    public string? Salutation { get; set; }

    public string Name { get; set; } = null!;

    public byte? StatusFk { get; set; }

    public string? EmployementFk { get; set; }

    public virtual Employement? EmployementFkNavigation { get; set; }

    public virtual ICollection<Lesson> Lessons { get; } = new List<Lesson>();

    public virtual Status? StatusFkNavigation { get; set; }
}
