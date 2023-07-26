namespace CrudBucketMVC.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}
