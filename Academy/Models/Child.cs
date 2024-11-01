using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    public class Child
    {
        public int ChildId { get; set; }
        public string ChildName { get; set; }
        ///Put the child age in date attribute <summary>
        [DataType(DataType.Date)]
        public string ChildAge { get; set; }
        public string? Image { get; set; }
        public bool? IsActive { get; set; }
        ///Parent Id
        [ForeignKey("Parent")]
        public int ParentId { get; set; }
        public Parent Parent { get; set; }
        ///Champion Id

        [ForeignKey("Champion")]
        public int? ChampionId { get; set; }
        public Champions? Champion { get; set; }
    }
}
