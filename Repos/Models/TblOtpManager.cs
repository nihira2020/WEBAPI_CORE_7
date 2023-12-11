using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LearnAPI.Repos.Models;

[Table("tbl_otpManager")]
public partial class TblOtpManager
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("username")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Username { get; set; }

    [Column("otptext")]
    [StringLength(10)]
    [Unicode(false)]
    public string Otptext { get; set; } = null!;

    [Column("otptype")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Otptype { get; set; }

    [Column("expiration", TypeName = "datetime")]
    public DateTime Expiration { get; set; }

    [Column("createddate", TypeName = "datetime")]
    public DateTime? Createddate { get; set; }
}
