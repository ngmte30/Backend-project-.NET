using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4Q29_HFT_2021221.Models
{
    public class Generation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey(nameof(Models.Series))]
        public int SeriesID { get; set; }
        [NotMapped]
        public virtual Series Series { get; set; }


        public string Name { get; set; }
        public int Price { get; set; }
        public bool LHR { get; set; }
        public string MemoryType { get; set; }
    }
}
