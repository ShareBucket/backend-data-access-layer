using DataAccessLayer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model.Entities
{
    [Index(nameof(Id), IsUnique = true)]
    internal class Change
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }


        // Relationships
        public int UserId { get; set; }
        public User User { get; set; }
        public int MemoryAreaId { get; set; }
        public MemoryArea MemoryArea { get; set; }
        public int MetadataId { get; set; }
        public Metadata Metadata { get; set; }
    }
}
