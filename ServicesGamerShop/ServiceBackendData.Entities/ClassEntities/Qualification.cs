namespace ServiceBackendData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Qualification")]
    public partial class Qualification
    {
        [Key]
        public int IdQualification { get; set; }

        public int IdClient { get; set; }

        public int IdProduct { get; set; }

        public decimal Rating { get; set; }

        public virtual Client Client { get; set; }

        public virtual Product Product { get; set; }
    }
}
