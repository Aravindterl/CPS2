using System;
using System.Collections.Generic;

namespace CPS2.Models;

public partial class Holidaycalendersetup
{
    public int Id { get; set; }

    public string? Holidayname { get; set; }

    public string? Excludewee { get; set; }

    public DateTime? Dates { get; set; }

    public DateTime? Modifieddate { get; set; }

    public string? Modifiedby { get; set; }
}
