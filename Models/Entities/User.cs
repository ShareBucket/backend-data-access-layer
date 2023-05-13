using ShareBucket.DataAccessLayer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

    namespace ShareBucket.DataAccessLayer.Models.Entities
{
        [Index(nameof(Id), nameof(Email), IsUnique = true)]
        public class User
        {
            public int Id { get; set; }
            [Required]
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            [JsonIgnore]
            public string PasswordHash { get; set; }
            public int UsedMemory { get; set; } = 0;


            // Relationships
            public List<MemoryArea> MemoryAreasPartecipated { get; set; } = new();
            public List<Friendship> Friendships { get; set; } = new();
        }
    }