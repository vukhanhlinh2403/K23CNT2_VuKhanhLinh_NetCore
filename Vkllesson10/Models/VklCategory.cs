using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vkllesson10.Models;

public partial class VklCategory
{
    [Key]
    public int CateId { get; set; }

    public string? CateName { get; set; }

    public bool? CateStatus { get; set; }
}
