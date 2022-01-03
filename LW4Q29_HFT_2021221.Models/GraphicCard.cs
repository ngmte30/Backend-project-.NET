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
    public class GraphicCard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<Series> Serieses { get; set; }
        public string Name { get; set; }
        public int Employees { get; set; }
        public override string ToString()
        {
            return Name;
        }

    }
}
