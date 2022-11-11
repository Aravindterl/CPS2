using System;
using System.Collections.Generic;

namespace CPS2.Models;

public partial class Ecfsetup
{
    public int Id { get; set; }

    public string? Energyconversioname { get; set; }

    public decimal? Value { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Modifieddate { get; set; }

    public string? Modifiedby { get; set; }
}
