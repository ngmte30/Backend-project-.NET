using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LW4Q29_HFT_2021221.Models
{
    public class Series
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey(nameof(Models.GraphicCard))]
        public int GraphicCardID { get; set; }
        [NotMapped]
        public virtual GraphicCard GraphicCards { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<Generation> Generations { get; set; }

        public string Name { get; set; }
        public bool isMiner { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
    
}
