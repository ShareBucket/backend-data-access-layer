using ShareBucket.DataAccessLayer.Models.Entities;

namespace ShareBucket.DataAccessLayer.Models.Entities
{
    public class Partecipate
    {
        // Relationship between User and MemoryArea
        public int UserId { get; set; }
        public int MemoryAreaId { get; set; }
        public DateTime StartDate { get; set; }
    }
}
