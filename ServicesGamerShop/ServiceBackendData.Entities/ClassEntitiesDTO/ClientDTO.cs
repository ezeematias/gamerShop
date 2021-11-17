using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Entities.ClassEntitiesDTO
{
    public class ClientDTO
    {
        [Key]
        public int IdClient { get; set; }

        [Required]
        [StringLength(20)]
        public string DNI { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Adrdress { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthdayDate { get; set; }

        public bool Available { get; set; }
    }
}
