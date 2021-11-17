using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Entities.ClassEntitiesDTO
{
    public class CommentDTO
    {
        [Key]
        public int IdComment { get; set; }

        public int IdClient { get; set; }

        public int IdProduct { get; set; }

        [Required]
        [StringLength(2000)]
        public string Description { get; set; }

        public bool State { get; set; }
    }
}
