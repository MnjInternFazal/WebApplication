using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public int? PersonalId { get; set; }

    public string? AddressType { get; set; }

    public string? HouseNo { get; set; }

    public string? Locality { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PinCode { get; set; }

    public string? Period { get; set; }

    public string? Telephone { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? InstantMessagingId { get; set; }

    public virtual PersonalDetail? Personal { get; set; }
}
