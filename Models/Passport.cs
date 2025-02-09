using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Passport
{
    public int PassportId { get; set; }

    public int? PersonalId { get; set; }

    public string? Status { get; set; }

    public string? Number { get; set; }

    public string? DateOfIssue { get; set; }

    public string? DateOfExpiry { get; set; }

    public bool? HasValidVisa { get; set; }

    public bool? IsOpenToTravel { get; set; }

    public virtual PersonalDetail? Personal { get; set; }
}
