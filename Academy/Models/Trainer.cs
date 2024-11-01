using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public string? TrainerEmail { get; set; }
        public string TrainerPhone { get; set; }
        public string TrainerAddress { get; set; }
        public string? Image { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        ///Department Id
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        /// category Id

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        ///SubCategory Id

        [ForeignKey("SubCategory")]
        public int? SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }


    }
}
