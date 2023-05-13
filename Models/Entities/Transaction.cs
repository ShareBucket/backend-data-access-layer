using ShareBucket.DataAccessLayer.Models.Entities;
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
    public class Transaction
    {
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]


        // Relationships
        public int TierId { get; set; }
        public Tier Tier { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        public int ModifierId { get; set; }
        public Modifier Modifier { get; set; }
    }
}
