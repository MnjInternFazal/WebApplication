using System;
using System.Collections.Generic;

namespace WebApplicationApi.Models;

public partial class Education
{
    public int EducationId { get; set; }

    public int? PersonalId { get; set; }

    public string? EducationType { get; set; }

    public string? InstituteType { get; set; }

    public string? Yop { get; set; }

    public string? Program { get; set; }

    public string? Elective { get; set; }

    public string? ClgName { get; set; }

    public string? BoardName { get; set; }

    public DateTime? CourseDurationFrom { get; set; }

    public DateTime? CourseDurationTo { get; set; }

    public string? ScoreType { get; set; }

    public int? Cgpavalue { get; set; }

    public int? Cgpascale { get; set; }

    public int? Cgpapercentage { get; set; }

    public int? TotalMarks { get; set; }

    public int? MaxMarks { get; set; }

    public int? MarkPercentage { get; set; }

    public virtual PersonalDetail? Personal { get; set; }
}
