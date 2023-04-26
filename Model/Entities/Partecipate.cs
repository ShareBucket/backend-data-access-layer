using DataAccessLayer.Models.Entities;

namespace DataAccessLayer.Model.Entities
{
    public class Partecipate
    {
        // Relationship between User and MemoryArea
        public int UserId { get; set; }
        public int MemoryAreaId { get; set; }
        public DateTime StartDate { get; set; }
    }
}
