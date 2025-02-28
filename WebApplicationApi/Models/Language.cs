using System;
using System.Collections.Generic;

namespace WebApplicationApi.Models;

public partial class Language
{
    public int LanguageId { get; set; }

    public int? PersonalId { get; set; }

    public string? LanguageName { get; set; }

    public bool? Speak { get; set; }

    public bool? Read { get; set; }

    public bool? Write { get; set; }

    public virtual PersonalDetail? Personal { get; set; }
}
