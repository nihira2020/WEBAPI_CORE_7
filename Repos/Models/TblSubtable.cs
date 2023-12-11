using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LearnAPI.Repos.Models;

[Table("tbl_subtable")]
public partial class TblSubtable
{
    [Key]
    [Column("code")]
    [StringLength(50)]
    public string Code { get; set; } = null!;

    [Column("menucode")]
    [StringLength(50)]
    public string Menucode { get; set; } = null!;

    [StringLength(200)]
    public string Name { get; set; } = null!;

    [Column("status")]
    public bool? Status { get; set; }
}
