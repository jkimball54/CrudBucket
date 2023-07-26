namespace CrudBucketMVC.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Owner Owner { get; set; }
    }
}
