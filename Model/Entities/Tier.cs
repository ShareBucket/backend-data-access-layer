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
    public class Tier
    {
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
        [Required]
        public int MaxGB { get; set; }
        [Required]
        public int MaxAreaNumber { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}