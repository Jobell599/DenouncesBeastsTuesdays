namespace DenounceBeasts.API.Entities
{
    public class District
    {
        public int Id { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public bool IsActive { get; set; }
        public string Name { get; set; }

        public string Code { get; set; }

        public int MunicipalityId { get; set; }

        public virtual Municipality Municipality { get; set; }

        //public virtual ICollection<Complain> Complaints { get; set; }
    }
}
