using System;
using System.Collections.Generic;

namespace Resume.Models;

public partial class EducationalBackground
{
    public int Id { get; set; }

    public string? School { get; set; }

    public int? Year { get; set; }

    public string? Address { get; set; }

    public string? Course { get; set; }

    public int? StudentId { get; set; }

    public virtual Student? Student { get; set; }
}
