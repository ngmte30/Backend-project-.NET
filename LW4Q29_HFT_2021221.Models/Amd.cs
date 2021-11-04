using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4Q29_HFT_2021221.Models
{
   public class Amd
   {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int amd_cardId { get; set; }
        [ForeignKey(nameof(GraphicCards))]
        public int GpuId { get; set; }
        public string Brand { get; set; }
        public int Generation { get; set; }

        public virtual GraphicCards graphic_card { get; set; }
    }
}
