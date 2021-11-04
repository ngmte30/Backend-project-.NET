using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LW4Q29_HFT_2021221.Models
{
    public class Nvidia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int nvidia_cardId { get; set; }
        [ForeignKey(nameof(GraphicCards))]
        public int GpuId { get; set; }
        public string Brand { get; set; }
        public int Generation { get; set; }

        public virtual GraphicCards graphic_card { get; set; }
    }
}
