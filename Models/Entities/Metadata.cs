using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBucket.DataAccessLayer.Models.Entities
{
    [Index(nameof(Id), IsUnique = true)]
    public class Metadata
    {
        public int Id { get; set; }
        [Required]
        public int Path { get; set; }
        [Required]
        public string Filename { get; set; }
        [Required]
        public string FileExtension { get; set; }
        public DateTime DataCreation { get; set; }
    }
}
