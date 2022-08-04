using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlaTechSolution.Entities
{
    public class MediaType
    {
      public int Id { get; set; }
        [Required]
        [StringLength(220, MinimumLength = 2)]
        public string Title { get; set; }
        [Required]
        public string ThumbNailImagePath { get; set; }

        [ForeignKey("MediaTypeId")]
        public virtual ICollection<CategoryItem> CategoryItems { get;set; }
    }

}
