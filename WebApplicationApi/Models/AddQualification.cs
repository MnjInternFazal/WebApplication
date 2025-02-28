using System;
using System.Collections.Generic;

namespace WebApplicationApi.Models;

public partial class AddQualification
{
    public int ProgramId { get; set; }

    public int? PersonalId { get; set; }

    public string? Program { get; set; }

    public string? Institute { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public decimal? Percentage { get; set; }

    public string? Division { get; set; }

    public virtual PersonalDetail? Personal { get; set; }
}
