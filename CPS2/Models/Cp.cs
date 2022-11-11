using System;
using System.Collections.Generic;

namespace CPS2.Models;

public partial class Cp
{
    public int Id { get; set; }

    public string? Priceseriesname { get; set; }

    public string? Fameticker { get; set; }

    public string? Customticker { get; set; }

    public string? Inputunit { get; set; }

    public string? Inputgranularity { get; set; }

    public string? Holidaycalender { get; set; }

    public decimal? Maxprice { get; set; }

    public decimal? Minprice { get; set; }

    public string? Platt { get; set; }

    public DateTime? Modifieddate { get; set; }

    public string? Modifiedby { get; set; }
}
