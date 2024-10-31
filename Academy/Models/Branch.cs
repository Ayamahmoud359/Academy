namespace Academy.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchNameEN { get; set; }
        public string BranchNameAR { get; set; }
        public string BranchAddress { get; set; }
        public string? Image { get; set; }
        public bool IsActive { get; set; }
    }
}
