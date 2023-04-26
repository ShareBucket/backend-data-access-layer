using DataAccessLayer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model.Entities
{
    [Index(nameof(Id), IsUnique = true)]
    public class MemoryArea
    {
        public int Id { get; set; }
        [Required]
        public int MaxGB { get; set; }
        public DateTime CreationDate { get; set; }


        // Relationships
        public List<User> Users { get; set; } = new(); 
    }
}