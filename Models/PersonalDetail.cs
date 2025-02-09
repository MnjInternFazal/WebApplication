using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class PersonalDetail
{
    public int PersonalId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FatherName { get; set; }

    public string? Nationality { get; set; }

    public string? SocialSecurityNo { get; set; }

    public string? Sex { get; set; }

    public string? MartialStatus { get; set; }

    public string? PanCardNumber { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? PlaceOfBirth { get; set; }

    public virtual ICollection<AddQualification> AddQualifications { get; set; } = new List<AddQualification>();

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual ICollection<Family> Families { get; set; } = new List<Family>();

    public virtual ICollection<Language> Languages { get; set; } = new List<Language>();

    public virtual ICollection<Passport> Passports { get; set; } = new List<Passport>();

    public virtual ICollection<Education> Qualifications { get; set; } = new List<Education>();
}
