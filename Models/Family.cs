using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Family
{
    public int FamilyId { get; set; }

    public int? PersonalId { get; set; }

    public string? Name { get; set; }

    public string? Relationship { get; set; }

    public DateOnly? Dob { get; set; }

    public int? Age { get; set; }

    public virtual PersonalDetail? Personal { get; set; }
}
