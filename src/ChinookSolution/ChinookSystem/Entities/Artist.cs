﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ChinookSystem.Entities
{
    internal partial class Artist
    {
        public Artist()
        {
            Albums = new HashSet<Album>();
        }

        [Key]
        public int ArtistId { get; set; }
        [StringLength(120,ErrorMessage ="Artist name is limited to 120 characters" )]
        public string Name { get; set; } 

        [InverseProperty(nameof(Album.Artist))]
        public virtual ICollection<Album> Albums { get; set; }
    }
}