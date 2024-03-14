namespace FrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isDeleted{ get; set; }
        public ICollection<Product>? Products { get; set;}
    }
}
