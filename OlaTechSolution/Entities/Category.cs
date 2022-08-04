using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlaTechSolution.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200,MinimumLength =2)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string ThumbNailImagePath { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<UserCategory> UserCategory { get; set; }
    }
}
