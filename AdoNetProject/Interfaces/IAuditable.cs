namespace AdoNetProject.Interfaces
{
    public interface IAuditable
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
