namespace ServiceBackendData.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        [Key]
        public int IdComment { get; set; }

        public int IdClient { get; set; }

        public int IdProduct { get; set; }

        [Required]
        [StringLength(2000)]
        public string Description { get; set; }

        public bool State { get; set; }

        public virtual Client Client { get; set; }

        public virtual Product Product { get; set; }
    }
}
