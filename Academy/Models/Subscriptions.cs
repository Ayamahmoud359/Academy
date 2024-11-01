using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    public class Subscriptions
    {
        public int SubscriptionId { get; set; }
        //Child Id
        [ForeignKey("Child")]
        public int ChildId { get; set; }
        public Child Child { get; set; }
        //Trainer Id
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        ///SubCategory Id

        [ForeignKey("SubCategory")]
        public int? SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }

    }
}
