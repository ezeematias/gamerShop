using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Entities.ClassEntitiesDTO
{
    public class QualificationDTO
    {
        [Key]
        public int IdQualification { get; set; }

        public int IdClient { get; set; }

        public int IdProduct { get; set; }

        public decimal Rating { get; set; }
    }
}
