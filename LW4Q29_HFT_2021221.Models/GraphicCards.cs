using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4Q29_HFT_2021221.Models
{
    public class GraphicCards
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GpuId { get; set; }
        public string Usability { get; set; }
        

        public virtual ICollection<Nvidia> Nvidias { get; set; }
        public virtual ICollection<Amd> Amds { get; set; }

        //properties neeed here 
    }
}
