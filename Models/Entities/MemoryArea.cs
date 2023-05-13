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
    public class MemoryArea
    {
        public int Id { get; set; }
        [Required]
        public int MaxGB { get; set; }
        public DateTime CreationDate { get; set; }
        public byte[] EncryptionKey { get; set; }

        // Relationships
        public List<User> Users { get; set; } = new(); 
    }
}