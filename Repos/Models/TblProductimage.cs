using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LearnAPI.Repos.Models;

[Table("tbl_productimage")]
public partial class TblProductimage
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("productcode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Productcode { get; set; }

    [Column("productimage", TypeName = "image")]
    public byte[]? Productimage { get; set; }
}
