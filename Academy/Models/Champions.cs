using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    public class Champions
    {
        public int ChampionId { get; set; }
        public string ChampionNameEN { get; set; }
        public string ChampionNameAR { get; set; }   
        public string ChampionDescriptionEN { get; set; }
        public string ChampionDescriptionAR { get; set; }
        [DataType(DataType.Date)]
        public string ChampionDate { get; set; }
        public bool? IsActive { get; set; }
        ///Department Id
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
      public Department Department { get; set; }
        ///list of Child
        public ICollection<Child> Children { get; set; } = new List<Child>();

    }
}
