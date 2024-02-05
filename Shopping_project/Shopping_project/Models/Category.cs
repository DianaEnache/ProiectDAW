namespace Shopping_project.Models
{
    public class Category
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        //One - to - Many
        public ICollection<Product> Products { get; set;}
    }
}
