using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LW4Q29_HFT_2021221.Models
{
    public class Tree
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TreeId { get; set; }
        [ForeignKey(nameof(Plant))]
        public int PlantId { get; set; }

        public virtual Plant plant { get; set; }
    }
}
