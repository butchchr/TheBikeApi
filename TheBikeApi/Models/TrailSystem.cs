namespace TheBikeApi.Models
{
    public class TrailSystem
    {
        public long Id { get; set; }
        public string Description { get; set;}
        public string Name { get; set;}
        public string City { get; set;}
        public string State { get; set;}
        public string Zip { get; set;}
        public string GpsLocation { get; set;}
        public List<Trail> Trails { get; set;}
    }
}
