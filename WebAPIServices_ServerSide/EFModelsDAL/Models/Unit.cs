
namespace EFModelsDAL.Models
{
    public class Unit
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}
