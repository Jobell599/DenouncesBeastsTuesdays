using System.Data;

namespace DenounceBeasts.API.Entities
{
    public class Municipality
    {
        public int Id { get; set; }

        public DateTime CreateAt {  get; set; }

        public DateTime? UpdatedAt { get; set; }

        public bool IsActive { get; set; }
        public string Name { get; set; }

        public string Code { get; set; }

        public virtual ICollection<District> Districts { get; set; } = new List<District>();
    }
}
