using System.ComponentModel.DataAnnotations;

namespace OlaTechSolution.Entities
{
    public class Content
    {
        public int Id { get; set; }
        [Required]
        [StringLength(220, MinimumLength = 2)]
        public string Title { get; set; }
        public string HTMLContent { get; set; } 
        public string VideoLink { get; set; }   
        public CategoryItem CategoryItem { get; set; }
    }
}
