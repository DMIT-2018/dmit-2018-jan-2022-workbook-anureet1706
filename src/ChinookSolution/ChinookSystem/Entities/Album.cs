// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ChinookSystem.Entities
{
    [Index(nameof(ArtistId), Name = "IFK_AlbumsArtistId")]
    internal partial class Album
    {
        public Album()
        {
            Tracks = new HashSet<Track>();
        }

        //these properties actually hold "real" data.
        [Key]
        public int AlbumId { get; set; }
        [Required(ErrorMessage ="Album title is required")]

        [StringLength(160, ErrorMessage ="Album length is limited to 160")]
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public int ReleaseYear { get; set; }
        [StringLength(50, ErrorMessage ="Album label is limited to 50 characters")]
        [Unicode(false)]
        public string ReleaseLabel { get; set; }
        //navigational properties
        //these properties are virtual each indicaed that they do not actually hold data
        //these properties are "alive or in context" only during the query execution
        [ForeignKey(nameof(ArtistId))]
        [InverseProperty("Albums")]
        public virtual Artist Artist { get; set; }
        [InverseProperty(nameof(Track.Album))]
        public virtual ICollection<Track> Tracks { get; set; }
    }
}